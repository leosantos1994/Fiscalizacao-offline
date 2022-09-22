
namespace Fiscalizacao
{
    partial class frmProcessos
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
            this.dgvProcessosNotificacoes = new System.Windows.Forms.DataGridView();
            this.NumeroDaNotificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrazoRegularizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProcessosInfracoes = new System.Windows.Forms.DataGridView();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autuado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProcessosTramitesProcessuais = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabProcesso = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.MembroDesignado = new System.Windows.Forms.TextBox();
            this.TipoDesignacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Representante = new System.Windows.Forms.TextBox();
            this.Representado = new System.Windows.Forms.TextBox();
            this.TramiteAtual = new System.Windows.Forms.TextBox();
            this.TipoProcesso = new System.Windows.Forms.TextBox();
            this.ProtocoloDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRepresentado = new System.Windows.Forms.Label();
            this.lblUltimoTramite = new System.Windows.Forms.Label();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.lblProtocolo = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblValorAtualizado = new System.Windows.Forms.Label();
            this.ValorTitulosAtualizado = new System.Windows.Forms.TextBox();
            this.lblComarca = new System.Windows.Forms.Label();
            this.Comarca = new System.Windows.Forms.TextBox();
            this.lblHonorarios = new System.Windows.Forms.Label();
            this.lblVara = new System.Windows.Forms.Label();
            this.Vara = new System.Windows.Forms.TextBox();
            this.lblFolha = new System.Windows.Forms.Label();
            this.Folha = new System.Windows.Forms.TextBox();
            this.lblValorBruto = new System.Windows.Forms.Label();
            this.ValorTitulosBruto = new System.Windows.Forms.TextBox();
            this.lblLivro = new System.Windows.Forms.Label();
            this.Livro = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.Local = new System.Windows.Forms.TextBox();
            this.lblPessoaFisica = new System.Windows.Forms.Label();
            this.Advogado1 = new System.Windows.Forms.TextBox();
            this.lblJuizo = new System.Windows.Forms.Label();
            this.Juizo = new System.Windows.Forms.TextBox();
            this.lblExercicio = new System.Windows.Forms.Label();
            this.Exercicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ValorCustasProcessuais = new System.Windows.Forms.TextBox();
            this.lblDivida = new System.Windows.Forms.Label();
            this.ProcessoJuridicoExterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Honorarios = new System.Windows.Forms.TextBox();
            this.RenegociacaoSimulacao = new System.Windows.Forms.TextBox();
            this.lblCertidaoDivida = new System.Windows.Forms.Label();
            this.NumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblProcessoAntigo = new System.Windows.Forms.Label();
            this.NumeroProcessoAntigo = new System.Windows.Forms.TextBox();
            this.ProcessoJuridico = new System.Windows.Forms.TextBox();
            this.lblNumeroDoProcessoJuridico = new System.Windows.Forms.Label();
            this.lblInfracoes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessosNotificacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessosInfracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessosTramitesProcessuais)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabProcesso.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(9, 709);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvProcessosNotificacoes
            // 
            this.dgvProcessosNotificacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessosNotificacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDaNotificacao,
            this.DataRecebimento,
            this.PrazoRegularizacao});
            this.dgvProcessosNotificacoes.Location = new System.Drawing.Point(6, 6);
            this.dgvProcessosNotificacoes.Name = "dgvProcessosNotificacoes";
            this.dgvProcessosNotificacoes.Size = new System.Drawing.Size(837, 250);
            this.dgvProcessosNotificacoes.TabIndex = 1;
            this.dgvProcessosNotificacoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessosNotificacoes_CellDoubleClick);
            // 
            // NumeroDaNotificacao
            // 
            this.NumeroDaNotificacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumeroDaNotificacao.HeaderText = "Número da Notificação";
            this.NumeroDaNotificacao.Name = "NumeroDaNotificacao";
            // 
            // DataRecebimento
            // 
            this.DataRecebimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataRecebimento.HeaderText = "Data Recebimento";
            this.DataRecebimento.Name = "DataRecebimento";
            // 
            // PrazoRegularizacao
            // 
            this.PrazoRegularizacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrazoRegularizacao.HeaderText = "Prazo Regularização";
            this.PrazoRegularizacao.Name = "PrazoRegularizacao";
            // 
            // dgvProcessosInfracoes
            // 
            this.dgvProcessosInfracoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessosInfracoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ano,
            this.Autuado,
            this.Fiscal,
            this.Situacao});
            this.dgvProcessosInfracoes.Location = new System.Drawing.Point(6, 6);
            this.dgvProcessosInfracoes.Name = "dgvProcessosInfracoes";
            this.dgvProcessosInfracoes.Size = new System.Drawing.Size(837, 250);
            this.dgvProcessosInfracoes.TabIndex = 2;
            this.dgvProcessosInfracoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessosInfracoes_CellDoubleClick);
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            // 
            // Autuado
            // 
            this.Autuado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autuado.HeaderText = "Autuado";
            this.Autuado.Name = "Autuado";
            // 
            // Fiscal
            // 
            this.Fiscal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fiscal.HeaderText = "Fiscal";
            this.Fiscal.Name = "Fiscal";
            // 
            // Situacao
            // 
            this.Situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            // 
            // dgvProcessosTramitesProcessuais
            // 
            this.dgvProcessosTramitesProcessuais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessosTramitesProcessuais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Fase,
            this.Processo});
            this.dgvProcessosTramitesProcessuais.Location = new System.Drawing.Point(3, 6);
            this.dgvProcessosTramitesProcessuais.Name = "dgvProcessosTramitesProcessuais";
            this.dgvProcessosTramitesProcessuais.Size = new System.Drawing.Size(913, 250);
            this.dgvProcessosTramitesProcessuais.TabIndex = 3;
            this.dgvProcessosTramitesProcessuais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessosTramitesProcessuais_CellDoubleClick);
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Fase
            // 
            this.Fase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fase.HeaderText = "Fase";
            this.Fase.Name = "Fase";
            // 
            // Processo
            // 
            this.Processo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Processo.HeaderText = "Processo";
            this.Processo.Name = "Processo";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 404);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 288);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvProcessosInfracoes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Infrações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvProcessosNotificacoes);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notificações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvProcessosTramitesProcessuais);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(916, 259);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trâmites";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabProcesso
            // 
            this.tabProcesso.Controls.Add(this.tabPage4);
            this.tabProcesso.Controls.Add(this.tabPage5);
            this.tabProcesso.Location = new System.Drawing.Point(12, 12);
            this.tabProcesso.Name = "tabProcesso";
            this.tabProcesso.SelectedIndex = 0;
            this.tabProcesso.Size = new System.Drawing.Size(924, 368);
            this.tabProcesso.TabIndex = 22;
            this.tabProcesso.Tag = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.MembroDesignado);
            this.tabPage4.Controls.Add(this.TipoDesignacao);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.Representante);
            this.tabPage4.Controls.Add(this.Representado);
            this.tabPage4.Controls.Add(this.TramiteAtual);
            this.tabPage4.Controls.Add(this.TipoProcesso);
            this.tabPage4.Controls.Add(this.ProtocoloDocumento);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.lblRepresentado);
            this.tabPage4.Controls.Add(this.lblUltimoTramite);
            this.tabPage4.Controls.Add(this.lblTipoPedido);
            this.tabPage4.Controls.Add(this.lblProtocolo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(916, 342);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Processos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MembroDesignado
            // 
            this.MembroDesignado.Location = new System.Drawing.Point(134, 170);
            this.MembroDesignado.Name = "MembroDesignado";
            this.MembroDesignado.Size = new System.Drawing.Size(723, 20);
            this.MembroDesignado.TabIndex = 31;
            // 
            // TipoDesignacao
            // 
            this.TipoDesignacao.Location = new System.Drawing.Point(134, 144);
            this.TipoDesignacao.Name = "TipoDesignacao";
            this.TipoDesignacao.Size = new System.Drawing.Size(723, 20);
            this.TipoDesignacao.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Designação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Membro Designado";
            // 
            // Representante
            // 
            this.Representante.Location = new System.Drawing.Point(134, 118);
            this.Representante.Name = "Representante";
            this.Representante.Size = new System.Drawing.Size(723, 20);
            this.Representante.TabIndex = 27;
            // 
            // Representado
            // 
            this.Representado.Location = new System.Drawing.Point(134, 92);
            this.Representado.Name = "Representado";
            this.Representado.Size = new System.Drawing.Size(723, 20);
            this.Representado.TabIndex = 26;
            // 
            // TramiteAtual
            // 
            this.TramiteAtual.Location = new System.Drawing.Point(134, 66);
            this.TramiteAtual.Name = "TramiteAtual";
            this.TramiteAtual.Size = new System.Drawing.Size(723, 20);
            this.TramiteAtual.TabIndex = 25;
            // 
            // TipoProcesso
            // 
            this.TipoProcesso.Location = new System.Drawing.Point(134, 40);
            this.TipoProcesso.Name = "TipoProcesso";
            this.TipoProcesso.Size = new System.Drawing.Size(723, 20);
            this.TipoProcesso.TabIndex = 24;
            // 
            // ProtocoloDocumento
            // 
            this.ProtocoloDocumento.Location = new System.Drawing.Point(134, 13);
            this.ProtocoloDocumento.Name = "ProtocoloDocumento";
            this.ProtocoloDocumento.Size = new System.Drawing.Size(723, 20);
            this.ProtocoloDocumento.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Representante";
            // 
            // lblRepresentado
            // 
            this.lblRepresentado.AutoSize = true;
            this.lblRepresentado.Location = new System.Drawing.Point(22, 92);
            this.lblRepresentado.Name = "lblRepresentado";
            this.lblRepresentado.Size = new System.Drawing.Size(74, 13);
            this.lblRepresentado.TabIndex = 21;
            this.lblRepresentado.Text = "Representado";
            // 
            // lblUltimoTramite
            // 
            this.lblUltimoTramite.AutoSize = true;
            this.lblUltimoTramite.Location = new System.Drawing.Point(22, 66);
            this.lblUltimoTramite.Name = "lblUltimoTramite";
            this.lblUltimoTramite.Size = new System.Drawing.Size(74, 13);
            this.lblUltimoTramite.TabIndex = 20;
            this.lblUltimoTramite.Text = "Último Trâmite";
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Location = new System.Drawing.Point(22, 40);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(90, 13);
            this.lblTipoPedido.TabIndex = 19;
            this.lblTipoPedido.Text = "Tipo de Processo";
            // 
            // lblProtocolo
            // 
            this.lblProtocolo.AutoSize = true;
            this.lblProtocolo.Location = new System.Drawing.Point(26, 13);
            this.lblProtocolo.Name = "lblProtocolo";
            this.lblProtocolo.Size = new System.Drawing.Size(52, 13);
            this.lblProtocolo.TabIndex = 18;
            this.lblProtocolo.Text = "Protocolo";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblValorAtualizado);
            this.tabPage5.Controls.Add(this.ValorTitulosAtualizado);
            this.tabPage5.Controls.Add(this.lblComarca);
            this.tabPage5.Controls.Add(this.Comarca);
            this.tabPage5.Controls.Add(this.lblHonorarios);
            this.tabPage5.Controls.Add(this.lblVara);
            this.tabPage5.Controls.Add(this.Vara);
            this.tabPage5.Controls.Add(this.lblFolha);
            this.tabPage5.Controls.Add(this.Folha);
            this.tabPage5.Controls.Add(this.lblValorBruto);
            this.tabPage5.Controls.Add(this.ValorTitulosBruto);
            this.tabPage5.Controls.Add(this.lblLivro);
            this.tabPage5.Controls.Add(this.Livro);
            this.tabPage5.Controls.Add(this.lblLocal);
            this.tabPage5.Controls.Add(this.Local);
            this.tabPage5.Controls.Add(this.lblPessoaFisica);
            this.tabPage5.Controls.Add(this.Advogado1);
            this.tabPage5.Controls.Add(this.lblJuizo);
            this.tabPage5.Controls.Add(this.Juizo);
            this.tabPage5.Controls.Add(this.lblExercicio);
            this.tabPage5.Controls.Add(this.Exercicio);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.ValorCustasProcessuais);
            this.tabPage5.Controls.Add(this.lblDivida);
            this.tabPage5.Controls.Add(this.ProcessoJuridicoExterno);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.Honorarios);
            this.tabPage5.Controls.Add(this.RenegociacaoSimulacao);
            this.tabPage5.Controls.Add(this.lblCertidaoDivida);
            this.tabPage5.Controls.Add(this.NumeroDocumento);
            this.tabPage5.Controls.Add(this.lblProcessoAntigo);
            this.tabPage5.Controls.Add(this.NumeroProcessoAntigo);
            this.tabPage5.Controls.Add(this.ProcessoJuridico);
            this.tabPage5.Controls.Add(this.lblNumeroDoProcessoJuridico);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(916, 342);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Divida Ativa";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblValorAtualizado
            // 
            this.lblValorAtualizado.AutoSize = true;
            this.lblValorAtualizado.Location = new System.Drawing.Point(339, 261);
            this.lblValorAtualizado.Name = "lblValorAtualizado";
            this.lblValorAtualizado.Size = new System.Drawing.Size(83, 13);
            this.lblValorAtualizado.TabIndex = 68;
            this.lblValorAtualizado.Text = "Valor Atualizado";
            // 
            // ValorTitulosAtualizado
            // 
            this.ValorTitulosAtualizado.Location = new System.Drawing.Point(342, 277);
            this.ValorTitulosAtualizado.Name = "ValorTitulosAtualizado";
            this.ValorTitulosAtualizado.Size = new System.Drawing.Size(338, 20);
            this.ValorTitulosAtualizado.TabIndex = 67;
            // 
            // lblComarca
            // 
            this.lblComarca.AutoSize = true;
            this.lblComarca.Location = new System.Drawing.Point(6, 171);
            this.lblComarca.Name = "lblComarca";
            this.lblComarca.Size = new System.Drawing.Size(49, 13);
            this.lblComarca.TabIndex = 66;
            this.lblComarca.Text = "Comarca";
            // 
            // Comarca
            // 
            this.Comarca.Location = new System.Drawing.Point(6, 187);
            this.Comarca.Name = "Comarca";
            this.Comarca.Size = new System.Drawing.Size(427, 20);
            this.Comarca.TabIndex = 65;
            // 
            // lblHonorarios
            // 
            this.lblHonorarios.AutoSize = true;
            this.lblHonorarios.Location = new System.Drawing.Point(6, 215);
            this.lblHonorarios.Name = "lblHonorarios";
            this.lblHonorarios.Size = new System.Drawing.Size(58, 13);
            this.lblHonorarios.TabIndex = 42;
            this.lblHonorarios.Text = "Honorarios";
            // 
            // lblVara
            // 
            this.lblVara.AutoSize = true;
            this.lblVara.Location = new System.Drawing.Point(525, 171);
            this.lblVara.Name = "lblVara";
            this.lblVara.Size = new System.Drawing.Size(29, 13);
            this.lblVara.TabIndex = 64;
            this.lblVara.Text = "Vara";
            // 
            // Vara
            // 
            this.Vara.Location = new System.Drawing.Point(528, 187);
            this.Vara.Name = "Vara";
            this.Vara.Size = new System.Drawing.Size(355, 20);
            this.Vara.TabIndex = 63;
            // 
            // lblFolha
            // 
            this.lblFolha.AutoSize = true;
            this.lblFolha.Location = new System.Drawing.Point(354, 128);
            this.lblFolha.Name = "lblFolha";
            this.lblFolha.Size = new System.Drawing.Size(33, 13);
            this.lblFolha.TabIndex = 62;
            this.lblFolha.Text = "Folha";
            // 
            // Folha
            // 
            this.Folha.Location = new System.Drawing.Point(357, 144);
            this.Folha.Name = "Folha";
            this.Folha.Size = new System.Drawing.Size(323, 20);
            this.Folha.TabIndex = 61;
            // 
            // lblValorBruto
            // 
            this.lblValorBruto.AutoSize = true;
            this.lblValorBruto.Location = new System.Drawing.Point(6, 261);
            this.lblValorBruto.Name = "lblValorBruto";
            this.lblValorBruto.Size = new System.Drawing.Size(59, 13);
            this.lblValorBruto.TabIndex = 60;
            this.lblValorBruto.Text = "Valor Bruto";
            // 
            // ValorTitulosBruto
            // 
            this.ValorTitulosBruto.Location = new System.Drawing.Point(6, 277);
            this.ValorTitulosBruto.Name = "ValorTitulosBruto";
            this.ValorTitulosBruto.Size = new System.Drawing.Size(261, 20);
            this.ValorTitulosBruto.TabIndex = 59;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(3, 128);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(30, 13);
            this.lblLivro.TabIndex = 58;
            this.lblLivro.Text = "Livro";
            // 
            // Livro
            // 
            this.Livro.Location = new System.Drawing.Point(6, 144);
            this.Livro.Name = "Livro";
            this.Livro.Size = new System.Drawing.Size(316, 20);
            this.Livro.TabIndex = 57;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(705, 128);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 56;
            this.lblLocal.Text = "Local";
            // 
            // Local
            // 
            this.Local.Location = new System.Drawing.Point(708, 144);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(175, 20);
            this.Local.TabIndex = 55;
            // 
            // lblPessoaFisica
            // 
            this.lblPessoaFisica.AutoSize = true;
            this.lblPessoaFisica.Location = new System.Drawing.Point(6, 89);
            this.lblPessoaFisica.Name = "lblPessoaFisica";
            this.lblPessoaFisica.Size = new System.Drawing.Size(74, 13);
            this.lblPessoaFisica.TabIndex = 54;
            this.lblPessoaFisica.Text = "Pessoa Física";
            // 
            // Advogado1
            // 
            this.Advogado1.Location = new System.Drawing.Point(6, 105);
            this.Advogado1.Name = "Advogado1";
            this.Advogado1.Size = new System.Drawing.Size(877, 20);
            this.Advogado1.TabIndex = 53;
            // 
            // lblJuizo
            // 
            this.lblJuizo.AutoSize = true;
            this.lblJuizo.Location = new System.Drawing.Point(717, 11);
            this.lblJuizo.Name = "lblJuizo";
            this.lblJuizo.Size = new System.Drawing.Size(33, 13);
            this.lblJuizo.TabIndex = 52;
            this.lblJuizo.Text = "Juízo";
            // 
            // Juizo
            // 
            this.Juizo.Location = new System.Drawing.Point(720, 27);
            this.Juizo.Name = "Juizo";
            this.Juizo.Size = new System.Drawing.Size(163, 20);
            this.Juizo.TabIndex = 51;
            // 
            // lblExercicio
            // 
            this.lblExercicio.AutoSize = true;
            this.lblExercicio.Location = new System.Drawing.Point(475, 50);
            this.lblExercicio.Name = "lblExercicio";
            this.lblExercicio.Size = new System.Drawing.Size(50, 13);
            this.lblExercicio.TabIndex = 50;
            this.lblExercicio.Text = "Exercicio";
            // 
            // Exercicio
            // 
            this.Exercicio.Location = new System.Drawing.Point(478, 66);
            this.Exercicio.Name = "Exercicio";
            this.Exercicio.Size = new System.Drawing.Size(202, 20);
            this.Exercicio.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(717, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "N° Processo Externo Jurídico";
            // 
            // ValorCustasProcessuais
            // 
            this.ValorCustasProcessuais.Location = new System.Drawing.Point(528, 231);
            this.ValorCustasProcessuais.Name = "ValorCustasProcessuais";
            this.ValorCustasProcessuais.Size = new System.Drawing.Size(355, 20);
            this.ValorCustasProcessuais.TabIndex = 47;
            // 
            // lblDivida
            // 
            this.lblDivida.AutoSize = true;
            this.lblDivida.Location = new System.Drawing.Point(250, 50);
            this.lblDivida.Name = "lblDivida";
            this.lblDivida.Size = new System.Drawing.Size(42, 13);
            this.lblDivida.TabIndex = 46;
            this.lblDivida.Text = "Dívida ";
            // 
            // ProcessoJuridicoExterno
            // 
            this.ProcessoJuridicoExterno.Location = new System.Drawing.Point(720, 66);
            this.ProcessoJuridicoExterno.Name = "ProcessoJuridicoExterno";
            this.ProcessoJuridicoExterno.Size = new System.Drawing.Size(163, 20);
            this.ProcessoJuridicoExterno.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Custas";
            // 
            // Honorarios
            // 
            this.Honorarios.Location = new System.Drawing.Point(6, 231);
            this.Honorarios.Name = "Honorarios";
            this.Honorarios.Size = new System.Drawing.Size(427, 20);
            this.Honorarios.TabIndex = 43;
            // 
            // RenegociacaoSimulacao
            // 
            this.RenegociacaoSimulacao.Location = new System.Drawing.Point(253, 66);
            this.RenegociacaoSimulacao.Name = "RenegociacaoSimulacao";
            this.RenegociacaoSimulacao.Size = new System.Drawing.Size(195, 20);
            this.RenegociacaoSimulacao.TabIndex = 41;
            // 
            // lblCertidaoDivida
            // 
            this.lblCertidaoDivida.AutoSize = true;
            this.lblCertidaoDivida.Location = new System.Drawing.Point(6, 50);
            this.lblCertidaoDivida.Name = "lblCertidaoDivida";
            this.lblCertidaoDivida.Size = new System.Drawing.Size(81, 13);
            this.lblCertidaoDivida.TabIndex = 40;
            this.lblCertidaoDivida.Text = "Certidão Dívida";
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.Location = new System.Drawing.Point(6, 66);
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.Size = new System.Drawing.Size(214, 20);
            this.NumeroDocumento.TabIndex = 39;
            // 
            // lblProcessoAntigo
            // 
            this.lblProcessoAntigo.AutoSize = true;
            this.lblProcessoAntigo.Location = new System.Drawing.Point(373, 11);
            this.lblProcessoAntigo.Name = "lblProcessoAntigo";
            this.lblProcessoAntigo.Size = new System.Drawing.Size(84, 13);
            this.lblProcessoAntigo.TabIndex = 38;
            this.lblProcessoAntigo.Text = "Processo Antigo";
            // 
            // NumeroProcessoAntigo
            // 
            this.NumeroProcessoAntigo.Location = new System.Drawing.Point(376, 27);
            this.NumeroProcessoAntigo.Name = "NumeroProcessoAntigo";
            this.NumeroProcessoAntigo.Size = new System.Drawing.Size(326, 20);
            this.NumeroProcessoAntigo.TabIndex = 37;
            // 
            // ProcessoJuridico
            // 
            this.ProcessoJuridico.Location = new System.Drawing.Point(6, 27);
            this.ProcessoJuridico.Name = "ProcessoJuridico";
            this.ProcessoJuridico.Size = new System.Drawing.Size(338, 20);
            this.ProcessoJuridico.TabIndex = 35;
            // 
            // lblNumeroDoProcessoJuridico
            // 
            this.lblNumeroDoProcessoJuridico.AutoSize = true;
            this.lblNumeroDoProcessoJuridico.Location = new System.Drawing.Point(6, 11);
            this.lblNumeroDoProcessoJuridico.Name = "lblNumeroDoProcessoJuridico";
            this.lblNumeroDoProcessoJuridico.Size = new System.Drawing.Size(121, 13);
            this.lblNumeroDoProcessoJuridico.TabIndex = 36;
            this.lblNumeroDoProcessoJuridico.Text = "N° do processo Jurídico";
            // 
            // lblInfracoes
            // 
            this.lblInfracoes.AutoSize = true;
            this.lblInfracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfracoes.Location = new System.Drawing.Point(16, 388);
            this.lblInfracoes.Name = "lblInfracoes";
            this.lblInfracoes.Size = new System.Drawing.Size(60, 13);
            this.lblInfracoes.TabIndex = 18;
            this.lblInfracoes.Text = "Infrações";
            this.lblInfracoes.Click += new System.EventHandler(this.lblInfracoes_Click);
            // 
            // frmProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(948, 749);
            this.Controls.Add(this.tabProcesso);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblInfracoes);
            this.Controls.Add(this.btnFechar);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmProcessos";
            this.Text = "frmProcessos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProcessos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessosNotificacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessosInfracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessosTramitesProcessuais)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabProcesso.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvProcessosNotificacoes;
        private System.Windows.Forms.DataGridView dgvProcessosInfracoes;
        private System.Windows.Forms.DataGridView dgvProcessosTramitesProcessuais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autuado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDaNotificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrazoRegularizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabProcesso;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox MembroDesignado;
        private System.Windows.Forms.TextBox TipoDesignacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Representante;
        private System.Windows.Forms.TextBox Representado;
        private System.Windows.Forms.TextBox TramiteAtual;
        private System.Windows.Forms.TextBox TipoProcesso;
        private System.Windows.Forms.TextBox ProtocoloDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRepresentado;
        private System.Windows.Forms.Label lblUltimoTramite;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.Label lblProtocolo;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblInfracoes;
        private System.Windows.Forms.Label lblValorAtualizado;
        private System.Windows.Forms.TextBox ValorTitulosAtualizado;
        private System.Windows.Forms.Label lblComarca;
        private System.Windows.Forms.TextBox Comarca;
        private System.Windows.Forms.Label lblHonorarios;
        private System.Windows.Forms.Label lblVara;
        private System.Windows.Forms.TextBox Vara;
        private System.Windows.Forms.Label lblFolha;
        private System.Windows.Forms.TextBox Folha;
        private System.Windows.Forms.Label lblValorBruto;
        private System.Windows.Forms.TextBox ValorTitulosBruto;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.TextBox Livro;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox Local;
        private System.Windows.Forms.Label lblPessoaFisica;
        private System.Windows.Forms.TextBox Advogado1;
        private System.Windows.Forms.Label lblJuizo;
        private System.Windows.Forms.TextBox Juizo;
        private System.Windows.Forms.Label lblExercicio;
        private System.Windows.Forms.TextBox Exercicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ValorCustasProcessuais;
        private System.Windows.Forms.Label lblDivida;
        private System.Windows.Forms.TextBox ProcessoJuridicoExterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Honorarios;
        private System.Windows.Forms.TextBox RenegociacaoSimulacao;
        private System.Windows.Forms.Label lblCertidaoDivida;
        private System.Windows.Forms.TextBox NumeroDocumento;
        private System.Windows.Forms.Label lblProcessoAntigo;
        private System.Windows.Forms.TextBox NumeroProcessoAntigo;
        private System.Windows.Forms.TextBox ProcessoJuridico;
        private System.Windows.Forms.Label lblNumeroDoProcessoJuridico;
    }
}