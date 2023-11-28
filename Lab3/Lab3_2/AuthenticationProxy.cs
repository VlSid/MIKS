using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal class AuthenticationProxy : IAuthentication
    {
        AuthenticationUser aut;

        public AuthenticationProxy(AuthenticationUser aut)
        {
            this.aut = aut;
        }

        public void Authenticate()
        {
            Console.WriteLine("Select an authentication method:\n" +
                "1. Fingerprint\n" +
                "2. Face\n" +
                "3. Two-factor authentication");
            Console.Write("Enter the method number: ");

            int choice = int.Parse(Console.ReadLine());

            //selection of authentication methods
            switch (choice)
            {
                case 1:
                    FingerPrintAuthentication();
                    break;
                case 2:
                    FaceRecognitionAuthentication();
                    break;
                case 3:
                    TwoFactorAuthentication();
                    break;
                default:
                    Console.WriteLine("Wrong choice.");
                    break;
            }
        }

        //Fingerprint authentication method
        private void FingerPrintAuthentication()
        {
            Console.WriteLine("Fingerprint authentication is performed.");
        }

        //Face authentication method
        private void FaceRecognitionAuthentication()
        {
            Console.WriteLine("Facial authentication is performed.");         
        }

        //Method of two-factor authentication
        private void TwoFactorAuthentication()
        {
            aut.Authenticate();// Invoking standard authentication
            Console.WriteLine($"Two-factor authentication is performed for the user '{aut.Username}'.");
        }
    }
}
