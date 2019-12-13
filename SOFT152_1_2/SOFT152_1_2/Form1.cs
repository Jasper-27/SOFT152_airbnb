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



        public int selectedDistrict;
        public int selectedNeighbourhood;

        StreamReader inData;
        //int dataLinCount = File.ReadLines(theFile).Count();



        Neighbourhood[] allNeighbourhoods;
        District[] allDistricts;
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
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgDist.Rows.Clear();
            dgNeig.Rows.Clear();
            dgProp.Rows.Clear();

            string[] tempDistNames = new string[allDistricts.Length]; 


          

            //Makes an array string with the district names
            for (int i = 0; i < tempDistNames.Length; i++)
            {
                tempDistNames[i] = allDistricts[i].GETdistrictName();
               
            }


            dgDist.Rows.Clear(); 

            for (int i = 0; i < tempDistNames.Length; i++)
            {
                dgDist.Rows.Add(tempDistNames[i]);
            }

           
   
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

        private void dgDist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

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

            
        }

        private void dgNeig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

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

        }


        /// <summary>
        /// This is where we are doing stuff now
        /// </summary>
        public void read()
        {
            string[] districtString = new string[0]; 
            foreach (DataGridViewRow row in dgDist.Rows)
            {
                Array.Resize(ref districtString, districtString.Length + 1); 
                districtString[districtString.Length - 1] = row.Cells[0].Value.ToString();
                
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            read(); 
        }

    }




}


