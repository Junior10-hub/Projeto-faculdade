namespace MasterBlockTela
{
    partial class movimentacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movimentacoes));
            this.btnCripto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvMovimentacao = new System.Windows.Forms.DataGridView();
            this.BtnExport = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tBTRANSACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdMasterBlockDataSet = new MasterBlockTela.bdMasterBlockDataSet();
            this.tBTRANSACAO1TableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdMasterBlockDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBTRANSACAOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tBTRANSACAOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tB_TRANSACAOTableAdapter = new MasterBlockTela.bdMasterBlockDataSetTableAdapters.TB_TRANSACAOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTRANSACAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMasterBlockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTRANSACAO1TableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMasterBlockDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTRANSACAOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTRANSACAOBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCripto
            // 
            this.btnCripto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCripto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCripto.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCripto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCripto.Location = new System.Drawing.Point(16, 49);
            this.btnCripto.Margin = new System.Windows.Forms.Padding(2);
            this.btnCripto.Name = "btnCripto";
            this.btnCripto.Size = new System.Drawing.Size(97, 44);
            this.btnCripto.TabIndex = 6;
            this.btnCripto.Text = "Criptomoedas mais vendidas";
            this.btnCripto.UseVisualStyleBackColor = false;
            this.btnCripto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(231, 49);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Vendas Diarias";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(16, 100);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Venda Semanal";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Consulta";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(231, 100);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 44);
            this.button4.TabIndex = 10;
            this.button4.Text = "Venda Mensal";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvMovimentacao
            // 
            this.dgvMovimentacao.AllowUserToAddRows = false;
            this.dgvMovimentacao.AllowUserToDeleteRows = false;
            this.dgvMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMovimentacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimentacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimentacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimentacao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovimentacao.Enabled = false;
            this.dgvMovimentacao.EnableHeadersVisualStyles = false;
            this.dgvMovimentacao.Location = new System.Drawing.Point(435, 11);
            this.dgvMovimentacao.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMovimentacao.Name = "dgvMovimentacao";
            this.dgvMovimentacao.ReadOnly = true;
            this.dgvMovimentacao.RowHeadersWidth = 51;
            this.dgvMovimentacao.RowTemplate.Height = 24;
            this.dgvMovimentacao.Size = new System.Drawing.Size(684, 569);
            this.dgvMovimentacao.TabIndex = 11;
            // 
            // BtnExport
            // 
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnExport.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(16, 149);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(312, 54);
            this.BtnExport.TabIndex = 12;
            this.BtnExport.Text = "Exportar Dados";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.button5_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.tBTRANSACAOBindingSource;
            this.chart1.Location = new System.Drawing.Point(16, 236);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.SystemColors.Highlight,
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.DarkBlue};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            series1.XValueMember = "PRODUTO";
            series1.YValueMembers = "Expr1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(383, 344);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Moedas mais vendidas";
            this.chart1.Titles.Add(title1);
            // 
            // tBTRANSACAOBindingSource
            // 
            this.tBTRANSACAOBindingSource.DataMember = "TB_TRANSACAO";
            this.tBTRANSACAOBindingSource.DataSource = this.bdMasterBlockDataSet;
            this.tBTRANSACAOBindingSource.CurrentChanged += new System.EventHandler(this.tBTRANSACAOBindingSource_CurrentChanged);
            // 
            // bdMasterBlockDataSet
            // 
            this.bdMasterBlockDataSet.DataSetName = "bdMasterBlockDataSet";
            this.bdMasterBlockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBTRANSACAOBindingSource2
            // 
            this.tBTRANSACAOBindingSource2.DataSource = this.bdMasterBlockDataSet1BindingSource;
            // 
            // tBTRANSACAOBindingSource3
            // 
            this.tBTRANSACAOBindingSource3.DataSource = this.bdMasterBlockDataSet1BindingSource;
            // 
            // tB_TRANSACAOTableAdapter
            // 
            this.tB_TRANSACAOTableAdapter.ClearBeforeFill = true;
            // 
            // movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1149, 609);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.dgvMovimentacao);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCripto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "movimentacoes";
            this.Text = "movimentacoes";
            this.Load += new System.EventHandler(this.movimentacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTRANSACAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMasterBlockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTRANSACAO1TableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMasterBlockDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTRANSACAOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTRANSACAOBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCripto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvMovimentacao;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private bdMasterBlockDataSet bdMasterBlockDataSet;
        private System.Windows.Forms.BindingSource tBTRANSACAOBindingSource;
        private bdMasterBlockDataSetTableAdapters.TB_TRANSACAOTableAdapter tB_TRANSACAOTableAdapter;
        private System.Windows.Forms.BindingSource tBTRANSACAO1TableAdapterBindingSource;
        private System.Windows.Forms.BindingSource bdMasterBlockDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tBTRANSACAOBindingSource2;
        private System.Windows.Forms.BindingSource tBTRANSACAOBindingSource3;
    }
}