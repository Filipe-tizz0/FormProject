using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Postgre.Conection;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        private PostgreConection Conexao;
        private Form1 form_principal;
        public Form5(PostgreConection conexao, Form1 form_principal)
        {
            InitializeComponent();
            Conexao = conexao;
            this.form_principal = form_principal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Conexao == null)
            {
                MessageBox.Show("A Conexão ainda não foi realizada!");
                return;
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO enderecos (endereco, bairro, numero) VALUES('{this.textBox3.Text}', '{this.textBox2.Text}', '{this.textBox1.Text}')";

                    Conexao.execute_query(query, form_principal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Conexao == null)
            {
                MessageBox.Show("A Conexão ainda não foi realizada!");
                return;
            }
            else
            {
                try
                {
                    string query = $"UPDATE enderecos set endereco = '{this.textBox3.Text}', bairro = '{this.textBox2.Text}', numero = {this.textBox1.Text} WHERE id = '{this.textBox4.Text}'";

                    Conexao.execute_query(query, form_principal);
                }
                catch (NullReferenceException per)
                {
                    MessageBox.Show($"Erro: {per.Message}");
                }
                catch (NpgsqlException pger)
                {
                    MessageBox.Show($"Erro: {pger.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Conexao == null)
            {
                MessageBox.Show("A Conexão ainda não foi realizada!");
                return;
            }
            else
            {
                try
                {
                    string query = $"DELETE FROM enderecos WHERE id = '{this.textBox4.Text}'";

                    Conexao.execute_query(query, form_principal);
                }
                catch (NullReferenceException per)
                {
                    MessageBox.Show($"Erro: {per.Message}");
                }
                catch (NpgsqlException pger)
                {
                    MessageBox.Show($"Erro: {pger.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Conexao == null)
            {
                MessageBox.Show("A Conexão ainda não foi realizada!");
                return;
            }
            else
            {
                try
                {
                    string query = $"SELECT * FROM ENDERECOS";

                    Conexao.execute_query(query, form_principal);
                }
                catch (NullReferenceException per)
                {
                    MessageBox.Show($"Erro: {per.Message}");
                }
                catch (NpgsqlException pger)
                {
                    MessageBox.Show($"Erro: {pger.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }
    }


}
