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
    public partial class clientes : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        public clientes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "INSERT INTO TB_CLIENTE(NOME, EMAIL, SENHA, CPFCNPJ, TELEFONE,ENDERECO,TIPOCLIENTE) VALUES(@NOME, @EMAIL, @SENHA, @CPFCNPJ, @TELEFONE,@ENDERECO,@TIPOCLIENTE)";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@SENHA", txtSenha.Text);
                comando.Parameters.AddWithValue("@CPFCNPJ", Convert.ToInt32(txtCPF.Text));
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@TIPOCLIENTE", cbCliente.SelectedItem);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados incluidos com sucesso");


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
                strSQL = "UPDATE TB_CLIENTE SET NOME = @NOME, EMAIL = @EMAIL, SENHA = @SENHA, CPFCNPJ = @CPFCNPJ, TELEFONE = @TELEFONE, ENDERECO = @ENDERECO, TIPOCLIENTE = @TIPOCLIENTE WHERE ID = @ID";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@SENHA", txtSenha.Text);
                comando.Parameters.AddWithValue("@CPFCNPJ", Convert.ToInt32(txtCPF.Text));
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@TIPOCLIENTE", txtTipo.Text);

                MessageBox.Show("Dados atualizados");
                conexao.Open();
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                txtID.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
                txtEndereco.Clear();
                txtTipo.Clear();
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
                DataSet ds = new DataSet();
                da = new SqlDataAdapter("selecionacliente", conexao);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "DELETE TB_CLIENTE WHERE ID = @ID";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente excluido");
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True; MultipleActiveResultSets=True;");
                strSQL = "SELECT * FROM TB_CLIENTE WHERE ID = @ID";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));

                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["Nome"];
                    txtEmail.Text = (string)dr["Email"];
                    txtSenha.Text = (string)dr["senha"];
                    txtCPF.Text = (string)dr["Cpfcnpj"].ToString();
                    txtTelefone.Text = (string)dr["telefone"];
                    txtEndereco.Text = (string)dr["Endereco"];    
                    txtTipo.Text = (string)dr["tipocliente"];
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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

    
    }
}