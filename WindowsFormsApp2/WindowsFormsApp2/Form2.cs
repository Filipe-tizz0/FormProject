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
    public partial class Form2 : Form
    {
        public PostgreConection conect_sucessfull { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            string nome_banco = Nome_DB.Text;
            string porta_banco = Porta_DB.Text;
            string usuario_banco = Usuario_DB.Text;
            string senha_banco = Senha_DB.Text;
            string host_banco = Host_DB.Text;

            PostgreConection conect_ = new PostgreConection();

            if ((nome_banco == null || nome_banco == "") &&
                (porta_banco == null || porta_banco == "") &&
                (usuario_banco == null || usuario_banco == "") &&
                (senha_banco == null || senha_banco == "") &&
                (host_banco == null || host_banco == ""))
            {

                conect_.Conection_Test();

            }
            else
            {
                string String_Conn =
                    $"Server={host_banco};Port={porta_banco};Database={nome_banco};User Id = {usuario_banco}; Password={senha_banco};";

                conect_.set_Conection_String(String_Conn);
            }
            string retorno_conexao = conect_.Conection_Test();


            if (retorno_conexao == "OK")
            {
                this.conect_sucessfull = conect_;

                Console.WriteLine("Chamada com sucesso");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                label_feedback.Text = retorno_conexao;
            }
        }
    }
}
