namespace SOFT152_1_2
{
    class Property
    {


        string propertyID;
        string propertyName;
        string hostID;
        string hostName;
        int numHostProperties;
        string latitude;
        string longitude;
        string roomType;
        string price;
        int minNightNum;
        int daysAvailable;


        public Property(string propertyID, string propertyName, string hostID, string hostName, int NumHostOfProperties, string latitude, string longitude, string roomType, string price, int minNightNum, int daysAvailable)
        {
            this.propertyID = propertyID;
            this.propertyName = propertyName;
            this.hostID = hostID;
            this.hostName = hostName;
            this.numHostProperties = NumHostOfProperties;
            this.latitude = latitude;
            this.longitude = longitude;
            this.roomType = roomType;
            this.price = price;
            this.minNightNum = minNightNum;
            this.daysAvailable = daysAvailable;

        }




        //GETTERS

        public string GETpropertyID()
        {
            return propertyID;
        }
        public string GETpropertyName()
        {
            return propertyName;
        }
        public string GEThostID()
        {
            return hostID;
        }
        public string GEThostName()
        {
            return hostName;
        }
        public int GETNumOfHostProperties()
        {
            return numHostProperties;
        }
        public string GETlatitude()
        {
            return latitude;
        }
        public string GETlongitude()
        {
            return longitude;
        }
        public string GETroomType()
        {
            return roomType;
        }
        public string GETprice()
        {
            return price;
        }
        public int GETminNightNum()
        {
            return minNightNum;
        }
        public int GETdaysAvailable()
        {
            return daysAvailable;
        }

        //SETTERS

        public void SETpropertyID(string newPropertyID)
        {
            propertyID = newPropertyID;
        }
        public void SETpropertyName(string newPropertyName)
        {
            propertyName = newPropertyName;
        }
        public void SEThostID(string newHostID)
        {
            hostID = newHostID;
        }
        public void SEThostName(string newHostName)
        {
            hostName = newHostName;
        }
        public void SETnumHostProperties(int newNumHostProperties)
        {
            numHostProperties = newNumHostProperties;
        }
        public void SETlatitude(string NewLatitude)
        {
            latitude = NewLatitude;
        }
        public void SETlongitude(string newLongitude)
        {
            longitude = newLongitude;
        }
        public void SETroomType(string newRoomtype)
        {
            roomType = newRoomtype;
        }
        public void SETprice(string newPrice)
        {
            price = newPrice;
        }
        public void SETminNightNum(int newMinNightNumber)
        {
            minNightNum = newMinNightNumber;
        }
        public void SETdaysAvailable(int newDaysAvailable)
        {
            daysAvailable = newDaysAvailable;
        }



    }
}