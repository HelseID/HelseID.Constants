using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace CertTests
{
    public class CertUtil
    { 
        public static void ValidateCertificateChain(X509Certificate2 certificate)
        {
            string error = null;
            X509Chain certificateChain = new X509Chain();
            certificateChain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
            certificateChain.ChainPolicy.VerificationTime = DateTime.Now;

            certificateChain.ChainPolicy.RevocationMode = X509RevocationMode.Offline; // Use windows cache
            certificateChain.ChainPolicy.UrlRetrievalTimeout = new TimeSpan(0, 0, 10);

            try
            {
                if (certificateChain.Build(certificate))
                {
                    foreach (X509ChainElement element in certificateChain.ChainElements)
                    {
                        Log.Info($"Issuer = {element.Certificate.Issuer}\nSubject = {element.Certificate.Subject}");
                        element.Certificate.Verify();
                    }
                }
                else
                {

                    error = string.Format("Error validating certificate.");
                    foreach (X509ChainStatus status in certificateChain.ChainStatus)
                    {
                        error += status.StatusInformation;
                    }
                }
            }
            catch (Exception ex)
            {
                error = string.Format($"Exception building certificate chain. The error is {ex.Message}");
            }

            if (!string.IsNullOrEmpty(error))
            {
                Log.Info(error);
            }
        }
    }
}

