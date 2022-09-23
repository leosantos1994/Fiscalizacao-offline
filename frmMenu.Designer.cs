
namespace Fiscalizacao
{
    partial class frmMenu
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
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPesquisaCPF = new System.Windows.Forms.TextBox();
            this.txtPesquisaRegistro = new System.Windows.Forms.TextBox();
            this.txtPesquisaCidade = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistroConselho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPFCNPJ,
            this.RegistroConselho,
            this.Cidade});
            this.dgvPrincipal.Location = new System.Drawing.Point(12, 89);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(860, 460);
            this.dgvPrincipal.TabIndex = 5;
            this.dgvPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrincipal_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inscritos";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(736, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sincronizar Cadastros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(59, 58);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(200, 20);
            this.txtPesquisaNome.TabIndex = 8;
            this.txtPesquisaNome.TextChanged += new System.EventHandler(this.txtPesquisaNome_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPesquisaCPF
            // 
            this.txtPesquisaCPF.Location = new System.Drawing.Point(265, 58);
            this.txtPesquisaCPF.Name = "txtPesquisaCPF";
            this.txtPesquisaCPF.Size = new System.Drawing.Size(200, 20);
            this.txtPesquisaCPF.TabIndex = 10;
            this.txtPesquisaCPF.TextChanged += new System.EventHandler(this.txtPesquisaCPF_TextChanged);
            // 
            // txtPesquisaRegistro
            // 
            this.txtPesquisaRegistro.Location = new System.Drawing.Point(471, 58);
            this.txtPesquisaRegistro.Name = "txtPesquisaRegistro";
            this.txtPesquisaRegistro.Size = new System.Drawing.Size(200, 20);
            this.txtPesquisaRegistro.TabIndex = 11;
            this.txtPesquisaRegistro.TextChanged += new System.EventHandler(this.txtPesquisaRegistro_TextChanged);
            // 
            // txtPesquisaCidade
            // 
            this.txtPesquisaCidade.Location = new System.Drawing.Point(677, 58);
            this.txtPesquisaCidade.Name = "txtPesquisaCidade";
            this.txtPesquisaCidade.Size = new System.Drawing.Size(189, 20);
            this.txtPesquisaCidade.TabIndex = 12;
            this.txtPesquisaCidade.TextChanged += new System.EventHandler(this.txtPesquisaCidade_TextChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPFCNPJ.HeaderText = "CPF/CNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            // 
            // RegistroConselho
            // 
            this.RegistroConselho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegistroConselho.HeaderText = "Nº Registro";
            this.RegistroConselho.Name = "RegistroConselho";
            this.RegistroConselho.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtPesquisaCidade);
            this.Controls.Add(this.txtPesquisaRegistro);
            this.Controls.Add(this.txtPesquisaCPF);
            this.Controls.Add(this.txtPesquisaNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrincipal);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPesquisaCPF;
        private System.Windows.Forms.TextBox txtPesquisaRegistro;
        private System.Windows.Forms.TextBox txtPesquisaCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroConselho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
    }
}

