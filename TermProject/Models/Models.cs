namespace TermProject.Models
{
    public class Trip
    {
        public string ID { get; set; }
        public string TYNote { get; set; }
    }


    public class Package
    {
        public int ID { get; set; }
        public float price { get; set; }
        public string place { get; set; }
        public string transportType { get; set; }
        public string leaveTime { get; set; }
        public string leaveDate { get; set; }
        public string arriveTime { get; set; }
        public string arriveDate { get; set; }

    }

    public class Agent
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MobilePhone { get; set; } = string.Empty;

    }

    public class Traveler
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MobilePhone { get; set; } = string.Empty;

    }

    public class TripPackage
    {
        public int ID { get; set; }

    }

    public class AgentTrip
    {
        public int ID { get; set; }

    }

}
