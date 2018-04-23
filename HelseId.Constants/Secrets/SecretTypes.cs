namespace HelseId.Constants.Secrets
{
    public static class SecretTypes
    {
        public const string EnterpriseX509CertificateBase64 = "EnterpriseX509CertificateBase64";

        // This is a special case of the client authentication method private_key_jwt - where a RSA key pair is generated, and the public key is 
        // saved as a XML formatted string in the client configuration
        public const string RsaPrivateKeyJwtSecret = "private_key_jwt:RsaPrivateKeyJwtSecret";

    }
}
