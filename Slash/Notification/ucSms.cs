using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Slash.Notification
{
    public partial class ucSms : UserControl
    {
        public ucSms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string to, msg;
                to = textBox1.Text;
                msg = richTextBox1.Text;
                // string baseUrl= "https://platform.clickatell.com/messages/http/send?apiKey=HP8TuZ7RTX2u3qi9OGL-nw==&to=9779808703963&content='"+msg+"'";
                string baseUrl = "https://platform.clickatell.com/messages/http/send?apiKey=HP8TuZ7RTX2u3qi9OGL-nw==&to=9779808703963&content=Test+message+text";
                client.OpenRead(baseUrl);
                MessageBox.Show("Sent");
            }
            catch(Exception exp)
            {
                MessageBox.Show("error");
            }
        }
    }
}
