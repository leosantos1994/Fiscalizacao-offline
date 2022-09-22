
namespace Fiscalizacao
{
    partial class frmInfracoes
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
            this.lblProcesso = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblMotivoSituacao = new System.Windows.Forms.Label();
            this.lblTipoProcesso = new System.Windows.Forms.Label();
            this.lblAutuado = new System.Windows.Forms.Label();
            this.lblPessoaJuridica = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblFiscal = new System.Windows.Forms.Label();
            this.SituacaoProcessoFIS = new System.Windows.Forms.TextBox();
            this.ProcessoFIS = new System.Windows.Forms.TextBox();
            this.Ano = new System.Windows.Forms.TextBox();
            this.MotivoSituacaoProcessoFIS = new System.Windows.Forms.TextBox();
            this.TipoProcessoFIS = new System.Windows.Forms.TextBox();
            this.FiscalProcessoFIS = new System.Windows.Forms.TextBox();
            this.PessoaJuridicaProcessoFIS = new System.Windows.Forms.TextBox();
            this.RepresentadoFIS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(9, 698);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Location = new System.Drawing.Point(12, 9);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(51, 13);
            this.lblProcesso.TabIndex = 3;
            this.lblProcesso.Text = "Processo";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(12, 48);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano";
            // 
            // lblMotivoSituacao
            // 
            this.lblMotivoSituacao.AutoSize = true;
            this.lblMotivoSituacao.Location = new System.Drawing.Point(12, 88);
            this.lblMotivoSituacao.Name = "lblMotivoSituacao";
            this.lblMotivoSituacao.Size = new System.Drawing.Size(84, 13);
            this.lblMotivoSituacao.TabIndex = 5;
            this.lblMotivoSituacao.Text = "Motivo Situação";
            // 
            // lblTipoProcesso
            // 
            this.lblTipoProcesso.AutoSize = true;
            this.lblTipoProcesso.Location = new System.Drawing.Point(12, 127);
            this.lblTipoProcesso.Name = "lblTipoProcesso";
            this.lblTipoProcesso.Size = new System.Drawing.Size(75, 13);
            this.lblTipoProcesso.TabIndex = 5;
            this.lblTipoProcesso.Text = "Tipo Processo";
            // 
            // lblAutuado
            // 
            this.lblAutuado.AutoSize = true;
            this.lblAutuado.Location = new System.Drawing.Point(623, 88);
            this.lblAutuado.Name = "lblAutuado";
            this.lblAutuado.Size = new System.Drawing.Size(47, 13);
            this.lblAutuado.TabIndex = 6;
            this.lblAutuado.Text = "Autuado";
            // 
            // lblPessoaJuridica
            // 
            this.lblPessoaJuridica.AutoSize = true;
            this.lblPessoaJuridica.Location = new System.Drawing.Point(623, 127);
            this.lblPessoaJuridica.Name = "lblPessoaJuridica";
            this.lblPessoaJuridica.Size = new System.Drawing.Size(83, 13);
            this.lblPessoaJuridica.TabIndex = 6;
            this.lblPessoaJuridica.Text = "Pessoa Jurídica";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(623, 49);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 6;
            this.lblSituacao.Text = "Situação";
            // 
            // lblFiscal
            // 
            this.lblFiscal.AutoSize = true;
            this.lblFiscal.Location = new System.Drawing.Point(623, 9);
            this.lblFiscal.Name = "lblFiscal";
            this.lblFiscal.Size = new System.Drawing.Size(34, 13);
            this.lblFiscal.TabIndex = 6;
            this.lblFiscal.Text = "Fiscal";
            // 
            // SituacaoProcessoFIS
            // 
            this.SituacaoProcessoFIS.Location = new System.Drawing.Point(626, 65);
            this.SituacaoProcessoFIS.Name = "SituacaoProcessoFIS";
            this.SituacaoProcessoFIS.Size = new System.Drawing.Size(378, 20);
            this.SituacaoProcessoFIS.TabIndex = 7;
            // 
            // ProcessoFIS
            // 
            this.ProcessoFIS.Location = new System.Drawing.Point(15, 25);
            this.ProcessoFIS.Name = "ProcessoFIS";
            this.ProcessoFIS.Size = new System.Drawing.Size(587, 20);
            this.ProcessoFIS.TabIndex = 8;
            this.ProcessoFIS.TextChanged += new System.EventHandler(this.txtInfracoesProcesso_TextChanged);
            // 
            // Ano
            // 
            this.Ano.Location = new System.Drawing.Point(15, 65);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(587, 20);
            this.Ano.TabIndex = 9;
            // 
            // MotivoSituacaoProcessoFIS
            // 
            this.MotivoSituacaoProcessoFIS.Location = new System.Drawing.Point(15, 104);
            this.MotivoSituacaoProcessoFIS.Name = "MotivoSituacaoProcessoFIS";
            this.MotivoSituacaoProcessoFIS.Size = new System.Drawing.Size(587, 20);
            this.MotivoSituacaoProcessoFIS.TabIndex = 9;
            // 
            // TipoProcessoFIS
            // 
            this.TipoProcessoFIS.Location = new System.Drawing.Point(15, 143);
            this.TipoProcessoFIS.Name = "TipoProcessoFIS";
            this.TipoProcessoFIS.Size = new System.Drawing.Size(587, 20);
            this.TipoProcessoFIS.TabIndex = 10;
            // 
            // FiscalProcessoFIS
            // 
            this.FiscalProcessoFIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FiscalProcessoFIS.Location = new System.Drawing.Point(626, 25);
            this.FiscalProcessoFIS.Name = "FiscalProcessoFIS";
            this.FiscalProcessoFIS.Size = new System.Drawing.Size(378, 20);
            this.FiscalProcessoFIS.TabIndex = 11;
            // 
            // PessoaJuridicaProcessoFIS
            // 
            this.PessoaJuridicaProcessoFIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PessoaJuridicaProcessoFIS.Location = new System.Drawing.Point(626, 143);
            this.PessoaJuridicaProcessoFIS.Name = "PessoaJuridicaProcessoFIS";
            this.PessoaJuridicaProcessoFIS.Size = new System.Drawing.Size(378, 20);
            this.PessoaJuridicaProcessoFIS.TabIndex = 12;
            // 
            // RepresentadoFIS
            // 
            this.RepresentadoFIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RepresentadoFIS.Location = new System.Drawing.Point(626, 104);
            this.RepresentadoFIS.Name = "RepresentadoFIS";
            this.RepresentadoFIS.Size = new System.Drawing.Size(378, 20);
            this.RepresentadoFIS.TabIndex = 13;
            this.RepresentadoFIS.TextChanged += new System.EventHandler(this.txtInfracoesAutuado_TextChanged);
            // 
            // frmInfracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 578);
            this.Controls.Add(this.RepresentadoFIS);
            this.Controls.Add(this.PessoaJuridicaProcessoFIS);
            this.Controls.Add(this.FiscalProcessoFIS);
            this.Controls.Add(this.TipoProcessoFIS);
            this.Controls.Add(this.MotivoSituacaoProcessoFIS);
            this.Controls.Add(this.Ano);
            this.Controls.Add(this.ProcessoFIS);
            this.Controls.Add(this.SituacaoProcessoFIS);
            this.Controls.Add(this.lblFiscal);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblPessoaJuridica);
            this.Controls.Add(this.lblAutuado);
            this.Controls.Add(this.lblTipoProcesso);
            this.Controls.Add(this.lblMotivoSituacao);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblProcesso);
            this.Controls.Add(this.btnFechar);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmInfracoes";
            this.Text = "Infrações";
            this.Load += new System.EventHandler(this.frmInfracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblProcesso;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblMotivoSituacao;
        private System.Windows.Forms.Label lblTipoProcesso;
        private System.Windows.Forms.Label lblAutuado;
        private System.Windows.Forms.Label lblPessoaJuridica;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblFiscal;
        private System.Windows.Forms.TextBox SituacaoProcessoFIS;
        private System.Windows.Forms.TextBox ProcessoFIS;
        private System.Windows.Forms.TextBox Ano;
        private System.Windows.Forms.TextBox MotivoSituacaoProcessoFIS;
        private System.Windows.Forms.TextBox TipoProcessoFIS;
        private System.Windows.Forms.TextBox FiscalProcessoFIS;
        private System.Windows.Forms.TextBox PessoaJuridicaProcessoFIS;
        private System.Windows.Forms.TextBox RepresentadoFIS;
    }
}