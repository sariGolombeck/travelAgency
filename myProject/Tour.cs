namespace myProject
{
    public class Tour
    {
        public int Code { get; set; }
        public string TName { get; set; }
         public string Description { get; set; }
        public string Leader { get; set; }
        public string Land { get; set; }
       public DateTime start { get; set; }
        public DateTime end { get; set; }

        public Tour()
        {

        }
        public Tour(string tName, string description, string leader, string land, DateTime start, DateTime end, int code)
        {
            TName = tName;
            Description = description;
            Leader = leader;
            Land = land;
            this.start = start;
            this.end = end;
            Code = code;
        }
    }
}
