namespace PrimitiveObsession.Better
{
    public class Password
    {
        public Password(string password)
        {
            if (!IsValid(password))
            {
                throw new System.ArgumentException("Invalid value.", nameof(password));
            }
            Value = password;
        }

        public static bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return false;
            }
            return true;
        }

        public bool Equals(Password password)
        {
            return Value.Equals(password.Value);
        }


        public static implicit operator Password(string password)
        {
            return new Password(password);
        }

        public string Value { get; private set; }
    }
}