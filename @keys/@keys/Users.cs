namespace _keys
{
    public class Users
    {
        public int ID { get; set; }
        public string login { get; set; }
        public string password { get; set; }   
        public int time {  get; set; }

        public static Time ConvertSecondsToDate(int date)
        {
            int hours = date / 3600 % 24;
            int minutes = date / 60 % 60;
            int seconds = date % 60;
            return new Time(System.Convert.ToUInt32(hours), System.Convert.ToUInt32(minutes), System.Convert.ToUInt32(seconds));
        }
    }
}
