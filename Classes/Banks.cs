namespace BankProgram
{
    class Bank
    {
        private int id;
        private string name;
        private List<Advisor> advisors;

        public Bank(int id, string name, List<Advisor> advisors)
        {
            this.id = id;
            this.name = name;
            this.advisors = advisors;
        }

        public int BankId { get { return id; } private set { id = value; } }

        public string BankName { get { return name; } private set { name = value; } }
        public List<Advisor> Advisors { get { return advisors; } private set { advisors = value;}}

    }
}