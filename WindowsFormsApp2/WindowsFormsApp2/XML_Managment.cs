using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using WindowsFormsApp2;
using System.Windows.Forms;
using Postgre.Conection;

namespace Xml.Manegment
{
    public class Tarefas_XML
    {

        [XmlElement("Nome-tarefa")]
        public string obrig { get; set; }

        [XmlElement("Descrição da tarefa")]
        public string Desc_tarefa { get; set; }

        public Tarefas_XML()
        {
        }

        public Tarefas_XML(string obrigacao, string Descricao)
        {
            this.Desc_tarefa = Descricao;
            this.obrig = obrigacao;
        }
    }


    [XmlRoot("colaborador")]
    public class Colaborador
    {
        [XmlElement("Nome")]
        public string Nome { get; set; }

        [XmlElement("Cargo")]
        public string Cargo { get; set; }

        [XmlArray("Obrigacoes")]
        [XmlArrayItem("Tarefas")]
        public List<Tarefas_XML> ListaObrigacoes { get; set; }

        public Colaborador()
        {
            ListaObrigacoes = new List<Tarefas_XML>();
        }
    }


    public class Controle_XML
    {
        private PostgreConection Conexao_postgre;
        public Controle_XML(PostgreConection conn)
        {
            Conexao_postgre = conn;
        }

        public bool criar_xml(Form3 form)
        {
            Colaborador XML_colaborador = new Colaborador
            {
                Nome = form.Nome_Colaborador.Text,
                Cargo = form.Cargo_Colaborador.Text
            };

            // Tarefa 1
            if (!string.IsNullOrWhiteSpace(form.Obrig_tarefa1.Text) && !string.IsNullOrWhiteSpace(form.Desc_tarefa1.Text))
            {
                Tarefas_XML tarefa1 = new Tarefas_XML(form.Obrig_tarefa1.Text, form.Desc_tarefa1.Text);
                XML_colaborador.ListaObrigacoes.Add(tarefa1);
            }

            // Tarefa 2
            if (!string.IsNullOrWhiteSpace(form.Obrig_tarefa2.Text) && !string.IsNullOrWhiteSpace(form.Desc_tarefa2.Text))
            {
                Tarefas_XML tarefa2 = new Tarefas_XML(form.Obrig_tarefa2.Text, form.Desc_tarefa2.Text);
                XML_colaborador.ListaObrigacoes.Add(tarefa2);
            }

            // Tarefa 3
            if (!string.IsNullOrWhiteSpace(form.Obrig_tarefa3.Text) && !string.IsNullOrWhiteSpace(form.Desc_tarefa3.Text))
            {
                Tarefas_XML tarefa3 = new Tarefas_XML(form.Obrig_tarefa3.Text, form.Desc_tarefa3.Text);
                XML_colaborador.ListaObrigacoes.Add(tarefa3);
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Colaborador));

                using (StreamWriter writer = new StreamWriter("Colaborador.xml"))
                {
                    serializer.Serialize(writer, XML_colaborador);
                }

                MessageBox.Show("Arquivo XML 'Colaborador.xml' criado e salvo com sucesso!",
                                "Sucesso na Serialização",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return true;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Erro de Estrutura XML: {ex.InnerException.Message}",
                                "Erro Grave de Serialização",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}",
                                "Erro Desconhecido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return false;
            }
        }

        public void Show_XML(Form3 form)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Colaborador));
            using (StreamReader reader = new StreamReader("Colaborador.xml"))
            {
                Colaborador colaborador = (Colaborador)serializer.Deserialize(reader);
                form.XML_Read_TextBox.Text = $@"Nome: {colaborador.Nome},
Cargo: {colaborador.Cargo}
";
                int i = 1;

                foreach (Tarefas_XML tasks in colaborador.ListaObrigacoes)
                {
                    form.XML_Read_TextBox.Text =
                        form.XML_Read_TextBox.Text + $@"    -- {i}° Tarefa:
        Tarefa: {tasks.obrig},
        Descrição: {tasks.Desc_tarefa};
                    
";
                    i++;
                }
            }
        }

        public void call_inserir_XML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Colaborador));
            List<string> lista_de_obrigacoes = new List<string>();

            using (StreamReader reader = new StreamReader("Colaborador.xml"))
            {
                Colaborador colaborador = (Colaborador)serializer.Deserialize(reader);

                foreach (Tarefas_XML tasks in colaborador.ListaObrigacoes)
                {
                    lista_de_obrigacoes.Add(tasks.obrig);
                    lista_de_obrigacoes.Add(tasks.Desc_tarefa);
                }

                if(Conexao_postgre != null)
                {
                    Conexao_postgre.insert_XML(colaborador.Nome, colaborador.Cargo, lista_de_obrigacoes);
                } else
                {
                    MessageBox.Show("Não foi posspivel salvar pois ainda não tem conexão");
                }
            }
        }
    }
}
