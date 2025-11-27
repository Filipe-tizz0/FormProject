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
using Postgre.Conection;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private PostgreConection Conexao_postgre;
        private Controle_XML control;
        public Form3(PostgreConection conn)
        {
            InitializeComponent();
            this.Conexao_postgre = conn;
            control = new Controle_XML(Conexao_postgre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(control.criar_xml(this))
            {
                control.Show_XML(this);
                control.call_inserir_XML();
            }
        }

        private void Leitura_Singular_XMl_Click(object sender, EventArgs e)
        {
            control.Show_XML(this);
        }
    }
}
