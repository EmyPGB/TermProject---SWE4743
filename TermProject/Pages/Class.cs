namespace TermProject.Pages
{
    //Person class
    public class Person
    {
        public string name = null;
        public string mobilePhone = null;
    }

    //Agent class
    class Agent: Person
    {
        public string name { get; set; }
        public string mobilePhone { get; set; }

    }

    //Traveler class
    class Traveler : Person
    {
        public string name { get; set; }
        public string mobilePhone { get; set; }

    }

    //Person Singleton
    class PersonSingleton : Traveler
    {
        void loadPeople()
        {

        }

    }
}
