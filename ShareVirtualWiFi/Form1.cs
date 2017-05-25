using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareVirtualWiFi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ShareWIFI myWIFI = new ShareWIFI();

        private void open_Click(object sender, EventArgs e)
        {
            string result = myWIFI.shareWiFI("lw1","liwei123456");
            Console.WriteLine(result);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            myWIFI.CloseWIFI();
        }
    }
}
