using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace login
{
    public partial class formlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "text/HTML";
        }

        protected void BTNcadastrar_Click(object sender, EventArgs e)
        {
            String insertSql;
            String selectSql;
            var saida = "";
            //Alterar a String de Conexão com os dados do seu SQL Server

            String conStr = "Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True";

            insertSql = "INSERT INTO TB_LOGIN(usuario,senha) VALUES(@USUARIO,@SENHA)";
            selectSql = "SELECT * FROM TB_LOGIN";
            SqlConnection conexao = new SqlConnection(conStr);
            SqlCommand sqlComando = new SqlCommand(insertSql, conexao);
            SqlCommand sqlComando2 = new SqlCommand(selectSql, conexao);
            SqlDataReader dataReader;


            try
            {
                sqlComando.Parameters.Add(new SqlParameter("@USUARIO", TXTnome.Text));
                sqlComando.Parameters.Add(new SqlParameter("@SENHA", TXTsenha.Text));
                conexao.Open();
                sqlComando.ExecuteNonQuery();
                dataReader = sqlComando2.ExecuteReader();
                while (dataReader.Read())
                {
                    saida = saida + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "<br />";
                }
                Response.Write(saida);
                DIVdadosTabela.InnerHtml = saida;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            LimpaText();
        }
        private void LimpaText()
        {
            TXTnome.Text = string.Empty;
            TXTsenha.Text = string.Empty;
        }

        protected void TXTnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
