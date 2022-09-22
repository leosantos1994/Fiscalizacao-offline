
namespace Fiscalizacao
{
    partial class frmNotificacao
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
            this.dgvInfracao = new System.Windows.Forms.DataGridView();
            this.Representado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificacaoDoProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FundamentoLegal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Providencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrazoManual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeRegularizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDaInfracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodicidadeManual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataParaRegularizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrazoRegularizacao = new System.Windows.Forms.TextBox();
            this.DataRecebimento = new System.Windows.Forms.TextBox();
            this.NumeroNotificacao = new System.Windows.Forms.TextBox();
            this.NumeroAvisoRecebimento = new System.Windows.Forms.TextBox();
            this.DiasPrazoDecorrido = new System.Windows.Forms.TextBox();
            this.lblNumeroDaNotificacao = new System.Windows.Forms.Label();
            this.lblDataRecebimento = new System.Windows.Forms.Label();
            this.lblPrazoRegularizacao = new System.Windows.Forms.Label();
            this.lblNumeroAvisoRecebimento = new System.Windows.Forms.Label();
            this.lblDiasPrazoDecorrido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfracao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(9, 698);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvInfracao
            // 
            this.dgvInfracao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfracao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Representado,
            this.NotificacaoDoProcesso,
            this.Tipificacao,
            this.FundamentoLegal,
            this.Providencia,
            this.PrazoManual,
            this.DataDeRegularizacao,
            this.Processo,
            this.Identificacao,
            this.Notificacao,
            this.Prazo,
            this.DataDaInfracao,
            this.PeriodicidadeManual,
            this.DataParaRegularizacao});
            this.dgvInfracao.Location = new System.Drawing.Point(15, 193);
            this.dgvInfracao.Name = "dgvInfracao";
            this.dgvInfracao.Size = new System.Drawing.Size(975, 305);
            this.dgvInfracao.TabIndex = 4;
            this.dgvInfracao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotificacoesTabela_CellDoubleClick);
            // 
            // Representado
            // 
            this.Representado.HeaderText = "Representado";
            this.Representado.Name = "Representado";
            // 
            // NotificacaoDoProcesso
            // 
            this.NotificacaoDoProcesso.HeaderText = "Notificação do Processo";
            this.NotificacaoDoProcesso.Name = "NotificacaoDoProcesso";
            // 
            // Tipificacao
            // 
            this.Tipificacao.HeaderText = "Tipificação";
            this.Tipificacao.Name = "Tipificacao";
            // 
            // FundamentoLegal
            // 
            this.FundamentoLegal.HeaderText = "Fundamento Legal";
            this.FundamentoLegal.Name = "FundamentoLegal";
            // 
            // Providencia
            // 
            this.Providencia.HeaderText = "Providência";
            this.Providencia.Name = "Providencia";
            // 
            // PrazoManual
            // 
            this.PrazoManual.HeaderText = "Prazo Manual";
            this.PrazoManual.Name = "PrazoManual";
            // 
            // DataDeRegularizacao
            // 
            this.DataDeRegularizacao.HeaderText = "Data de Regularização";
            this.DataDeRegularizacao.Name = "DataDeRegularizacao";
            // 
            // Processo
            // 
            this.Processo.HeaderText = "Processo";
            this.Processo.Name = "Processo";
            // 
            // Identificacao
            // 
            this.Identificacao.HeaderText = "Identificação";
            this.Identificacao.Name = "Identificacao";
            // 
            // Notificacao
            // 
            this.Notificacao.HeaderText = "Notificação";
            this.Notificacao.Name = "Notificacao";
            // 
            // Prazo
            // 
            this.Prazo.HeaderText = "Prazo";
            this.Prazo.Name = "Prazo";
            // 
            // DataDaInfracao
            // 
            this.DataDaInfracao.HeaderText = "Data da Infração";
            this.DataDaInfracao.Name = "DataDaInfracao";
            // 
            // PeriodicidadeManual
            // 
            this.PeriodicidadeManual.HeaderText = "Periodicidade Manual";
            this.PeriodicidadeManual.Name = "PeriodicidadeManual";
            // 
            // DataParaRegularizacao
            // 
            this.DataParaRegularizacao.HeaderText = "Data para Regularização";
            this.DataParaRegularizacao.Name = "DataParaRegularizacao";
            // 
            // PrazoRegularizacao
            // 
            this.PrazoRegularizacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrazoRegularizacao.Location = new System.Drawing.Point(170, 88);
            this.PrazoRegularizacao.Name = "PrazoRegularizacao";
            this.PrazoRegularizacao.Size = new System.Drawing.Size(817, 20);
            this.PrazoRegularizacao.TabIndex = 23;
            // 
            // DataRecebimento
            // 
            this.DataRecebimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataRecebimento.Location = new System.Drawing.Point(170, 62);
            this.DataRecebimento.Name = "DataRecebimento";
            this.DataRecebimento.Size = new System.Drawing.Size(817, 20);
            this.DataRecebimento.TabIndex = 22;
            // 
            // NumeroNotificacao
            // 
            this.NumeroNotificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumeroNotificacao.Location = new System.Drawing.Point(170, 36);
            this.NumeroNotificacao.Name = "NumeroNotificacao";
            this.NumeroNotificacao.Size = new System.Drawing.Size(817, 20);
            this.NumeroNotificacao.TabIndex = 21;
            // 
            // NumeroAvisoRecebimento
            // 
            this.NumeroAvisoRecebimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumeroAvisoRecebimento.Location = new System.Drawing.Point(170, 114);
            this.NumeroAvisoRecebimento.Name = "NumeroAvisoRecebimento";
            this.NumeroAvisoRecebimento.Size = new System.Drawing.Size(817, 20);
            this.NumeroAvisoRecebimento.TabIndex = 20;
            // 
            // DiasPrazoDecorrido
            // 
            this.DiasPrazoDecorrido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiasPrazoDecorrido.Location = new System.Drawing.Point(170, 140);
            this.DiasPrazoDecorrido.Name = "DiasPrazoDecorrido";
            this.DiasPrazoDecorrido.Size = new System.Drawing.Size(817, 20);
            this.DiasPrazoDecorrido.TabIndex = 19;
            // 
            // lblNumeroDaNotificacao
            // 
            this.lblNumeroDaNotificacao.AutoSize = true;
            this.lblNumeroDaNotificacao.Location = new System.Drawing.Point(12, 36);
            this.lblNumeroDaNotificacao.Name = "lblNumeroDaNotificacao";
            this.lblNumeroDaNotificacao.Size = new System.Drawing.Size(116, 13);
            this.lblNumeroDaNotificacao.TabIndex = 24;
            this.lblNumeroDaNotificacao.Text = "Numero da Notificação";
            // 
            // lblDataRecebimento
            // 
            this.lblDataRecebimento.AutoSize = true;
            this.lblDataRecebimento.Location = new System.Drawing.Point(12, 62);
            this.lblDataRecebimento.Name = "lblDataRecebimento";
            this.lblDataRecebimento.Size = new System.Drawing.Size(96, 13);
            this.lblDataRecebimento.TabIndex = 25;
            this.lblDataRecebimento.Text = "Data Recebimento";
            // 
            // lblPrazoRegularizacao
            // 
            this.lblPrazoRegularizacao.AutoSize = true;
            this.lblPrazoRegularizacao.Location = new System.Drawing.Point(12, 88);
            this.lblPrazoRegularizacao.Name = "lblPrazoRegularizacao";
            this.lblPrazoRegularizacao.Size = new System.Drawing.Size(105, 13);
            this.lblPrazoRegularizacao.TabIndex = 26;
            this.lblPrazoRegularizacao.Text = "Prazo Regularização";
            // 
            // lblNumeroAvisoRecebimento
            // 
            this.lblNumeroAvisoRecebimento.AutoSize = true;
            this.lblNumeroAvisoRecebimento.Location = new System.Drawing.Point(12, 114);
            this.lblNumeroAvisoRecebimento.Name = "lblNumeroAvisoRecebimento";
            this.lblNumeroAvisoRecebimento.Size = new System.Drawing.Size(139, 13);
            this.lblNumeroAvisoRecebimento.TabIndex = 27;
            this.lblNumeroAvisoRecebimento.Text = "Numero Aviso Recebimento";
            // 
            // lblDiasPrazoDecorrido
            // 
            this.lblDiasPrazoDecorrido.AutoSize = true;
            this.lblDiasPrazoDecorrido.Location = new System.Drawing.Point(12, 140);
            this.lblDiasPrazoDecorrido.Name = "lblDiasPrazoDecorrido";
            this.lblDiasPrazoDecorrido.Size = new System.Drawing.Size(122, 13);
            this.lblDiasPrazoDecorrido.TabIndex = 28;
            this.lblDiasPrazoDecorrido.Text = "Dias de Prazo Decorrido";
            // 
            // frmNotificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1000, 738);
            this.Controls.Add(this.lblDiasPrazoDecorrido);
            this.Controls.Add(this.lblNumeroAvisoRecebimento);
            this.Controls.Add(this.lblPrazoRegularizacao);
            this.Controls.Add(this.lblDataRecebimento);
            this.Controls.Add(this.lblNumeroDaNotificacao);
            this.Controls.Add(this.PrazoRegularizacao);
            this.Controls.Add(this.DataRecebimento);
            this.Controls.Add(this.NumeroNotificacao);
            this.Controls.Add(this.NumeroAvisoRecebimento);
            this.Controls.Add(this.DiasPrazoDecorrido);
            this.Controls.Add(this.dgvInfracao);
            this.Controls.Add(this.btnFechar);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmNotificacao";
            this.Text = "Notificações";
            this.Load += new System.EventHandler(this.frmNotificacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvInfracao;
        private System.Windows.Forms.TextBox PrazoRegularizacao;
        private System.Windows.Forms.TextBox DataRecebimento;
        private System.Windows.Forms.TextBox NumeroNotificacao;
        private System.Windows.Forms.TextBox NumeroAvisoRecebimento;
        private System.Windows.Forms.TextBox DiasPrazoDecorrido;
        private System.Windows.Forms.Label lblNumeroDaNotificacao;
        private System.Windows.Forms.Label lblDataRecebimento;
        private System.Windows.Forms.Label lblPrazoRegularizacao;
        private System.Windows.Forms.Label lblNumeroAvisoRecebimento;
        private System.Windows.Forms.Label lblDiasPrazoDecorrido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Representado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificacaoDoProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn FundamentoLegal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Providencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrazoManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeRegularizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDaInfracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodicidadeManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataParaRegularizacao;
    }
}