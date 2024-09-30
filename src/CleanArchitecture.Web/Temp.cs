using System;

namespace CleanArchitecture.Web
{
    public class Temp
    {
        public Temp() {
            // Hardcoded secret information with common patterns
            string apiKey = "AKIAIOSFODNN7EXAMPLE"; // AWS Access Key ID
            string password = "P@ssw0rd1234!"; // Example password
            string azureSASConnectionString = "sv=2015-04-05&sr=b&si=tutorial-policy-635959936145100803&sig=9aCzs76n0E7y5BpEi2GvsSv433BZa22leDOZXX%2BXXIU%3D";

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"API Key: {apiKey}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"azureSASConnectionString: {azureSASConnectionString}");
        }
    }
}
