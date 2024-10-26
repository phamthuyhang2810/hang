using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace PhamThuyHang_T7
{
    public partial class Form4 : Form
    {
        string path = @"D:\form.xml";
        public Form4()
        {
            InitializeComponent();
        }

        //public void Write(InfoWindow iw)
        //{
        //    XmlSerializer write = new XmlSerializer(typeof(InfoWindow));
        //    StreamWriter file = new StreamWriter(path);
        //    write.Serialize(file, iw);
        //    file.Close();
        //}

        private void Form4_load(object sender, EventArgs e)
        {

        }

        private void Form4_Resizeend(object sender, EventArgs e)
        {

        }
    }
}
