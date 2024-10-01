using System;

namespace CleanArchitecture.Web
{
    public class Temp
    {
        private const string bucketName = "your-bucket-name";
        private const string keyName = "your-object-key";
        private const string awsAccessKey = "AKIAIOSFODNN7EXAMPLE";
        private const string awsSecretKey = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY";

        //private static readonly RegionEndpoint bucketRegion = RegionEndpoint.USEast1; // Change to your bucket's region

        public Temp() {
            // Hardcoded secret information with common patterns
            string apiKey = "AKIAIOSFODNN7EXAMPLE"; // AWS Access Key ID
            string password = "P@ssw0rd1234!"; // Example password
            string azureSASConnectionString = "sv=2015-04-05&sr=b&si=tutorial-policy-635959936145100803&sig=9aCzs76n0E7y5BpEi2GvsSv433BZa22leDOZXX%2BXXIU%3D";

            //s3Client = new AmazonS3Client(awsAccessKey, awsSecretKey, bucketRegion);

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"API Key: {apiKey}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"azureSASConnectionString: {azureSASConnectionString}");
        }
    }
}
