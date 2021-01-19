using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MasterBlockTela
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {       
            InitializeComponent();
            
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        #region Funcionalidades do formulario
        
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelConteudo.Region = region;
            this.Invalidate();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Capturar tamanha o posição antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size= new Size(sw,sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<clientes>();
            
        }

        private void btnMovintacao_Click(object sender, EventArgs e)
        {
            AbrirFormulario<movimentacoes>();
            
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<produtos>();
            
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<funcionarios>();
            
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion
        //Metodo para abrir Formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca os formularios
            //se o formulario/instancia não existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //se o formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        //Função para saber qual formulario esta ativo
       /* private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Inicio"] == null)
                btnInicio.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Clientes"] == null)
                btnCliente.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Movimentacoes"] == null)
                btnMovintacao.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Produtos"] == null)
                btnProduto.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Funcionarios"] == null)
                btnFuncionario.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Configuracoes"] == null)
                btnConfiguracao.BackColor = Color.FromArgb(4, 41, 68);
        }*/
    }
}