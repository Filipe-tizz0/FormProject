using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private async void Realizar_Chamada_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.URL_TextBox.Text))
                {
                    await Listar_Get(this);
                }
                else
                {
                    MessageBox.Show("Url vazia, favor preencher os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch(HttpRequestException er)
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
    }
}
