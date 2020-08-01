using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Agenda
{
    class Compromissos
    {
        public int Id { get; set; }
	    public DateTime Data { get; set; }
	    public TimeSpan Hora { get; set; }
        public string Descricao { get; set; }        
        
        public static List<Compromissos> Listar(DateTime? Data = null)
        {
            using (SqlConnection conexao = Conexao.Conectar())
            {
                StringBuilder textoComando = new StringBuilder();

                textoComando.Append(" SELECT Id           ");
                textoComando.Append("       ,Data         ");
                textoComando.Append("       ,Hora         ");
                textoComando.Append("       ,Descricao    ");
                textoComando.Append("   FROM Compromissos ");

                if (Data != null)
                {
                    textoComando.Append(" WHERE Data = @Data");
                }

                SqlCommand comando = new SqlCommand(textoComando.ToString(), conexao);

                if (Data != null)
                {
                    comando.Parameters.Add("Data", SqlDbType.Date).Value = Data;
                }

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                List<Compromissos> lista = new List<Compromissos>();

                while (leitor.Read())
                {
                    Compromissos compromissos = new Compromissos();
                    compromissos.Id = int.Parse(leitor["Id"].ToString());
                    compromissos.Hora = TimeSpan.Parse(leitor["Hora"].ToString());
                    compromissos.Data = DateTime.Parse(leitor["Data"].ToString());
                    compromissos.Descricao = leitor["Descricao"].ToString();

                    lista.Add(compromissos);
                }

                return lista;
            }
        }

        private static void ConcluirCompromisso(int Id)
        {
            using (SqlConnection conexao = Conexao.Conectar())
            {
                StringBuilder textoComando = new StringBuilder();

                textoComando.Append(" UPDATE Compromissos    ");
                textoComando.Append("    SET Concluido = 'S' ");
                textoComando.Append("  WHERE Id = @Id        ");

                SqlCommand comando = new SqlCommand(textoComando.ToString(),conexao);
                comando.Parameters.Add("Id", SqlDbType.Int).Value = Id;

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public static void VerificaCompromissos()
        {
            using (SqlConnection conexao = Conexao.Conectar())
            {
                StringBuilder textoComando = new StringBuilder();

                textoComando.Append(" SELECT Id              ");
                textoComando.Append("       ,Descricao       ");
                textoComando.Append("   FROM Compromissos    ");
                textoComando.Append("  WHERE Data = @Data    ");
                textoComando.Append("    AND Hora = @Hora    ");
                textoComando.Append("    AND Concluido = 'N' ");

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = textoComando.ToString();

                comando.Parameters.Add("Data", SqlDbType.Date).Value = DateTime.Now.Date;
                comando.Parameters.Add("Hora", SqlDbType.Time).Value = DateTime.Now.ToShortTimeString(); ;

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                string lembrete = "";

                while (leitor.Read())
                {
                    if (lembrete != "")
                    {
                        lembrete = lembrete + "\n";
                    }

                    lembrete = lembrete + leitor["Descricao"].ToString();
                    ConcluirCompromisso(int.Parse(leitor["Id"].ToString()));
                }

                if (lembrete != "")
                {

                    MessageBox.Show(lembrete. ToString(),
                                    "Lembrete",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
                }
            }
        }

        public void Gravar()
        {
            using (SqlConnection conexao = Conexao.Conectar())
            {
                StringBuilder textoComando = new StringBuilder();

                textoComando.Append("INSERT INTO Compromissos");
                textoComando.Append("           (Data        ");
                textoComando.Append("           ,Hora        ");
                textoComando.Append("           ,Descricao   ");
                textoComando.Append("           ,Concluido)  ");
                textoComando.Append("     VALUES             ");
                textoComando.Append("           (@Data       ");
                textoComando.Append("           ,@Hora       ");
                textoComando.Append("           ,@Descricao  ");
                textoComando.Append("           ,'N')        ");

                SqlCommand comando = new SqlCommand(textoComando.ToString(), conexao);
                comando.Parameters.Add("Data", SqlDbType.Date).Value = this.Data;
                comando.Parameters.Add("Hora", SqlDbType.Time).Value = this.Hora;
                comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = this.Descricao;

                conexao.Open();
                comando.ExecuteNonQuery(); 
            }
        }
    }
}
