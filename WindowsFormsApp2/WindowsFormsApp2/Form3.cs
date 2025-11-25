using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xml.Manegment;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private Controle_XML control = new Controle_XML();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(control.criar_xml(this))
            {
                control.Show_XML(this);
            }
        }

        private void Leitura_Singular_XMl_Click(object sender, EventArgs e)
        {
            control.Show_XML(this);
        }
    }
}
