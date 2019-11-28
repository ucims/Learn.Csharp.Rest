using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpRestExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI event handler
        private void buttonMaju_Click(object sender, EventArgs e)
        {
            RESTClient rESTClient = new RESTClient();
            rESTClient.endPoint = textRequestURL.Text;
            debugOutput("Rest client creater");

            string strResponse = string.Empty;
            strResponse = rESTClient.makeResponse();            
            debugOutput(strResponse);

        }
        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textResponse.Text = textResponse.Text + strDebugText + Environment.NewLine;
                textResponse.SelectionStart = textResponse.TextLength;
                textResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
