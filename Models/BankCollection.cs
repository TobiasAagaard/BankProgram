namespace BankProgram
{
    class BankCollection
    {
        private List<Bank> banks;

        public BankCollection(List<Bank> banks)
        {
            this.banks = banks;
        }

        public List<Bank> Banks { get { return banks; } private set { banks = value; } }
    }
}