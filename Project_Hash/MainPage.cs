using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Project_Hash
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public string myHashFunction()
        {
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] hashValue;
            byte[] StringToByte;
            string inputString;

            inputString = txtBlockNr.Text + txtNounce.Text + txtHashInput.Text;
            inputString += txtPrev.Text;

            string gitString;
            gitString = "gitgit";

            StringToByte = Encoding.ASCII.GetBytes(inputString);
            hashValue = mySHA256.ComputeHash(StringToByte);
            string retValue = String.Empty;
            foreach (byte i in hashValue)
            {
                retValue += String.Format("{0:x2}", i);
            }
            return retValue;

        }

        private void cmdHash_Click(object sender, EventArgs e)
        {
            txtHashedValue.Text = myHashFunction();
        }

 
        private void btnKeys_Click(object sender, EventArgs e)
        {
            MyCrypto myCrypto = new MyCrypto();
            richTxtKeys.Text = myCrypto.AssignNewKey();
        }
    }

    public class MyCrypto
    {
        RSACryptoServiceProvider rsa = null;
        string publicPrivateKeyXML;
        string publicOnlyKeyXML;
        public string AssignNewKey()
        {
            const int PROVIDER_RSA_FULL = 1;
            const string CONTAINER_NAME = "KeyContainer";
            CspParameters cspParams;
            cspParams = new CspParameters(PROVIDER_RSA_FULL);
            cspParams.KeyContainerName = CONTAINER_NAME;
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
            cspParams.ProviderName = "Microsoft Strong Cryptographic Provider";
            rsa = new RSACryptoServiceProvider(cspParams);

            //Pair of public and private key as XML string.
            //Do not share this to other party
            //publicPrivateKeyXML = rsa.ToXmlString(true);
            return rsa.ToXmlString(true);         //Private key in xml file, this string should be share to other parties
            //publicOnlyKeyXML = rsa.ToXmlString(false);

        }
    }
}
