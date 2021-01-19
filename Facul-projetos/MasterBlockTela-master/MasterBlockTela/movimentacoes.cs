using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace MasterBlockTela
{

    public partial class movimentacoes : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataReader dr;
        SqlDataAdapter da;
                
        string strSQL;

        public movimentacoes()
        {
            InitializeComponent();
        }

        private void movimentacoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdMasterBlockDataSet1.TB_TRANSACAO'. Você pode movê-la ou removê-la conforme necessário.
            
            // TODO: esta linha de código carrega dados na tabela 'bdMasterBlockDataSet1.TB_TRANSACAO'. Você pode movê-la ou removê-la conforme necessário.
            
            // TODO: esta linha de código carrega dados na tabela 'bdMasterBlockDataSet.TB_TRANSACAO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_TRANSACAOTableAdapter.Fill(this.bdMasterBlockDataSet.TB_TRANSACAO);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {

                SqlDataAdapter da;
                try
                {

                    conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                    strSQL = "SELECT ID, format(DATATRANSACAO,'dd/MM/yyyy') as DATATRANSACAO FROM TB_TRANSACAO WHERE CAST(DATATRANSACAO as date) between cast( dateadd (day,-1,getdate()) as date) and cast (getdate() as date) ORDER BY DATATRANSACAO desc  ";
                    DataSet ds = new DataSet();
                    da = new SqlDataAdapter(strSQL, conexao);

                    conexao.Open();
                    da.Fill(ds);
                    dgvMovimentacao.DataSource = ds.Tables[0];

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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (dgvMovimentacao.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvMovimentacao.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvMovimentacao.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvMovimentacao.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvMovimentacao.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvMovimentacao.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

                SqlDataAdapter da;
            try
            {

                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "SELECT * FROM TB_TRANSACAO";
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();
                da.Fill(ds);
                dgvMovimentacao.DataSource = ds.Tables[0];

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

        private void tBTRANSACAOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {

                SqlDataAdapter da;
                try
                {

                    conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                    strSQL = "SELECT DISTINCT PRODUTO, COUNT(DISTINCT QUANTIDADE) AS Total FROM TB_TRANSACAO GROUP BY PRODUTO";
                    DataSet ds = new DataSet();
                    da = new SqlDataAdapter(strSQL, conexao);

                    conexao.Open();
                    da.Fill(ds);
                    dgvMovimentacao.DataSource = ds.Tables[0];

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
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection("Server = DESKTOP-QNEEH16\\SQLEXPRESS; Database = bdMasterBlock; Trusted_Connection = True;");
                strSQL = "SELECT ID, format(DATATRANSACAO,'dd/MM/yyyy') as DATATRANSACAO FROM TB_TRANSACAO WHERE CAST(DATATRANSACAO as date) between cast( dateadd (day,-7,getdate()) as date) and cast (getdate() as date) ORDER BY DATATRANSACAO desc  ";
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();
                da.Fill(ds);
                dgvMovimentacao.DataSource = ds.Tables[0];

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
    }
}
    

