using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CertTests
{
    class  Program
    {
        static void Main(string[] args)
        { 

            X509Certificate2 cert = null;

            if (args.Length >= 2)
            {
                cert = CreateCert(args[1]);
            }

            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192), Console.InputEncoding, false, 8192));
            while (cert == null)
            {
                Log.Info("Please input public key (base64 encoded x.509):");

                var certString = Console.ReadLine();
                cert = CreateCert(certString);
                Console.WriteLine("Subject:" + cert.Subject);
            }

            CertUtil.ValidateCertificateChain(cert);

            Log.Info("Done verifying certificate. Press a key to continue.");
            Console.ReadLine();
        }

        private static X509Certificate2 CreateCert(string base64EncodedPublicKey)
        {
            try
            {
                var bytes = Convert.FromBase64String(base64EncodedPublicKey);
                return new X509Certificate2(bytes);
            }
            catch
            {
                Log.Error("Invalid certificate.");
            }
            return null;
        }


    }


}
