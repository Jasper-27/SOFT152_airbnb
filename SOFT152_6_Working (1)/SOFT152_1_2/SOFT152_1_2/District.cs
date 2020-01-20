namespace SOFT152_1_2
{
    class District
    {
        string districtName;
        int numOfNeighbourhoods;
        Neighbourhood[] neighbourhoods;

        public District(string NEWDistrictName, int NEWNumOfNeighbourhoods, Neighbourhood[] NEWneighbourhoods)
        {
            districtName = NEWDistrictName;
            numOfNeighbourhoods = NEWNumOfNeighbourhoods;
            neighbourhoods = NEWneighbourhoods;

        }

        //GETTERS

        public string GETdistrictName() { return districtName; }
        public int GETnumOfNeighbourhoods() { return numOfNeighbourhoods; }
        public Neighbourhood[] GETneighbourhoods() { return neighbourhoods; }


        //SETTERS

        public void SETdistrictName(string NEWDistrictName)
        {
            districtName = NEWDistrictName;
        }

        public void SETnumOfNeighbourhoods(int NEWnumOfNeighbourhoods)
        {
            numOfNeighbourhoods = NEWnumOfNeighbourhoods;
        }

        public void SETneighbourhoods(Neighbourhood[] NEWneighbourhoods)
        {
            neighbourhoods = NEWneighbourhoods;
        }
    }
}
