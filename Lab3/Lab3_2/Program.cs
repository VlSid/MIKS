namespace Lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAuthentication authentication = new AuthenticationProxy(new AuthenticationUser());
            authentication.Authenticate();
        }
    }
}