namespace SOFT152_1_2
{
    class Property
    {


        string propertyID;
        string propertyName;
        string hostID;
        string hostName;
        int NumOfHostProperties;
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
            this.NumOfHostProperties = NumHostOfProperties;
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
            return NumOfHostProperties;
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
        public void SETNumOfHostPropertys(int newNumOfHostProperties)
        {
            NumOfHostProperties = newNumOfHostProperties;
        }
        public void SETlatitude(string NewLatitude)
        {
            latitude = NewLatitude;
        }
        public void SETlongirude(string newLongitude)
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