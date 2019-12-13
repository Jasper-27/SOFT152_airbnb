namespace SOFT152_1_2
{
    class Neighbourhood
    {

        string neighbourhoodName;
        int numOfProperties;
        Property[] properties;

        public Neighbourhood(string NEWneighbourhoodName, int NEWnumOfPropertiesm, Property[] NEWproperties)
        {

            neighbourhoodName = NEWneighbourhoodName;
            numOfProperties = NEWnumOfPropertiesm;
            properties = NEWproperties;

        }

        //GETTERS

        public string GETneighbourhoodName() { return neighbourhoodName; }
        public int GETnumOfProperties() { return numOfProperties; }
        public Property[] GETproperties() { return properties; }


        //SETTERS

        public void SETneighbourhoodName(string newNeighbourhoodName)
        {
            neighbourhoodName = newNeighbourhoodName;
        }

        public void SETnumOfProperties(int NEWnumOfProperties)
        {
            numOfProperties = NEWnumOfProperties;
        }

        public void SETneighbourhoods(Property[] NEWproperty)
        {
            properties = NEWproperty;
        }

    }
}
