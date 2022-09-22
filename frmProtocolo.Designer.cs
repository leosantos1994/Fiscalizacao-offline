
namespace Fiscalizacao
{
    partial class frmProtocolo
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTipoInscricao = new System.Windows.Forms.Label();
            this.lblProcessoInscricao = new System.Windows.Forms.Label();
            this.lblProtocoloEletronico = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblProtocolo = new System.Windows.Forms.Label();
            this.lblRemetente = new System.Windows.Forms.Label();
            this.lblNumeroInscricao = new System.Windows.Forms.Label();
            this.DataCadastro = new System.Windows.Forms.TextBox();
            this.RegistroConselho = new System.Windows.Forms.TextBox();
            this.Protocolo = new System.Windows.Forms.TextBox();
            this.TipoPedido = new System.Windows.Forms.TextBox();
            this.NumeroProcesso = new System.Windows.Forms.TextBox();
            this.txtTipoInscricao = new System.Windows.Forms.TextBox();
            this.SolicitacaoServico = new System.Windows.Forms.TextBox();
            this.TipoAssunto = new System.Windows.Forms.TextBox();
            this.Remetente = new System.Windows.Forms.TextBox();
            this.DataProtocolo = new System.Windows.Forms.DateTimePicker();
            this.lblObservação = new System.Windows.Forms.Label();
            this.lblTramites = new System.Windows.Forms.Label();
            this.lblDepartamentoOrigem = new System.Windows.Forms.Label();
            this.lblDepartamentoDestino = new System.Windows.Forms.Label();
            this.Observacao = new System.Windows.Forms.TextBox();
            this.DepartamentoDestino = new System.Windows.Forms.TextBox();
            this.DepartamentoOrigem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(12, 526);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTipoInscricao
            // 
            this.lblTipoInscricao.AutoSize = true;
            this.lblTipoInscricao.Location = new System.Drawing.Point(6, 129);
            this.lblTipoInscricao.Name = "lblTipoInscricao";
            this.lblTipoInscricao.Size = new System.Drawing.Size(74, 13);
            this.lblTipoInscricao.TabIndex = 24;
            this.lblTipoInscricao.Text = "Tipo Inscrição";
            // 
            // lblProcessoInscricao
            // 
            this.lblProcessoInscricao.AutoSize = true;
            this.lblProcessoInscricao.Location = new System.Drawing.Point(6, 51);
            this.lblProcessoInscricao.Name = "lblProcessoInscricao";
            this.lblProcessoInscricao.Size = new System.Drawing.Size(97, 13);
            this.lblProcessoInscricao.TabIndex = 23;
            this.lblProcessoInscricao.Text = "Processo Inscrição";
            // 
            // lblProtocoloEletronico
            // 
            this.lblProtocoloEletronico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProtocoloEletronico.AutoSize = true;
            this.lblProtocoloEletronico.Location = new System.Drawing.Point(540, 129);
            this.lblProtocoloEletronico.Name = "lblProtocoloEletronico";
            this.lblProtocoloEletronico.Size = new System.Drawing.Size(102, 13);
            this.lblProtocoloEletronico.TabIndex = 22;
            this.lblProtocoloEletronico.Text = "Protocolo Eletrônico";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(9, 367);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(45, 13);
            this.lblAssunto.TabIndex = 21;
            this.lblAssunto.Text = "Assunto";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(6, 168);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(49, 13);
            this.lblCadastro.TabIndex = 18;
            this.lblCadastro.Text = "Cadastro";
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Location = new System.Drawing.Point(540, 168);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(79, 13);
            this.lblTipoPedido.TabIndex = 17;
            this.lblTipoPedido.Text = "Tipo de Pedido";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(623, 90);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data";
            // 
            // lblProtocolo
            // 
            this.lblProtocolo.AutoSize = true;
            this.lblProtocolo.Location = new System.Drawing.Point(6, 90);
            this.lblProtocolo.Name = "lblProtocolo";
            this.lblProtocolo.Size = new System.Drawing.Size(52, 13);
            this.lblProtocolo.TabIndex = 15;
            this.lblProtocolo.Text = "Protocolo";
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Location = new System.Drawing.Point(6, 207);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(59, 13);
            this.lblRemetente.TabIndex = 14;
            this.lblRemetente.Text = "Remetente";
            this.lblRemetente.Click += new System.EventHandler(this.lblRemetente_Click);
            // 
            // lblNumeroInscricao
            // 
            this.lblNumeroInscricao.AutoSize = true;
            this.lblNumeroInscricao.Location = new System.Drawing.Point(6, 12);
            this.lblNumeroInscricao.Name = "lblNumeroInscricao";
            this.lblNumeroInscricao.Size = new System.Drawing.Size(80, 13);
            this.lblNumeroInscricao.TabIndex = 13;
            this.lblNumeroInscricao.Text = "N° da Inscrição";
            // 
            // DataCadastro
            // 
            this.DataCadastro.Location = new System.Drawing.Point(9, 184);
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Size = new System.Drawing.Size(495, 20);
            this.DataCadastro.TabIndex = 25;
            // 
            // RegistroConselho
            // 
            this.RegistroConselho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistroConselho.Location = new System.Drawing.Point(9, 28);
            this.RegistroConselho.Name = "RegistroConselho";
            this.RegistroConselho.Size = new System.Drawing.Size(863, 20);
            this.RegistroConselho.TabIndex = 26;
            // 
            // Protocolo
            // 
            this.Protocolo.Location = new System.Drawing.Point(9, 106);
            this.Protocolo.Name = "Protocolo";
            this.Protocolo.Size = new System.Drawing.Size(579, 20);
            this.Protocolo.TabIndex = 27;
            // 
            // TipoPedido
            // 
            this.TipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoPedido.Location = new System.Drawing.Point(543, 184);
            this.TipoPedido.Name = "TipoPedido";
            this.TipoPedido.Size = new System.Drawing.Size(329, 20);
            this.TipoPedido.TabIndex = 29;
            // 
            // NumeroProcesso
            // 
            this.NumeroProcesso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumeroProcesso.Location = new System.Drawing.Point(9, 67);
            this.NumeroProcesso.Name = "NumeroProcesso";
            this.NumeroProcesso.Size = new System.Drawing.Size(863, 20);
            this.NumeroProcesso.TabIndex = 30;
            // 
            // txtTipoInscricao
            // 
            this.txtTipoInscricao.Location = new System.Drawing.Point(9, 145);
            this.txtTipoInscricao.Name = "txtTipoInscricao";
            this.txtTipoInscricao.Size = new System.Drawing.Size(495, 20);
            this.txtTipoInscricao.TabIndex = 31;
            // 
            // SolicitacaoServico
            // 
            this.SolicitacaoServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SolicitacaoServico.Location = new System.Drawing.Point(543, 145);
            this.SolicitacaoServico.Name = "SolicitacaoServico";
            this.SolicitacaoServico.Size = new System.Drawing.Size(329, 20);
            this.SolicitacaoServico.TabIndex = 32;
            // 
            // TipoAssunto
            // 
            this.TipoAssunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoAssunto.Location = new System.Drawing.Point(12, 383);
            this.TipoAssunto.Name = "TipoAssunto";
            this.TipoAssunto.Size = new System.Drawing.Size(860, 20);
            this.TipoAssunto.TabIndex = 33;
            // 
            // Remetente
            // 
            this.Remetente.Location = new System.Drawing.Point(9, 227);
            this.Remetente.Name = "Remetente";
            this.Remetente.Size = new System.Drawing.Size(403, 20);
            this.Remetente.TabIndex = 34;
            // 
            // DataProtocolo
            // 
            this.DataProtocolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProtocolo.Location = new System.Drawing.Point(613, 106);
            this.DataProtocolo.Name = "DataProtocolo";
            this.DataProtocolo.Size = new System.Drawing.Size(259, 20);
            this.DataProtocolo.TabIndex = 38;
            // 
            // lblObservação
            // 
            this.lblObservação.AutoSize = true;
            this.lblObservação.Location = new System.Drawing.Point(9, 407);
            this.lblObservação.Name = "lblObservação";
            this.lblObservação.Size = new System.Drawing.Size(65, 13);
            this.lblObservação.TabIndex = 39;
            this.lblObservação.Text = "Observação";
            // 
            // lblTramites
            // 
            this.lblTramites.AutoSize = true;
            this.lblTramites.Location = new System.Drawing.Point(6, 250);
            this.lblTramites.Name = "lblTramites";
            this.lblTramites.Size = new System.Drawing.Size(47, 13);
            this.lblTramites.TabIndex = 40;
            this.lblTramites.Text = "Trâmites";
            // 
            // lblDepartamentoOrigem
            // 
            this.lblDepartamentoOrigem.AutoSize = true;
            this.lblDepartamentoOrigem.Location = new System.Drawing.Point(3, 5);
            this.lblDepartamentoOrigem.Name = "lblDepartamentoOrigem";
            this.lblDepartamentoOrigem.Size = new System.Drawing.Size(125, 13);
            this.lblDepartamentoOrigem.TabIndex = 41;
            this.lblDepartamentoOrigem.Text = "Departamento de Origem";
            this.lblDepartamentoOrigem.Click += new System.EventHandler(this.lblOrigem_Click);
            // 
            // lblDepartamentoDestino
            // 
            this.lblDepartamentoDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartamentoDestino.AutoSize = true;
            this.lblDepartamentoDestino.Location = new System.Drawing.Point(3, 44);
            this.lblDepartamentoDestino.Name = "lblDepartamentoDestino";
            this.lblDepartamentoDestino.Size = new System.Drawing.Size(128, 13);
            this.lblDepartamentoDestino.TabIndex = 43;
            this.lblDepartamentoDestino.Text = "Departamento de Destino";
            // 
            // Observacao
            // 
            this.Observacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Observacao.Location = new System.Drawing.Point(12, 423);
            this.Observacao.Multiline = true;
            this.Observacao.Name = "Observacao";
            this.Observacao.Size = new System.Drawing.Size(860, 86);
            this.Observacao.TabIndex = 45;
            // 
            // DepartamentoDestino
            // 
            this.DepartamentoDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartamentoDestino.Location = new System.Drawing.Point(3, 60);
            this.DepartamentoDestino.Name = "DepartamentoDestino";
            this.DepartamentoDestino.Size = new System.Drawing.Size(846, 20);
            this.DepartamentoDestino.TabIndex = 47;
            // 
            // DepartamentoOrigem
            // 
            this.DepartamentoOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartamentoOrigem.Location = new System.Drawing.Point(3, 21);
            this.DepartamentoOrigem.Name = "DepartamentoOrigem";
            this.DepartamentoOrigem.Size = new System.Drawing.Size(846, 20);
            this.DepartamentoOrigem.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DepartamentoDestino);
            this.panel1.Controls.Add(this.DepartamentoOrigem);
            this.panel1.Controls.Add(this.lblDepartamentoOrigem);
            this.panel1.Controls.Add(this.lblDepartamentoDestino);
            this.panel1.Location = new System.Drawing.Point(9, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 87);
            this.panel1.TabIndex = 50;
            // 
            // frmProtocolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Observacao);
            this.Controls.Add(this.lblTramites);
            this.Controls.Add(this.lblObservação);
            this.Controls.Add(this.DataProtocolo);
            this.Controls.Add(this.Remetente);
            this.Controls.Add(this.TipoAssunto);
            this.Controls.Add(this.SolicitacaoServico);
            this.Controls.Add(this.txtTipoInscricao);
            this.Controls.Add(this.NumeroProcesso);
            this.Controls.Add(this.TipoPedido);
            this.Controls.Add(this.Protocolo);
            this.Controls.Add(this.RegistroConselho);
            this.Controls.Add(this.DataCadastro);
            this.Controls.Add(this.lblTipoInscricao);
            this.Controls.Add(this.lblProcessoInscricao);
            this.Controls.Add(this.lblProtocoloEletronico);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.lblTipoPedido);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblProtocolo);
            this.Controls.Add(this.lblRemetente);
            this.Controls.Add(this.lblNumeroInscricao);
            this.Controls.Add(this.btnFechar);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmProtocolo";
            this.Text = "frmProtocolo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProtocolo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTipoInscricao;
        private System.Windows.Forms.Label lblProcessoInscricao;
        private System.Windows.Forms.Label lblProtocoloEletronico;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblProtocolo;
        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.Label lblNumeroInscricao;
        private System.Windows.Forms.TextBox DataCadastro;
        private System.Windows.Forms.TextBox RegistroConselho;
        private System.Windows.Forms.TextBox Protocolo;
        private System.Windows.Forms.TextBox TipoPedido;
        private System.Windows.Forms.TextBox NumeroProcesso;
        private System.Windows.Forms.TextBox txtTipoInscricao;
        private System.Windows.Forms.TextBox SolicitacaoServico;
        private System.Windows.Forms.TextBox TipoAssunto;
        private System.Windows.Forms.TextBox Remetente;
        private System.Windows.Forms.DateTimePicker DataProtocolo;
        private System.Windows.Forms.Label lblObservação;
        private System.Windows.Forms.Label lblTramites;
        private System.Windows.Forms.Label lblDepartamentoOrigem;
        private System.Windows.Forms.Label lblDepartamentoDestino;
        private System.Windows.Forms.TextBox Observacao;
        private System.Windows.Forms.TextBox DepartamentoDestino;
        private System.Windows.Forms.TextBox DepartamentoOrigem;
        private System.Windows.Forms.Panel panel1;
    }
}