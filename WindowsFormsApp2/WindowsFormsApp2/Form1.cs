using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Postgre.Conection;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public PostgreConection Conexao_postgres;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            Form2 novo_form = new Form2();

            if (novo_form.ShowDialog() == DialogResult.OK)
            {
                Conexao_postgres = novo_form.conect_sucessfull;
                MessageBox.Show("Conexão carregada!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Execute_button_Click(object sender, EventArgs e)
        {
            try
            {
                //Query_return.Text = "clicado";
                Conexao_postgres.execute_query(this.richTextBox_Query.Text, this);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro: {err}");
            }
        }

        private void Xml_Button_Click(object sender, EventArgs e)
        {
            Form3 form_xml = new Form3();

            form_xml.ShowDialog();
        }

        private void Chamada_api_Button_Click(object sender, EventArgs e)
        {
            Form4 form_api = new Form4();

            form_api.ShowDialog();
        }
    }
}
