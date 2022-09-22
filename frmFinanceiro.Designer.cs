
namespace Fiscalizacao
{
    partial class frmFinanceiro
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
            this.DataExecucao = new System.Windows.Forms.TextBox();
            this.Requerimento = new System.Windows.Forms.TextBox();
            this.ProtocoloDocumento = new System.Windows.Forms.TextBox();
            this.lblDataExecucao = new System.Windows.Forms.Label();
            this.lblNumeroProtocolo = new System.Windows.Forms.Label();
            this.lblRequerimento = new System.Windows.Forms.Label();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.lblValorLiquido = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTipoLancamento = new System.Windows.Forms.Label();
            this.lblValorAReceber = new System.Windows.Forms.Label();
            this.lblProcesso = new System.Windows.Forms.Label();
            this.lblValorReajustado = new System.Windows.Forms.Label();
            this.lblDividaAtiva = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblValorBruto = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.DataMovimento = new System.Windows.Forms.TextBox();
            this.Ano = new System.Windows.Forms.TextBox();
            this.Parcela = new System.Windows.Forms.TextBox();
            this.ValorBruto = new System.Windows.Forms.TextBox();
            this.ValorSaldo = new System.Windows.Forms.TextBox();
            this.DividaAtiva = new System.Windows.Forms.TextBox();
            this.Reajustado = new System.Windows.Forms.TextBox();
            this.Processo = new System.Windows.Forms.TextBox();
            this.ValorLiquido = new System.Windows.Forms.TextBox();
            this.TipoLancamento = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.DataOperacao = new System.Windows.Forms.TextBox();
            this.Pessoa = new System.Windows.Forms.TextBox();
            this.lblSacado = new System.Windows.Forms.Label();
            this.Situacao = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.ComplementoSituacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(9, 573);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // DataExecucao
            // 
            this.DataExecucao.Location = new System.Drawing.Point(6, 263);
            this.DataExecucao.Name = "DataExecucao";
            this.DataExecucao.Size = new System.Drawing.Size(405, 20);
            this.DataExecucao.TabIndex = 74;
            // 
            // Requerimento
            // 
            this.Requerimento.Location = new System.Drawing.Point(8, 216);
            this.Requerimento.Name = "Requerimento";
            this.Requerimento.Size = new System.Drawing.Size(407, 20);
            this.Requerimento.TabIndex = 73;
            // 
            // ProtocoloDocumento
            // 
            this.ProtocoloDocumento.Location = new System.Drawing.Point(8, 177);
            this.ProtocoloDocumento.Name = "ProtocoloDocumento";
            this.ProtocoloDocumento.Size = new System.Drawing.Size(405, 20);
            this.ProtocoloDocumento.TabIndex = 72;
            // 
            // lblDataExecucao
            // 
            this.lblDataExecucao.AutoSize = true;
            this.lblDataExecucao.Location = new System.Drawing.Point(3, 247);
            this.lblDataExecucao.Name = "lblDataExecucao";
            this.lblDataExecucao.Size = new System.Drawing.Size(96, 13);
            this.lblDataExecucao.TabIndex = 71;
            this.lblDataExecucao.Text = "Data de Execução";
            // 
            // lblNumeroProtocolo
            // 
            this.lblNumeroProtocolo.AutoSize = true;
            this.lblNumeroProtocolo.Location = new System.Drawing.Point(5, 161);
            this.lblNumeroProtocolo.Name = "lblNumeroProtocolo";
            this.lblNumeroProtocolo.Size = new System.Drawing.Size(82, 13);
            this.lblNumeroProtocolo.TabIndex = 70;
            this.lblNumeroProtocolo.Text = "N° de Protocolo";
            // 
            // lblRequerimento
            // 
            this.lblRequerimento.AutoSize = true;
            this.lblRequerimento.Location = new System.Drawing.Point(5, 200);
            this.lblRequerimento.Name = "lblRequerimento";
            this.lblRequerimento.Size = new System.Drawing.Size(73, 13);
            this.lblRequerimento.TabIndex = 69;
            this.lblRequerimento.Text = "Requerimento";
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Location = new System.Drawing.Point(632, 41);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(46, 13);
            this.lblEmissao.TabIndex = 67;
            this.lblEmissao.Text = "Emissão";
            // 
            // lblValorLiquido
            // 
            this.lblValorLiquido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorLiquido.AutoSize = true;
            this.lblValorLiquido.Location = new System.Drawing.Point(464, 18);
            this.lblValorLiquido.Name = "lblValorLiquido";
            this.lblValorLiquido.Size = new System.Drawing.Size(41, 13);
            this.lblValorLiquido.TabIndex = 66;
            this.lblValorLiquido.Text = "Liquido";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(199, 39);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 65;
            this.lblNumero.Text = "Número";
            // 
            // lblTipoLancamento
            // 
            this.lblTipoLancamento.AutoSize = true;
            this.lblTipoLancamento.Location = new System.Drawing.Point(427, 247);
            this.lblTipoLancamento.Name = "lblTipoLancamento";
            this.lblTipoLancamento.Size = new System.Drawing.Size(90, 13);
            this.lblTipoLancamento.TabIndex = 64;
            this.lblTipoLancamento.Text = "Tipo Lançamento";
            // 
            // lblValorAReceber
            // 
            this.lblValorAReceber.AutoSize = true;
            this.lblValorAReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAReceber.Location = new System.Drawing.Point(21, 441);
            this.lblValorAReceber.Name = "lblValorAReceber";
            this.lblValorAReceber.Size = new System.Drawing.Size(99, 13);
            this.lblValorAReceber.TabIndex = 63;
            this.lblValorAReceber.Text = "Valor a Receber";
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Location = new System.Drawing.Point(425, 161);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(51, 13);
            this.lblProcesso.TabIndex = 62;
            this.lblProcesso.Text = "Processo";
            // 
            // lblValorReajustado
            // 
            this.lblValorReajustado.AutoSize = true;
            this.lblValorReajustado.Location = new System.Drawing.Point(444, 48);
            this.lblValorReajustado.Name = "lblValorReajustado";
            this.lblValorReajustado.Size = new System.Drawing.Size(61, 13);
            this.lblValorReajustado.TabIndex = 61;
            this.lblValorReajustado.Text = "Reajustado";
            // 
            // lblDividaAtiva
            // 
            this.lblDividaAtiva.AutoSize = true;
            this.lblDividaAtiva.Location = new System.Drawing.Point(425, 200);
            this.lblDividaAtiva.Name = "lblDividaAtiva";
            this.lblDividaAtiva.Size = new System.Drawing.Size(64, 13);
            this.lblDividaAtiva.TabIndex = 60;
            this.lblDividaAtiva.Text = "Divida Ativa";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 51);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 59;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblValorBruto
            // 
            this.lblValorBruto.AutoSize = true;
            this.lblValorBruto.Location = new System.Drawing.Point(12, 18);
            this.lblValorBruto.Name = "lblValorBruto";
            this.lblValorBruto.Size = new System.Drawing.Size(32, 13);
            this.lblValorBruto.TabIndex = 58;
            this.lblValorBruto.Text = "Bruto";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(7, 80);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(63, 13);
            this.lblVencimento.TabIndex = 56;
            this.lblVencimento.Text = "Vencimento";
            this.lblVencimento.Click += new System.EventHandler(this.lblVencimento_Click);
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(423, 39);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(43, 13);
            this.lblParcela.TabIndex = 55;
            this.lblParcela.Text = "Parcela";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(5, 39);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 54;
            this.lblAno.Text = "Ano";
            // 
            // DataMovimento
            // 
            this.DataMovimento.Location = new System.Drawing.Point(8, 96);
            this.DataMovimento.Name = "DataMovimento";
            this.DataMovimento.Size = new System.Drawing.Size(405, 20);
            this.DataMovimento.TabIndex = 53;
            // 
            // Ano
            // 
            this.Ano.Location = new System.Drawing.Point(8, 55);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(175, 20);
            this.Ano.TabIndex = 51;
            // 
            // Parcela
            // 
            this.Parcela.Location = new System.Drawing.Point(430, 55);
            this.Parcela.Name = "Parcela";
            this.Parcela.Size = new System.Drawing.Size(196, 20);
            this.Parcela.TabIndex = 50;
            // 
            // ValorBruto
            // 
            this.ValorBruto.Location = new System.Drawing.Point(50, 15);
            this.ValorBruto.Name = "ValorBruto";
            this.ValorBruto.Size = new System.Drawing.Size(377, 20);
            this.ValorBruto.TabIndex = 49;
            // 
            // ValorSaldo
            // 
            this.ValorSaldo.Location = new System.Drawing.Point(50, 48);
            this.ValorSaldo.Name = "ValorSaldo";
            this.ValorSaldo.Size = new System.Drawing.Size(377, 20);
            this.ValorSaldo.TabIndex = 48;
            // 
            // DividaAtiva
            // 
            this.DividaAtiva.Location = new System.Drawing.Point(430, 216);
            this.DividaAtiva.Name = "DividaAtiva";
            this.DividaAtiva.Size = new System.Drawing.Size(424, 20);
            this.DividaAtiva.TabIndex = 47;
            // 
            // Reajustado
            // 
            this.Reajustado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reajustado.Location = new System.Drawing.Point(514, 48);
            this.Reajustado.Name = "Reajustado";
            this.Reajustado.Size = new System.Drawing.Size(340, 20);
            this.Reajustado.TabIndex = 46;
            // 
            // Processo
            // 
            this.Processo.Location = new System.Drawing.Point(430, 177);
            this.Processo.Name = "Processo";
            this.Processo.Size = new System.Drawing.Size(424, 20);
            this.Processo.TabIndex = 45;
            // 
            // ValorLiquido
            // 
            this.ValorLiquido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ValorLiquido.Location = new System.Drawing.Point(514, 18);
            this.ValorLiquido.Name = "ValorLiquido";
            this.ValorLiquido.Size = new System.Drawing.Size(340, 20);
            this.ValorLiquido.TabIndex = 44;
            // 
            // TipoLancamento
            // 
            this.TipoLancamento.Location = new System.Drawing.Point(430, 263);
            this.TipoLancamento.Name = "TipoLancamento";
            this.TipoLancamento.Size = new System.Drawing.Size(424, 20);
            this.TipoLancamento.TabIndex = 43;
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(189, 55);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(224, 20);
            this.Numero.TabIndex = 42;
            // 
            // DataOperacao
            // 
            this.DataOperacao.Location = new System.Drawing.Point(635, 57);
            this.DataOperacao.Name = "DataOperacao";
            this.DataOperacao.Size = new System.Drawing.Size(219, 20);
            this.DataOperacao.TabIndex = 41;
            // 
            // Pessoa
            // 
            this.Pessoa.Location = new System.Drawing.Point(8, 18);
            this.Pessoa.Name = "Pessoa";
            this.Pessoa.Size = new System.Drawing.Size(846, 20);
            this.Pessoa.TabIndex = 39;
            // 
            // lblSacado
            // 
            this.lblSacado.AutoSize = true;
            this.lblSacado.Location = new System.Drawing.Point(5, 2);
            this.lblSacado.Name = "lblSacado";
            this.lblSacado.Size = new System.Drawing.Size(44, 13);
            this.lblSacado.TabIndex = 38;
            this.lblSacado.Text = "Sacado";
            // 
            // Situacao
            // 
            this.Situacao.Location = new System.Drawing.Point(430, 96);
            this.Situacao.Name = "Situacao";
            this.Situacao.Size = new System.Drawing.Size(424, 20);
            this.Situacao.TabIndex = 75;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(427, 80);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 76;
            this.lblSituacao.Text = "Situação";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ValorBruto);
            this.panel1.Controls.Add(this.ValorSaldo);
            this.panel1.Controls.Add(this.lblValorBruto);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.ValorLiquido);
            this.panel1.Controls.Add(this.Reajustado);
            this.panel1.Controls.Add(this.lblValorReajustado);
            this.panel1.Controls.Add(this.lblValorLiquido);
            this.panel1.Location = new System.Drawing.Point(9, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 100);
            this.panel1.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ComplementoSituacao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Complemento);
            this.panel2.Controls.Add(this.lblComplemento);
            this.panel2.Controls.Add(this.TipoLancamento);
            this.panel2.Controls.Add(this.lblTipoLancamento);
            this.panel2.Controls.Add(this.Requerimento);
            this.panel2.Controls.Add(this.lblRequerimento);
            this.panel2.Controls.Add(this.Ano);
            this.panel2.Controls.Add(this.lblSacado);
            this.panel2.Controls.Add(this.lblSituacao);
            this.panel2.Controls.Add(this.Pessoa);
            this.panel2.Controls.Add(this.Situacao);
            this.panel2.Controls.Add(this.Parcela);
            this.panel2.Controls.Add(this.DataExecucao);
            this.panel2.Controls.Add(this.DataMovimento);
            this.panel2.Controls.Add(this.lblAno);
            this.panel2.Controls.Add(this.ProtocoloDocumento);
            this.panel2.Controls.Add(this.lblDataExecucao);
            this.panel2.Controls.Add(this.lblParcela);
            this.panel2.Controls.Add(this.lblNumeroProtocolo);
            this.panel2.Controls.Add(this.lblVencimento);
            this.panel2.Controls.Add(this.DividaAtiva);
            this.panel2.Controls.Add(this.lblEmissao);
            this.panel2.Controls.Add(this.Processo);
            this.panel2.Controls.Add(this.lblNumero);
            this.panel2.Controls.Add(this.lblDividaAtiva);
            this.panel2.Controls.Add(this.lblProcesso);
            this.panel2.Controls.Add(this.Numero);
            this.panel2.Controls.Add(this.DataOperacao);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 426);
            this.panel2.TabIndex = 78;
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(6, 303);
            this.Complemento.Multiline = true;
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(848, 120);
            this.Complemento.TabIndex = 77;
            this.Complemento.TextChanged += new System.EventHandler(this.txtFinanceiroComplemento_TextChanged);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(4, 286);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 78;
            this.lblComplemento.Text = "Complemento";
            this.lblComplemento.Click += new System.EventHandler(this.lblComplemento_Click);
            // 
            // ComplementoSituacao
            // 
            this.ComplementoSituacao.Location = new System.Drawing.Point(8, 136);
            this.ComplementoSituacao.Multiline = true;
            this.ComplementoSituacao.Name = "ComplementoSituacao";
            this.ComplementoSituacao.Size = new System.Drawing.Size(846, 22);
            this.ComplementoSituacao.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Complemento";
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblValorAReceber);
            this.Controls.Add(this.btnFechar);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmFinanceiro";
            this.Text = "frmFinanceiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFinanceiro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox DataExecucao;
        private System.Windows.Forms.TextBox Requerimento;
        private System.Windows.Forms.TextBox ProtocoloDocumento;
        private System.Windows.Forms.Label lblDataExecucao;
        private System.Windows.Forms.Label lblNumeroProtocolo;
        private System.Windows.Forms.Label lblRequerimento;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.Label lblValorLiquido;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTipoLancamento;
        private System.Windows.Forms.Label lblValorAReceber;
        private System.Windows.Forms.Label lblProcesso;
        private System.Windows.Forms.Label lblValorReajustado;
        private System.Windows.Forms.Label lblDividaAtiva;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblValorBruto;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox DataMovimento;
        private System.Windows.Forms.TextBox Ano;
        private System.Windows.Forms.TextBox Parcela;
        private System.Windows.Forms.TextBox ValorBruto;
        private System.Windows.Forms.TextBox ValorSaldo;
        private System.Windows.Forms.TextBox DividaAtiva;
        private System.Windows.Forms.TextBox Reajustado;
        private System.Windows.Forms.TextBox Processo;
        private System.Windows.Forms.TextBox ValorLiquido;
        private System.Windows.Forms.TextBox TipoLancamento;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox DataOperacao;
        private System.Windows.Forms.TextBox Pessoa;
        private System.Windows.Forms.Label lblSacado;
        private System.Windows.Forms.TextBox Situacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox ComplementoSituacao;
        private System.Windows.Forms.Label label1;
    }
}