using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Rest.Authenticating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMajuAuth_Click(object sender, EventArgs e)
        {
            RESTClient rESTClient = new RESTClient();
            rESTClient.endPoint = textBoxURI.Text;
            debugOutput("Rest client creator ");
            string strResponse = string.Empty;
            strResponse = rESTClient.makeResponse();
            debugOutput(strResponse);
            debugOutput("Rest client creator ");
        }

        private void debugOutput(string strDebug)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebug + Environment.NewLine);
                textBoxResponse.Text = textBoxResponse.Text + strDebug + Environment.NewLine;
                textBoxResponse.SelectionStart = textBoxResponse.TextLength;
                textBoxResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
