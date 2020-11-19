namespace PrimitiveObsession.Better
{
    public class Username
    {
        public Username(string username)
        {
            if (!IsValid(username))
            {
                throw new System.ArgumentException("Invalid value.", nameof(username));
            }
            Value = username;
        }

        public static bool IsValid(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }
            return true;
        }

        public static implicit operator Username(string username)
        {
            return new Username(username);
        }

        public string Value { get; private set; }
    }
}