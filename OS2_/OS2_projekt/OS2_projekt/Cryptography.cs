using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Asn1.X509;
using System.IO;

namespace OS2_projekt
{
    class Cryptography
    {
        public static string RSASignWithPEMPrivateKey(string privateKeyPEMFileName, string text)
        {
            byte[] bytesToSign = Encoding.UTF8.GetBytes(text);
            AsymmetricCipherKeyPair keyPair = null;
            TextReader reader = File.OpenText(privateKeyPEMFileName);
            keyPair = (AsymmetricCipherKeyPair)new PemReader(reader).ReadObject();

            byte[] signature = RSASignWithPrivateKey(keyPair, bytesToSign);
            string result = Convert.ToBase64String(signature);

            return result;
        }
        public static byte[] RSASignWithPrivateKey(AsymmetricCipherKeyPair keyPair, byte[] bytesToSign)
        {
            Sha256Digest sha256Digest = new Sha256Digest();
            byte[] theHash = new byte[sha256Digest.GetDigestSize()];
            sha256Digest.BlockUpdate(bytesToSign, 0, bytesToSign.Length);
            sha256Digest.DoFinal(theHash, 0);

            PssSigner signer = new PssSigner(new RsaEngine(), new Sha256Digest(), sha256Digest.GetDigestSize());
            signer.Init(true, keyPair.Private);
            signer.BlockUpdate(theHash, 0, theHash.Length);
            byte[] signature = signer.GenerateSignature();

            return signature;
        }
        public static bool VerifySignature(string PublicKeyPEMFileName, string Text, string ExpectedSignature)
        {
            byte[] bytesToSign = Encoding.UTF8.GetBytes(Text);
            byte[] expectedSignatureBytes = Convert.FromBase64String(ExpectedSignature);

            TextReader reader = File.OpenText(PublicKeyPEMFileName);
            AsymmetricKeyParameter keyPair = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();

            Sha256Digest sha256Digest = new Sha256Digest();
            byte[] theHash = new byte[sha256Digest.GetDigestSize()];
            sha256Digest.BlockUpdate(bytesToSign, 0, bytesToSign.Length);
            sha256Digest.DoFinal(theHash, 0);

            PssSigner signer = new PssSigner(new RsaEngine(), new Sha256Digest(), sha256Digest.GetDigestSize());
            signer.Init(false, keyPair);
            signer.BlockUpdate(theHash, 0, theHash.Length);
            return signer.VerifySignature(expectedSignatureBytes);
        }
    }
}
