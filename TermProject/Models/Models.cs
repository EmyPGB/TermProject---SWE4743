
using System.ComponentModel.DataAnnotations.Schema;

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

        public static implicit operator Traveler(List<Traveler> v)
        {
            throw new NotImplementedException();
        }
    }

    public class TripPackage
    {
        public int ID { get; set; }

    }

    public class AgentTrip
    {
        public int ID { get; set; }

    }


    public class Payment
    {
        public int ID { get; set; }
        public float AmountPaid { get; set; }

        public List<CreditCard> CreditCards { get; set; }
    }

    public class CreditCard
    {
        public int ID { get; set; }
        public int CardNumber { get; set; }
        public string ExpDate { get; set; }

        [ForeignKey("PaymentID")]
        public virtual Payment Payment { get; set; }

        [ForeignKey("AmountPaid")]
        public virtual Payment AmountPaid { get; set; }
    }

    public class Cash
    {
        public int ID { get; set; }
        public float Amount { get; set; }

        [ForeignKey("PaymentID")]
        public virtual Payment Payment { get; set; }

        [ForeignKey("AmountPaid")]
        public virtual Payment AmountPaid { get; set; }
    }

    public class Check
    {
        public int ID { get; set; }
        public int CheckNumber { get; set; }

        public float Amount { get; set; }

        [ForeignKey("PaymentID")]
        public virtual Payment Payment { get; set; }

        [ForeignKey("AmountPaid")]
        public virtual Payment AmountPaid { get; set; }




    }
}
