using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using WindowsFormsApp2;
using System.Data;
using NpgsqlTypes;

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
                Conexao_postgres.Open();
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


                NpgsqlCommand cmd = new NpgsqlCommand(query, Conexao_postgres);

                if (query.Trim().ToUpper().StartsWith("SELECT"))
                {
                    dataTable = new DataTable();
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    dataTable.Load(reader);

                    form.datagrid_result.DataSource = dataTable;

                }
                else
                {
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

        public void Salvar_Json(string json_form)
        {
            try
            {
                string query = "INSERT INTO jSON_SAVE (detalhes) VALUES (@json_)";

                var insert = new NpgsqlCommand(query, Conexao_postgres);

                insert.Parameters.Add("json_", NpgsqlDbType.Jsonb).Value = json_form;
                insert.ExecuteNonQuery();
                MessageBox.Show("JSON salvo com sucesso no banco de dados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PostgresException pe)
            {
                MessageBox.Show($"Erro durante a execução da query (PostgreSQL): {pe.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NpgsqlException pge)
            {
                MessageBox.Show($"Erro de Conexão Npgsql: {pge.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ge)
            {
                MessageBox.Show($"Erro geral: {ge.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insert_XML(string nome_colab,
            string cargo,
            List<string> lista_obrigacoes)
        {
            try
            {
                string query = "INSERT INTO colaborador (cargo, tarefa_1, desc_tarefa_1, tarefa_2, desc_tarefa_2, tarefa_3, desc_tarefa_3) " +
                    "VALUES (@cargo, @tarefa1, @desc_tarefa1, @tarefa2, @desc_tarefa2, @tarefa3, @desc_tarefa3)";

                var insert = new NpgsqlCommand(query, Conexao_postgres);

                insert.Parameters.Add("cargo", NpgsqlDbType.Varchar).Value = cargo;
                insert.Parameters.Add("tarefa1", NpgsqlDbType.Varchar).Value = lista_obrigacoes.Count > 0 ? lista_obrigacoes[0] : "";
                insert.Parameters.Add("desc_tarefa1", NpgsqlDbType.Varchar).Value = lista_obrigacoes.Count > 1 ? lista_obrigacoes[1] : "";
                insert.Parameters.Add("tarefa2", NpgsqlDbType.Varchar).Value = lista_obrigacoes.Count > 2 ? lista_obrigacoes[2] : "";
                insert.Parameters.Add("desc_tarefa2", NpgsqlDbType.Varchar).Value = lista_obrigacoes.Count > 3 ? lista_obrigacoes[3] : "";
                insert.Parameters.Add("tarefa3", NpgsqlDbType.Varchar).Value = lista_obrigacoes.Count > 4 ? lista_obrigacoes[4] : "";
                insert.Parameters.Add("desc_tarefa3", NpgsqlDbType.Varchar).Value = lista_obrigacoes.Count > 5 ? lista_obrigacoes[5] : "";

                insert.ExecuteNonQuery();
                MessageBox.Show("XML salvo com sucesso no banco na tabela colaborador!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PostgresException pe)
            {
                MessageBox.Show($"Erro durante a execução da query (PostgreSQL): {pe.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NpgsqlException pge)
            {
                MessageBox.Show($"Erro de Conexão Npgsql: {pge.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ge)
            {
                MessageBox.Show($"Erro geral: {ge.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
