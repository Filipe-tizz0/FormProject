using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using WindowsFormsApp2;
using System.Data;

namespace Postgre.Conection
{
    public class PostgreConection
    {
        public NpgsqlConnection Conexao_postgres;
        public string Conection_String =
            "Server=localhost;Port=5432;Database=SGBD_Project;User Id = postgres; Password=PostgreSQL123;";

        public void set_Conection_String(string conn)
        {
            this.Conection_String = conn;
        }

        public string Conection_Test()
        {
            var new_conect = new NpgsqlConnection(Conection_String);
            try
            {
                Conexao_postgres = new_conect;
                new_conect.Open();
                Console.WriteLine("Conexão realizada com sucesso");
                return "OK";
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Erro durante a conexão: {ex.Message}");
                return ex.Message;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
                return e.Message;
            }
        }

        public void Close_Connection()
        {
            this.Conexao_postgres.Close();
        }

        public void execute_query(string query, Form1 form)
        {
            try
            {
                DataTable dataTable = null;

                // O 'using' garante que a conexão e o comando sejam fechados corretamente
                //NpgsqlConnection conn = tho_postgres;


                NpgsqlCommand cmd = new NpgsqlCommand(query, Conexao_postgres);

                if (query.Trim().ToUpper().StartsWith("SELECT"))
                {
                    // É uma consulta de leitura (SELECT)
                    dataTable = new DataTable();
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    // Carrega os resultados no DataTable
                    dataTable.Load(reader);

                    form.datagrid_result.DataSource = dataTable;

                }
                else
                {
                    // É uma operação de modificação (INSERT, UPDATE, DELETE)
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Comando executado. {rowsAffected} linha(s) afetada(s).");
                    form.datagrid_result.DataSource = null;
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Erro durante a execução: {ex.Message}");
                MessageBox.Show($"Erro durante a execução: {ex.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
                MessageBox.Show($"Erro inesperado: {e.Message}");
            }
        }
    }
}
