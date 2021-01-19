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
    public partial class produtos : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;



        public produtos()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "INSERT INTO TB_TRANSACAO(PRODUTO, QUANTIDADE, VALOR, TIPO, TRANSACAO, STATUSTRANSACAO, DATATRANSACAO, HASHTRANSACAO)VALUES(@PRODUTO, @QUANTIDADE, @VALOR, @TIPO, @TRANSACAO, @STATUSTRANSACAO, GETDATE(), NEWID())";
                //strSQL = new SqlCommand("inserirproduto");
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@PRODUTO", txtProduto.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                comando.Parameters.AddWithValue("@VALOR", txtValor.Text);
                comando.Parameters.AddWithValue("@TIPO", cbmTipo.SelectedItem);
                comando.Parameters.AddWithValue("@TRANSACAO", cbmTransacao.SelectedItem);
                comando.Parameters.AddWithValue("@STATUSTRANSACAO", cbmStatus.SelectedItem);

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
                strSQL = "UPDATE TB_TRANSACAO SET PRODUTO = @PRODUTO, QUANTIDADE = @QUANTIDADE, VALOR = @VALOR, TIPO = @TIPO, TRANSACAO = @TRANSACAO, STATUSTRANSACAO = @STATUSTRANSACAO, DATATRANSACAO = GETDATE() WHERE ID = @ID";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", id_produto.Text);
                comando.Parameters.AddWithValue("@PRODUTO", txtProduto.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                comando.Parameters.AddWithValue("@VALOR", txtValor.Text);   
                comando.Parameters.AddWithValue("@TIPO", txtTipo.Text);
                comando.Parameters.AddWithValue("@TRANSACAO", txtTransacao.Text);
                comando.Parameters.AddWithValue("@STATUSTRANSACAO",txtStatus.Text);

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
            {
                try
                {
                    conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                    strSQL = "DELETE TB_TRANSACAO WHERE ID = @ID";
                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@ID", id_produto.Text);

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


        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "SELECT * FROM TB_TRANSACAO";
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();
                da.Fill(ds);
                DgTabelaProdutos.DataSource = ds.Tables[0];

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
                strSQL = "SELECT * FROM TB_TRANSACAO WHERE ID= @ID";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", id_produto.Text);

                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtProduto.Text = (string)dr["Produto"];
                    txtQuantidade.Text = (string)dr["Quantidade"].ToString();
                    txtValor.Text = (string)dr["Valor"].ToString();
                    Double buffer = Convert.ToDouble(txtValor.Text);
                    txtTipo.Text = (string)dr["Tipo"];
                    txtTransacao.Text = (string)dr["Transacao"];
                    txtStatus.Text = (string)dr["statustransacao"];
                   
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
    }

}
    

   
        
   