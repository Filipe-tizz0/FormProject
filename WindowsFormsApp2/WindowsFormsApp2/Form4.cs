using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;using Postgre.Conection;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public PostgreConection Conexao_banco;
        public Form4(PostgreConection conn = null)
        {
            InitializeComponent();
            this.Conexao_banco = conn;
        }

        private async void Realizar_Chamada_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.URL_TextBox.Text))
                {
                    await Listar_Get(this);
                    this.Salvar_Json();
                }
                else
                {
                    MessageBox.Show("Url vazia, favor preencher os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (HttpRequestException er)
            {
                MessageBox.Show($"Erro na requisição: {er.Message}", "Erro durante a requisição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception eg)
            {
                MessageBox.Show($"Erro: {eg.Message}", "Erro desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static async Task Listar_Get(Form4 form)
        {
            using (HttpClient client = new HttpClient())
            {
                form.API_Result.Text = await client.GetStringAsync(form.URL_TextBox.Text);
            }
        }

        public void Salvar_Json()
        {
            try
            {
                if (Conexao_banco != null)
                {
                    Conexao_banco.Salvar_Json(this.API_Result.Text);
                }
                else
                {
                    MessageBox.Show($"Erro: Conexão não estabelecida com o banco.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
