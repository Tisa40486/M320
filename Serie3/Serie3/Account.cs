namespace Serie3
{
    public class Account
    {
        private int _numberAccount;
        private int _balance;
        public Account(int numberAccount)
        {
            _numberAccount = numberAccount;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
