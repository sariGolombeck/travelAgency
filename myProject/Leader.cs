namespace myProject
{
    public class Leader
    {
        public  Tour tourLeader { get; set; }
       public List<Order> GroupLeader { get; set; }
        public int Ld { get; set; }
        public Leader()
        {

        }
        public Leader(int ld,Tour tourLeader, List<Order> groupLeader)
        {
            this.tourLeader = tourLeader;
            GroupLeader = groupLeader;
            this.Ld = ld;
        }
    }
}
