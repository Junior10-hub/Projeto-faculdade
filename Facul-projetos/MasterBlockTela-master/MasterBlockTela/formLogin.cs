using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace MasterBlockTela
{
    public partial class formLogin : Form
    {


        SqlConnection sqlConn = null;
        private string strCoon = "Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;";
        private string _Sql = string.Empty;

        public bool logado = false;

        public formLogin()
        {
            InitializeComponent();
            txtLogin.Select();
        }

        public void logar()
        {
            sqlConn = new SqlConnection(strCoon);


            try
            {
                string usu = txtLogin.Text;
                string pwd = txtSenha.Text;


                _Sql = "SELECT COUNT(ID) FROM TB_LOGIN WHERE USUARIO = @USUARIO AND SENHA = @SENHA";

                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);

                cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = pwd;

                sqlConn.Open();

                Int64 v = Convert.ToInt64(cmd.ExecuteScalar());

                if (v > 0)
                {
                    MessageBox.Show("Logado com sucesso");
                    logado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalidos!");
                }


            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "no banco");
            }
            sqlConn.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logar();
        }
    }
}
