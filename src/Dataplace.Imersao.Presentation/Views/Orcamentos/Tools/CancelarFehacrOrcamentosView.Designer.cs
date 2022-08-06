namespace Dataplace.Imersao.Presentation.Views.Orcamentos.Tools
{
    partial class CancelarFehacrOrcamentosView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarFehacrOrcamentosView));
            this.gridOrcamento = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiMarcar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDesmarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAberto = new System.Windows.Forms.CheckBox();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.chkFechado = new System.Windows.Forms.CheckBox();
            this.rangeDate = new dpLibrary05.ucSymGen_ReferenceDtp();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dtAlteracao = new System.Windows.Forms.RadioButton();
            this.dtCancelamento = new System.Windows.Forms.RadioButton();
            this.dtFechamento = new System.Windows.Forms.RadioButton();
            this.dtAbertura = new System.Windows.Forms.RadioButton();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.optExcluir = new System.Windows.Forms.RadioButton();
            this.optReabrir = new System.Windows.Forms.RadioButton();
            this.optFechar = new System.Windows.Forms.RadioButton();
            this.optCancelar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUsuario = new System.Windows.Forms.CheckBox();
            this.chkVendedor = new System.Windows.Forms.CheckBox();
            this.dpCliente = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbAcoes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrcamento
            // 
            this.gridOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOrcamento.GroupByCaption = "Drag a column header here to group by that column";
            this.gridOrcamento.Images.Add(((System.Drawing.Image)(resources.GetObject("gridOrcamento.Images"))));
            this.gridOrcamento.Location = new System.Drawing.Point(3, 163);
            this.gridOrcamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridOrcamento.Name = "gridOrcamento";
            this.gridOrcamento.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.gridOrcamento.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.gridOrcamento.PreviewInfo.ZoomFactor = 75D;
            this.gridOrcamento.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.gridOrcamento.PrintInfo.MeasurementPrinterName = null;
            this.gridOrcamento.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("gridOrcamento.PrintInfo.PageSettings")));
            this.gridOrcamento.Size = new System.Drawing.Size(1339, 410);
            this.gridOrcamento.TabIndex = 3;
            this.gridOrcamento.UseCompatibleTextRendering = false;
            this.gridOrcamento.PropBag = resources.GetString("gridOrcamento.PropBag");
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(1232, 14);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(109, 30);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 683);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(122, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiMarcar,
            this.tsiDesmarca,
            this.tsiExcel});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(109, 24);
            this.toolStripSplitButton1.Text = "Ferramentas";
            // 
            // tsiMarcar
            // 
            this.tsiMarcar.Name = "tsiMarcar";
            this.tsiMarcar.Size = new System.Drawing.Size(220, 26);
            this.tsiMarcar.Text = "Marcar Todos";
            // 
            // tsiDesmarca
            // 
            this.tsiDesmarca.Name = "tsiDesmarca";
            this.tsiDesmarca.Size = new System.Drawing.Size(220, 26);
            this.tsiDesmarca.Text = "Desmarcar Todos";
            // 
            // tsiExcel
            // 
            this.tsiExcel.Name = "tsiExcel";
            this.tsiExcel.Size = new System.Drawing.Size(220, 26);
            this.tsiExcel.Text = "Exportar para excel";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkAberto);
            this.groupBox1.Controls.Add(this.chkCancelado);
            this.groupBox1.Controls.Add(this.chkFechado);
            this.groupBox1.Location = new System.Drawing.Point(863, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(361, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação do orçamento";
            // 
            // chkAberto
            // 
            this.chkAberto.AutoSize = true;
            this.chkAberto.Checked = true;
            this.chkAberto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAberto.Location = new System.Drawing.Point(15, 31);
            this.chkAberto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAberto.Name = "chkAberto";
            this.chkAberto.Size = new System.Drawing.Size(69, 20);
            this.chkAberto.TabIndex = 0;
            this.chkAberto.Text = "Aberto";
            this.chkAberto.UseVisualStyleBackColor = true;
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Location = new System.Drawing.Point(231, 31);
            this.chkCancelado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(95, 20);
            this.chkCancelado.TabIndex = 2;
            this.chkCancelado.Text = "Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // chkFechado
            // 
            this.chkFechado.AutoSize = true;
            this.chkFechado.Location = new System.Drawing.Point(115, 31);
            this.chkFechado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFechado.Name = "chkFechado";
            this.chkFechado.Size = new System.Drawing.Size(83, 20);
            this.chkFechado.TabIndex = 1;
            this.chkFechado.Text = "Fechado";
            this.chkFechado.UseVisualStyleBackColor = true;
            // 
            // rangeDate
            // 
            this.rangeDate.Date1CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.Date2CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rangeDate.DotNetContainer = false;
            this.rangeDate.KeyPreview = false;
            this.rangeDate.Label1Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TFrom;
            this.rangeDate.Label2Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TTo;
            this.rangeDate.Location = new System.Drawing.Point(9, 105);
            this.rangeDate.Margin = new System.Windows.Forms.Padding(5);
            this.rangeDate.Name = "rangeDate";
            this.rangeDate.OpenModal = false;
            this.rangeDate.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("rangeDate.Parameters")));
            this.rangeDate.Size = new System.Drawing.Size(428, 27);
            this.rangeDate.TabIndex = 0;
            this.rangeDate.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.dtAlteracao);
            this.gbData.Controls.Add(this.dtCancelamento);
            this.gbData.Controls.Add(this.dtFechamento);
            this.gbData.Controls.Add(this.dtAbertura);
            this.gbData.Controls.Add(this.rangeDate);
            this.gbData.Location = new System.Drawing.Point(4, 4);
            this.gbData.Margin = new System.Windows.Forms.Padding(4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4);
            this.gbData.Size = new System.Drawing.Size(852, 153);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data do orçamento";
            // 
            // dtAlteracao
            // 
            this.dtAlteracao.AutoSize = true;
            this.dtAlteracao.Location = new System.Drawing.Point(271, 60);
            this.dtAlteracao.Name = "dtAlteracao";
            this.dtAlteracao.Size = new System.Drawing.Size(137, 20);
            this.dtAlteracao.TabIndex = 5;
            this.dtAlteracao.TabStop = true;
            this.dtAlteracao.Text = "Data de Alteração";
            this.dtAlteracao.UseVisualStyleBackColor = true;
            // 
            // dtCancelamento
            // 
            this.dtCancelamento.AutoSize = true;
            this.dtCancelamento.Location = new System.Drawing.Point(271, 34);
            this.dtCancelamento.Name = "dtCancelamento";
            this.dtCancelamento.Size = new System.Drawing.Size(166, 20);
            this.dtCancelamento.TabIndex = 4;
            this.dtCancelamento.TabStop = true;
            this.dtCancelamento.Text = "Data de Cancelamento";
            this.dtCancelamento.UseVisualStyleBackColor = true;
            // 
            // dtFechamento
            // 
            this.dtFechamento.AutoSize = true;
            this.dtFechamento.Location = new System.Drawing.Point(21, 60);
            this.dtFechamento.Name = "dtFechamento";
            this.dtFechamento.Size = new System.Drawing.Size(154, 20);
            this.dtFechamento.TabIndex = 3;
            this.dtFechamento.TabStop = true;
            this.dtFechamento.Text = "Data de Fechamento";
            this.dtFechamento.UseVisualStyleBackColor = true;
            // 
            // dtAbertura
            // 
            this.dtAbertura.AutoSize = true;
            this.dtAbertura.Location = new System.Drawing.Point(21, 34);
            this.dtAbertura.Name = "dtAbertura";
            this.dtAbertura.Size = new System.Drawing.Size(130, 20);
            this.dtAbertura.TabIndex = 2;
            this.dtAbertura.TabStop = true;
            this.dtAbertura.Text = "Data de Abertura";
            this.dtAbertura.UseVisualStyleBackColor = true;
            // 
            // gbAcoes
            // 
            this.gbAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAcoes.Controls.Add(this.optExcluir);
            this.gbAcoes.Controls.Add(this.optReabrir);
            this.gbAcoes.Controls.Add(this.optFechar);
            this.gbAcoes.Controls.Add(this.optCancelar);
            this.gbAcoes.Location = new System.Drawing.Point(4, 579);
            this.gbAcoes.Margin = new System.Windows.Forms.Padding(4);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Padding = new System.Windows.Forms.Padding(4);
            this.gbAcoes.Size = new System.Drawing.Size(1337, 88);
            this.gbAcoes.TabIndex = 4;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "O que deseja fazer?";
            // 
            // optExcluir
            // 
            this.optExcluir.AutoSize = true;
            this.optExcluir.Location = new System.Drawing.Point(199, 52);
            this.optExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.optExcluir.Name = "optExcluir";
            this.optExcluir.Size = new System.Drawing.Size(134, 20);
            this.optExcluir.TabIndex = 10;
            this.optExcluir.Text = "Excluir orçamento";
            this.optExcluir.UseVisualStyleBackColor = true;
            // 
            // optReabrir
            // 
            this.optReabrir.AutoSize = true;
            this.optReabrir.Location = new System.Drawing.Point(199, 24);
            this.optReabrir.Margin = new System.Windows.Forms.Padding(4);
            this.optReabrir.Name = "optReabrir";
            this.optReabrir.Size = new System.Drawing.Size(140, 20);
            this.optReabrir.TabIndex = 9;
            this.optReabrir.Text = "Reabrir orçamento";
            this.optReabrir.UseVisualStyleBackColor = true;
            // 
            // optFechar
            // 
            this.optFechar.AutoSize = true;
            this.optFechar.Location = new System.Drawing.Point(32, 52);
            this.optFechar.Margin = new System.Windows.Forms.Padding(4);
            this.optFechar.Name = "optFechar";
            this.optFechar.Size = new System.Drawing.Size(137, 20);
            this.optFechar.TabIndex = 0;
            this.optFechar.Text = "Fechar orçamento";
            this.optFechar.UseVisualStyleBackColor = true;
            // 
            // optCancelar
            // 
            this.optCancelar.AutoSize = true;
            this.optCancelar.Location = new System.Drawing.Point(32, 23);
            this.optCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.optCancelar.Name = "optCancelar";
            this.optCancelar.Size = new System.Drawing.Size(149, 20);
            this.optCancelar.TabIndex = 6;
            this.optCancelar.Text = "Cancelar orçamento";
            this.optCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkUsuario);
            this.groupBox2.Controls.Add(this.chkVendedor);
            this.groupBox2.Controls.Add(this.dpCliente);
            this.groupBox2.Location = new System.Drawing.Point(863, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(361, 76);
            this.groupBox2.TabIndex = 501;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Por:";
            // 
            // chkUsuario
            // 
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.Location = new System.Drawing.Point(231, 35);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(76, 20);
            this.chkUsuario.TabIndex = 2;
            this.chkUsuario.Text = "Usuário";
            this.chkUsuario.UseVisualStyleBackColor = true;
            // 
            // chkVendedor
            // 
            this.chkVendedor.AutoSize = true;
            this.chkVendedor.Location = new System.Drawing.Point(115, 36);
            this.chkVendedor.Name = "chkVendedor";
            this.chkVendedor.Size = new System.Drawing.Size(89, 20);
            this.chkVendedor.TabIndex = 1;
            this.chkVendedor.Text = "Vendedor";
            this.chkVendedor.UseVisualStyleBackColor = true;
            // 
            // dpCliente
            // 
            this.dpCliente.AutoSize = true;
            this.dpCliente.Location = new System.Drawing.Point(14, 36);
            this.dpCliente.Name = "dpCliente";
            this.dpCliente.Size = new System.Drawing.Size(70, 20);
            this.dpCliente.TabIndex = 0;
            this.dpCliente.Text = "Cliente";
            this.dpCliente.UseVisualStyleBackColor = true;
            this.dpCliente.CheckedChanged += new System.EventHandler(this.dpCliente_CheckedChanged);
            // 
            // CancelarFehacrOrcamentosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.gridOrcamento);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CancelarFehacrOrcamentosView";
            this.Size = new System.Drawing.Size(1345, 750);
            this.Controls.SetChildIndex(this.gridOrcamento, 0);
            this.Controls.SetChildIndex(this.btnCarregar, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.gbAcoes, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbAcoes.ResumeLayout(false);
            this.gbAcoes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid gridOrcamento;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsiMarcar;
        private System.Windows.Forms.ToolStripMenuItem tsiDesmarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAberto;
        private System.Windows.Forms.CheckBox chkCancelado;
        private System.Windows.Forms.CheckBox chkFechado;
        private System.Windows.Forms.ToolStripMenuItem tsiExcel;
        internal dpLibrary05.ucSymGen_ReferenceDtp rangeDate;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.RadioButton optFechar;
        private System.Windows.Forms.RadioButton optCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optExcluir;
        private System.Windows.Forms.RadioButton optReabrir;
        private System.Windows.Forms.RadioButton dtFechamento;
        private System.Windows.Forms.RadioButton dtAbertura;
        private System.Windows.Forms.RadioButton dtCancelamento;
        private System.Windows.Forms.RadioButton dtAlteracao;
        private System.Windows.Forms.CheckBox chkUsuario;
        private System.Windows.Forms.CheckBox chkVendedor;
        private System.Windows.Forms.CheckBox dpCliente;
    }
}
