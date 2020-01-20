using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SOFT152_1_2
{
   


    public partial class Form1 : Form
    {
        //Declaring the public variables S

        public static string theFile; 

        public bool endOfDistricts = false;
        public bool endOfNeighbourhoods = false;

        public bool newDistrict = false; 


        public int selectedDistrict;
        public int selectedNeighbourhood;
        public int selectedProperty; 

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

        //Returns a district from the file
        private District gogetDistrict()
        {
           
            District tempDistrict;

            //Reads the data from the file 
            string tempDistrictName = inData.ReadLine();
            string tempNeighbourhoodNum = inData.ReadLine();


            //Neighbourhood

            int NeighbourhoodsInDistrict = Convert.ToInt32(tempNeighbourhoodNum);

            Neighbourhood[] allNeighbourhoods = new Neighbourhood[NeighbourhoodsInDistrict];


            //If the district name retunesnull, stop checking as the file is finished 
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

                    ///tempProperty = new Property(tempPropertyID, tempPropertyName, hostID, hostName, Convert.ToInt32(tempNumOfHostProperties), tempLatitude, tempLongitude, tempRoomType, tempPrice, Convert.ToInt32(tempMinNightNum), Convert.ToInt32(tempDaysAvailable));


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

        private void fillInDistTable()
        {
            dgDist.Rows.Clear(); 
            dgNeig.Rows.Clear();
            selectedNeighbourhood = -1;
            dgProp.Rows.Clear();

            //fills in the district table
            string[] tempDistNames = new string[allDistricts.Length];

            //Makes an array string with the district names
            for (int i = 0; i < tempDistNames.Length; i++)
            {
                tempDistNames[i] = allDistricts[i].GETdistrictName();
                dgDist.Rows.Add(tempDistNames[i]);
            }
        }

        private void fillInNeigTable()
        {
            
            dgNeig.Rows.Clear();
            selectedNeighbourhood = -1;
            dgProp.Rows.Clear();

            //fills in the Neighbourhood table
            string[] tempNeigNames = new string[allNeighbourhoods.Length];

            //Makes an array string with the Neighbourhood names
            for (int i = 0; i < tempNeigNames.Length; i++)
            {
                tempNeigNames[i] = allNeighbourhoods[i].GETneighbourhoodName();
                dgNeig.Rows.Add(tempNeigNames[i]);

            }


            //
        }

        private void fillInPropTable()
        {


            dgProp.Rows.Clear();

            //fills in the Neighbourhood table
            string[] tempPropNames = new string[allProperties.Length];

            foreach (Property tempProp in allProperties)
            {
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

        private void setup()
        {
            dgDist.Rows.Clear();
            dgNeig.Rows.Clear();
            selectedNeighbourhood = -1;
            dgProp.Rows.Clear();



            allDistricts = new District[0];
            allNeighbourhoods = new Neighbourhood[0];
            allProperties = new Property[0];

            endOfDistricts = false;
            endOfNeighbourhoods = false;

            try 
            {
                

                inData = new StreamReader(theFile);
               

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

                fillInDistTable();


            }
            catch
            {
                MessageBox.Show("ERROR reading from file"); 
            }

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            setup();   
        }

        public void readDistricts()
        {
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

        }

        public void readNeighbourhoods()
        {
            //Reading the neighbourhood values 
            

            District currentDist = allDistricts[selectedDistrict];
            allNeighbourhoods = currentDist.GETneighbourhoods();

            int x = currentDist.GETnumOfNeighbourhoods(); 

            for (int i = 0; i < currentDist.GETnumOfNeighbourhoods(); i++)
            {

                //allNeighbourhoods[i].SETneighbourhoodName(dgNeig.Rows[i].Cells["neigName"].Value.ToString());

                //MessageBox.Show(i.ToString()); 
                //tempString = dgNeig.Rows[i].Cells["neigName"].Value.ToString();
            }
            
            
        }

        public void readProperties()
        {
            //Read the properties values
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


        //This is the function that reads the data 
        public void read()
        {
            // MessageBox.Show(dgDist.Rows[0]);

            //reading the districts values 
            if (dgProp.Rows.Count != 0)
            {
                readDistricts();
            }


            //Reading the neighbourhood values 
            if (dgNeig.Rows.Count != 0)
            {
                readNeighbourhoods();
            }


            //Reading the property values
            if (dgProp.Rows.Count != 0)
            {
                readProperties();
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            //read();


            //Reads the data on the screen, incase it has not allready been added to the array 
            readDistricts();
            readNeighbourhoods(); 
            readProperties();
            


            //Saving the data 
            try
            {
                outData = new StreamWriter(theFile);
            }
            catch
            {
                MessageBox.Show("Cannot open stream Writer on this file. It could be being used by another process.");

             

            }



            foreach (District dis in allDistricts)
            {
                //If the program can write the district data to the file 
                try
                {
                    outData.WriteLine(dis.GETdistrictName());
                    outData.WriteLine(dis.GETnumOfNeighbourhoods());
                }
                catch
                {
                    MessageBox.Show("There is no Data to save");
                    break; 
                }

                //writes the neighbourhood data to the file 
                if (dis.GETnumOfNeighbourhoods() != 0)
                {
                    allNeighbourhoods = dis.GETneighbourhoods();
                    foreach (Neighbourhood nei in allNeighbourhoods)
                    {
                        outData.WriteLine(nei.GETneighbourhoodName());
                        outData.WriteLine(nei.GETnumOfProperties());

                        if (nei.GETnumOfProperties() != 0)
                        {   
                            //Writes the property data to the file 
                            allProperties = nei.GETproperties();
                            foreach (Property tempProp in allProperties)
                            {
                                outData.WriteLine(tempProp.GETpropertyID());
                                outData.WriteLine(tempProp.GETpropertyName());
                                outData.WriteLine(tempProp.GEThostID());
                                outData.WriteLine(tempProp.GEThostName());
                                outData.WriteLine(tempProp.GETNumOfHostProperties().ToString());
                                outData.WriteLine(tempProp.GETlatitude());
                                outData.WriteLine(tempProp.GETlongitude());
                                outData.WriteLine(tempProp.GETroomType());
                                outData.WriteLine(tempProp.GETprice());
                                outData.WriteLine(tempProp.GETminNightNum().ToString());
                                outData.WriteLine(tempProp.GETdaysAvailable().ToString());
                            }
                        }
                    }
                }
            }

            //Tries to close the file. But doesnt if is null (not opened in the first place) 
            try
            {
                outData.Close();
            }
            catch { }
             
        }


        //Adds a row to the property grid 
        private void addPropRow(Property tempProp)
        {
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


            dgProp.Rows.Add(row);
        }

        private void dgDist_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
 
            //Checks if the datagrid is empty or not
            if (dgNeig.Rows.Count != 0)
            {
                readNeighbourhoods();
            }
            if (dgProp.Rows.Count != 0)
            {
                readProperties();
            }


            selectedDistrict = dgDist.Rows[e.RowIndex].Index;

            dgNeig.Rows.Clear();
            dgProp.Rows.Clear();


            //Populates the neighbourhood datagrid 
            try
            {
                District tempDistrict = allDistricts[selectedDistrict];
                Neighbourhood[] tempNeighbourhoods = tempDistrict.GETneighbourhoods();

                if (tempDistrict.GETnumOfNeighbourhoods() != 0)
                {
                    string[] tempNeighNames = new string[tempNeighbourhoods.Length];


                    //Makes an array string with the district names
                    for (int i = 0; i < tempDistrict.GETnumOfNeighbourhoods(); i++)
                    {
                        tempNeighNames[i] = tempNeighbourhoods[i].GETneighbourhoodName();
                        dgNeig.Rows.Add(tempNeighNames[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cannot add a district if there is no file open");
            }

        }

        

        private void dgNeig_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

           
                //read();
                if (dgNeig.Rows.Count !=0)
                {
                    readNeighbourhoods();
                }

                //Checks if the datagrid is empty or not
                if (dgProp.Rows.Count != 0)
                {
                    readProperties();
                }
                

                selectedNeighbourhood = dgNeig.Rows[e.RowIndex].Index;

            

                dgProp.Rows.Clear();

                //Populates the property datagrid the property data 
                District tempDistrict = allDistricts[selectedDistrict];
                Neighbourhood[] tempNeighbourhoods = tempDistrict.GETneighbourhoods();


                Neighbourhood tempNeighbourhood = tempNeighbourhoods[selectedNeighbourhood];

                Property[] tempProperties = tempNeighbourhood.GETproperties();

              
                for (int i = 0; i < tempNeighbourhood.GETnumOfProperties(); i++)
                {
                    addPropRow(tempProperties[i]);    
                }

        }

        //Opens the file 
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (OFDGetData.ShowDialog() == DialogResult.OK)
            {
                theFile = OFDGetData.FileName;
            }
            setup();
        }


        //Adding the properties 
        private void btnAddDist_Click(object sender, EventArgs e)
        {
             
            District newDistrict = new District(" ",0,null); //Creates a new district and puts it on the data grid. It can be edited later
            Array.Resize(ref allDistricts, allDistricts.Length + 1);
            allDistricts[allDistricts.Length - 1] = newDistrict;

            dgDist.Rows.Add(newDistrict.GETdistrictName());

        }
        private void btnAddNeig_Click(object sender, EventArgs e)
        {
            try
            {
                District currentDist = allDistricts[selectedDistrict];  //sets the current working district using the users selection 

                allNeighbourhoods = currentDist.GETneighbourhoods();
                Neighbourhood newNeighbourhood = new Neighbourhood(" ", 0, null);

                if (allNeighbourhoods == null) // if there are not any neighbourhoods allready in the district, set the array to be none
                {
                    Array.Resize(ref allNeighbourhoods, 0);
                }

                Array.Resize(ref allNeighbourhoods, allNeighbourhoods.Length + 1); 


                allNeighbourhoods[allNeighbourhoods.Length - 1] = newNeighbourhood;

                //Set the current district to have the new neighbourhood
                currentDist.SETnumOfNeighbourhoods(allNeighbourhoods.Length);
                currentDist.SETneighbourhoods(allNeighbourhoods);

          

                dgNeig.Rows.Add(newNeighbourhood.GETneighbourhoodName());
            }
            catch
            {
                MessageBox.Show("Error reading data from file"); 
            }
            


        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (selectedNeighbourhood != -1)
            {
                District currentDist = allDistricts[selectedDistrict];
                allNeighbourhoods = currentDist.GETneighbourhoods();

                //Makes sure there is a district for the neighbourhood to be added too. 
                if (currentDist.GETnumOfNeighbourhoods() == 0)
                {
                    MessageBox.Show("Cannot add a property with no neighbourhood"); 
                }
                else
                {
                    Neighbourhood currentNeig = allNeighbourhoods[selectedNeighbourhood];
                    allProperties = currentNeig.GETproperties();
                    Property newProperty = new Property(" ", " ", " ", " ", 0, " ", " ", " ", " ", 0, 0);

                    if (allProperties == null)
                    {
                        Array.Resize(ref allProperties, 0);
                    }
                    Array.Resize(ref allProperties, allProperties.Length + 1);

                    allProperties[allProperties.Length - 1] = newProperty;

                    currentNeig.SETnumOfProperties(allProperties.Length);
                    currentNeig.SETproperties(allProperties);

                    //fillInPropTable();

                    addPropRow(newProperty);
                }

            }
            else
            {
                MessageBox.Show("Cannot add a property if a neighbourhood is not selected"); 
            }
            
        }



       /// 

        //Deletes the users selected property 
        private void btnDelProp_Click(object sender, EventArgs e)
        {
           

            try
            {
                //Works out which district and neighbourhood the property belongs too 
                District currentDist = allDistricts[selectedDistrict];
                allNeighbourhoods = currentDist.GETneighbourhoods();
                Neighbourhood currentNeig = allNeighbourhoods[selectedNeighbourhood];
                allProperties = currentNeig.GETproperties();

               


                for (int i = selectedProperty; i < currentNeig.GETnumOfProperties() - 1; i++)
                {
                    // moving elements downwards, to fill the gap at [i]
                    allProperties[i] = allProperties[i + 1];
                }
                // De-increments the array 
                Array.Resize(ref allProperties, allProperties.Length - 1);


                currentNeig.SETnumOfProperties(allProperties.Length);
                currentNeig.SETproperties(allProperties);

                dgProp.Rows.Clear();

                //Makes an array string with the district names
                for (int i = 0; i < currentNeig.GETnumOfProperties(); i++)
                {
                    addPropRow(allProperties[i]);
                }
            }catch
            {
                MessageBox.Show("Select valid property to delete"); 
            }
        }


        //Sets the selected property when the users changes row (allows for row deletion) 
        private void dgProp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedProperty = dgProp.Rows[e.RowIndex].Index;
        }

    }




}


