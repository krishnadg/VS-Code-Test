using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Auth;
using Amazon.S3;
using Amazon.S3.Model;
namespace VS_Code_Test
{class UploadObject
    {
        static string bucketName = "*** bucket name ***";
        static string keyName    = "*** key name when object is created ***";
        static string filePath   = "*** absolute path to a sample file to upload ***";

        static IAmazonS3 client;



        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Console.WriteLine("Test2");
            Console.WriteLine("Test3");
            Console.WriteLine("Test4");
            Console.WriteLine("Test5");
            Console.WriteLine("Test6");
            Console.WriteLine("Test7");

        }
    }
}
