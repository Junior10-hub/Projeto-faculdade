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

namespace MasterBlockTela
{
    public partial class funcionarios : Form
    {

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        public funcionarios()
        {
            InitializeComponent();
        }

        private void funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "INSERT INTO TB_FUNCIONARIO(NOME, CPF, TELEFONE, EMAIL, SENHA, FUNCAO) VALUES(@NOME, @CPF, @TELEFONE, @EMAIL, @SENHA, @FUNCAO)";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@CPF", txtCPF.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@SENHA", txtSenha.Text);
                comando.Parameters.AddWithValue("@FUNCAO", cbFuncao.SelectedItem);

                conexao.Open();
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "UPDATE TB_FUNCIONARIO SET NOME = @NOME, CPF = @CPF, TELEFONE = @TELEFONE, EMAIL = @EMAIL, SENHA = @SENHA, FUNCAO = @FUNCAO WHERE ID = @ID";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@CPF", txtCPF.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@SENHA", txtSenha.Text);
                comando.Parameters.AddWithValue("@FUNCAO", txtFuncao.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "DELETE TB_FUNCIONARIO WHERE ID = @ID";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "SELECT * FROM TB_FUNCIONARIO";
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();
                da.Fill(ds);
                dgvDados.DataSource = ds.Tables[0];

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "SELECT * FROM TB_FUNCIONARIO WHERE ID = @ID";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);

                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["Nome"];
                    txtCPF.Text = (string)dr["cpf"].ToString();
                    txtTelefone.Text = (string)dr["telefone"];
                    txtEmail.Text = (string)dr["Email"];
                    txtSenha.Text = (string)dr["senha"];
                    txtFuncao.Text = (string)dr["Funcao"];
                }
                dr.Close();

                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void cbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}