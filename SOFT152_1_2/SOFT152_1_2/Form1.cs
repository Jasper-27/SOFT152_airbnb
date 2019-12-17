using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SOFT152_1_2
{
   


    public partial class Form1 : Form
    {
        //District 
        //Neighbourhood[] neighbourhoods;

        public static string theFile; 

        public bool endOfDistricts = false;
        public bool endOfNeighbourhoods = false;

        public bool autoCellAdd = true;



        public int selectedDistrict;
        public int selectedNeighbourhood;

        StreamReader inData;
        StreamWriter outData; 
        //int dataLinCount = File.ReadLines(theFile).Count();



       
        District[] allDistricts;
        Neighbourhood[] allNeighbourhoods;
        Property[] allProperties;

        public Form1()
        {
            
            InitializeComponent();


            if (OFDGetData.ShowDialog() == DialogResult.OK)
            {
                theFile = OFDGetData.FileName;

                //MessageBox.Show(file); 
            }
            else
            {
                theFile = ("data.txt"); 
            }


            setup();

            

           

        }

        private District gogetDistrict()
        {
           
            District tempDistrict;


            string tempDistrictName = inData.ReadLine();
            string tempNeighbourhoodNum = inData.ReadLine();


            //Neighbourhood

            int NeighbourhoodsInDistrict = Convert.ToInt32(tempNeighbourhoodNum);

            Neighbourhood[] allNeighbourhoods = new Neighbourhood[NeighbourhoodsInDistrict];


            //Stops checking for librarys if the libname is null (this stops the program for endlessly checking 
            if (tempDistrictName == null)
            {
                endOfDistricts = true;
            }


            //This is the Neighbourhood bit 
            for (int i = 0; i < NeighbourhoodsInDistrict; i++)
            {

                Neighbourhood tempNeighbourhood;

                string tempNeighbourhoodName = inData.ReadLine();
                string tempNumOfProperties = inData.ReadLine();

                int propertiesInNeighbourhood = Convert.ToInt32(tempNumOfProperties);

                Property[] allProperties = new Property[propertiesInNeighbourhood];

                //This is the property bit
                for (int ii = 0; ii < propertiesInNeighbourhood; ii++)
                {
                    Property tempProperty;


                    //Reading the properties from the file 
                    string tempPropertyID = inData.ReadLine();
                    string tempPropertyName = inData.ReadLine();
                    string hostID = inData.ReadLine();
                    string hostName = inData.ReadLine();
                    string tempNumOfHostProperties = inData.ReadLine();
                    string tempLatitude = inData.ReadLine();
                    string tempLongitude = inData.ReadLine();
                    string tempRoomType = inData.ReadLine();
                    string tempPrice = inData.ReadLine();
                    string tempMinNightNum = inData.ReadLine();
                    string tempDaysAvailable = inData.ReadLine();

                    //tempProperty = new Property(tempPropertyID, tempPropertyName, hostID, hostName, Convert.ToInt32(tempNumOfHostProperties), tempLatitude, tempLongitude, tempRoomType, tempPrice, Convert.ToInt32(tempMinNightNum), Convert.ToInt32(tempDaysAvailable));


                    //Creating a temp property ready to be added to the property array 
                    tempProperty = new Property(tempPropertyID, tempPropertyName, hostID, hostName, Convert.ToInt32(tempNumOfHostProperties), tempLatitude, tempLongitude, tempRoomType, tempPrice, Convert.ToInt32(tempMinNightNum), Convert.ToInt32(tempDaysAvailable));
                    allProperties[ii] = tempProperty;
                }

                //Creating the temporty Neighbourhood and adding it to the nighbourhood array
                tempNeighbourhood = new Neighbourhood(tempNeighbourhoodName, Convert.ToInt32(tempNumOfProperties), allProperties);
                allNeighbourhoods[i] = tempNeighbourhood;
            }

            tempDistrict = new District(tempDistrictName, Convert.ToInt32(tempNeighbourhoodNum), allNeighbourhoods);

            return tempDistrict;
        }

        private void setup()
        {
            try 
            {

                endOfDistricts = false;
                endOfNeighbourhoods = false;

                inData = new StreamReader(theFile);
                allDistricts = new District[0];
                allNeighbourhoods = new Neighbourhood[0];
                allProperties = new Property[0];

                while (endOfDistricts == false)
                {
                    Array.Resize(ref allDistricts, allDistricts.Length + 1);
                    allDistricts[allDistricts.Length - 1] = gogetDistrict();

                    //Checks the library name to see if the library iteself is set to null 
                    string tempName = allDistricts[allDistricts.Length - 1].GETdistrictName();

                    ///Gets rid of the final item in the array if it is set to null. This makes sure there is the correct number of librarys present. 
                    if (tempName == null)
                    {
                        Array.Resize(ref allDistricts, allDistricts.Length - 1);
                    }

                }
                inData.Close();


                //fills in the district table
                string[] tempDistNames = new string[allDistricts.Length];

                //Makes an array string with the district names
                for (int i = 0; i < tempDistNames.Length; i++)
                {
                    tempDistNames[i] = allDistricts[i].GETdistrictName();

                }

                for (int i = 0; i < tempDistNames.Length; i++)
                {
                    dgDist.Rows.Add(tempDistNames[i]);
                }
            }
            catch
            {
                MessageBox.Show("ERROR reading from file"); 
            }

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgDist.Rows.Clear();
            dgNeig.Rows.Clear();
            dgProp.Rows.Clear();

            setup();
   
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //OFDGetData.ShowDialog();


            if (OFDGetData.ShowDialog() == DialogResult.OK)
            {
                theFile = OFDGetData.FileName;

                //MessageBox.Show(file); 
            }

            setup();
        }

        //This is the function that reads the data 
        public void read()
        {
           // MessageBox.Show(dgDist.Rows[0]);


            //Reading the districts values
            try
            {
                for (int i = 0; i < allDistricts.Length; i++)
                {
                    allDistricts[i].SETdistrictName(dgDist.Rows[i].Cells["distName"].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("could not read data from District data grid");
            }

          
            //Reading the neighbourhood values 
            try
            {
  
                District currentDist = allDistricts[selectedDistrict];
                allNeighbourhoods = currentDist.GETneighbourhoods();

                for (int i = 0; i < allNeighbourhoods.Length; i++)
                {
                   
                   allNeighbourhoods[i].SETneighbourhoodName(dgNeig.Rows[i].Cells["neigName"].Value.ToString());
                   //tempString = dgNeig.Rows[i].Cells["neigName"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("could not read data from Neighbourhood data grid");
            }


            try
            {
                Neighbourhood curentNeig = allNeighbourhoods[selectedNeighbourhood];
                allProperties = curentNeig.GETproperties();
               


                
                for (int i = 0; i < allProperties.Length; i++)
                {

                    /// this bit gets the data from the property datagrid 
                    allProperties[i].SETpropertyID(dgProp.Rows[i].Cells["propID"].Value.ToString());
                    allProperties[i].SETpropertyName(dgProp.Rows[i].Cells["propName"].Value.ToString());
                    allProperties[i].SEThostID(dgProp.Rows[i].Cells["propHostID"].Value.ToString());
                    allProperties[i].SEThostName(dgProp.Rows[i].Cells["propHostName"].Value.ToString());
                    allProperties[i].SETnumHostProperties(Convert.ToInt32(dgProp.Rows[i].Cells["propHostProperties"].Value));  ///Deals with int
                    allProperties[i].SETlatitude(dgProp.Rows[i].Cells["propLatitude"].Value.ToString());  
                    allProperties[i].SETlongitude(dgProp.Rows[i].Cells["propLongitude"].Value.ToString()); 
                    allProperties[i].SETroomType(dgProp.Rows[i].Cells["propRoomType"].Value.ToString()); 
                    allProperties[i].SETprice(dgProp.Rows[i].Cells["propPrice"].Value.ToString()); 
                    allProperties[i].SETminNightNum(Convert.ToInt32(dgProp.Rows[i].Cells["propMinNight"].Value)); 
                    allProperties[i].SETdaysAvailable(Convert.ToInt32(dgProp.Rows[i].Cells["propDaysAvailable"].Value));                    
                   
                }


            }
            catch
            {
                MessageBox.Show("could not read data from property data grid");
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            read();


            //Saving the data 

            outData = new StreamWriter(theFile);


            foreach (District dis in allDistricts)
            {
                outData.WriteLine(dis.GETdistrictName()); 
                outData.WriteLine(dis.GETnumOfNeighbourhoods());

                allNeighbourhoods = dis.GETneighbourhoods();
                foreach (Neighbourhood nei in allNeighbourhoods)
                {
                    outData.WriteLine(nei.GETneighbourhoodName());
                    outData.WriteLine(nei.GETnumOfProperties());

                    allProperties = nei.GETproperties();
                    foreach (Property pro in allProperties)
                    {
                        outData.WriteLine(pro.GETpropertyID());
                        outData.WriteLine(pro.GETpropertyName());
                        outData.WriteLine(pro.GEThostID());
                        outData.WriteLine(pro.GEThostName());
                        outData.WriteLine(pro.GETNumOfHostProperties().ToString());
                        outData.WriteLine(pro.GETlatitude());
                        outData.WriteLine(pro.GETlongitude());
                        outData.WriteLine(pro.GETroomType());
                        outData.WriteLine(pro.GETprice());
                        outData.WriteLine(pro.GETminNightNum().ToString());
                        outData.WriteLine(pro.GETdaysAvailable().ToString());
                    }


                }
                


            }

            outData.Close(); 
        }

        private void dgDist_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if  (autoCellAdd == false)
            {
                MessageBox.Show("Hello"); 
            }
        }


        private void dgDist_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            autoCellAdd = true;

            try
            {
                selectedDistrict = dgDist.Rows[e.RowIndex].Index;

                dgNeig.Rows.Clear();
                dgProp.Rows.Clear();

                District tempDistrict = allDistricts[selectedDistrict];
                Neighbourhood[] tempNeighbourhoods = tempDistrict.GETneighbourhoods();

                string[] tempNeighNames = new string[tempNeighbourhoods.Length];



                //Makes an array string with the district names
                for (int i = 0; i < tempNeighNames.Length; i++)
                {
                    tempNeighNames[i] = tempNeighbourhoods[i].GETneighbourhoodName();
                    dgNeig.Rows.Add(tempNeighNames[i]);
                }

            }
            catch
            {
                MessageBox.Show("Make a valid selection");
            }

            autoCellAdd = false;
        }

        private void dgNeig_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            autoCellAdd = true;


            try
            {
                selectedNeighbourhood = dgNeig.Rows[e.RowIndex].Index;

                dgProp.Rows.Clear();


                District tempDistrict = allDistricts[selectedDistrict];
                Neighbourhood[] tempNeighbourhoods = tempDistrict.GETneighbourhoods();


                Neighbourhood tempNeighbourhood = tempNeighbourhoods[selectedNeighbourhood];

                Property[] tempProperties = tempNeighbourhood.GETproperties();



                //Makes an array string with the district names
                for (int i = 0; i < tempProperties.Length; i++)
                {
                    Property tempProp = tempProperties[i];

                    string[] row = new string[11];

                    row[0] = tempProp.GETpropertyID();
                    row[1] = tempProp.GETpropertyName();
                    row[2] = tempProp.GEThostID();
                    row[3] = tempProp.GEThostName();
                    row[4] = tempProp.GETNumOfHostProperties().ToString();
                    row[5] = tempProp.GETlatitude();
                    row[6] = tempProp.GETlongitude();
                    row[7] = tempProp.GETroomType();
                    row[8] = tempProp.GETprice();
                    row[9] = tempProp.GETminNightNum().ToString();
                    row[10] = tempProp.GETdaysAvailable().ToString();


                    //StempNeighNames[i] = tempNeighbourhoods[i].GETneighbourhoodName();
                    dgProp.Rows.Add(row);
                }


            }
            catch
            {
                MessageBox.Show("Make a valid Neigbourhood selection");
            }

            autoCellAdd = false;

        }

        private void dgNeig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }




}


