﻿namespace WFNapolitana.View
{
    partial class frmCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarProduto));
            this.pnMenuVertical = new System.Windows.Forms.Panel();
            this.pnItemsMenuVertical = new System.Windows.Forms.Panel();
            this.bntSair = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnControleEconomico = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnPVD = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lsvProdutos = new System.Windows.Forms.ListView();
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTItulo = new System.Windows.Forms.Label();
            this.picRestaurar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picExpandir = new System.Windows.Forms.PictureBox();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.pnMenuVertical.SuspendLayout();
            this.pnItemsMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbProduto.SuspendLayout();
            this.pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuVertical
            // 
            this.pnMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.pnMenuVertical.Controls.Add(this.pnItemsMenuVertical);
            this.pnMenuVertical.Controls.Add(this.pictureBox1);
            this.pnMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnMenuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.pnMenuVertical.Name = "pnMenuVertical";
            this.pnMenuVertical.Size = new System.Drawing.Size(170, 520);
            this.pnMenuVertical.TabIndex = 2;
            // 
            // pnItemsMenuVertical
            // 
            this.pnItemsMenuVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnItemsMenuVertical.Controls.Add(this.bntSair);
            this.pnItemsMenuVertical.Controls.Add(this.btnProdutos);
            this.pnItemsMenuVertical.Controls.Add(this.btnControleEconomico);
            this.pnItemsMenuVertical.Controls.Add(this.btnEstoque);
            this.pnItemsMenuVertical.Controls.Add(this.btnPVD);
            this.pnItemsMenuVertical.Controls.Add(this.btnCaixa);
            this.pnItemsMenuVertical.Controls.Add(this.btnDashboard);
            this.pnItemsMenuVertical.Location = new System.Drawing.Point(0, 131);
            this.pnItemsMenuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.pnItemsMenuVertical.Name = "pnItemsMenuVertical";
            this.pnItemsMenuVertical.Size = new System.Drawing.Size(170, 389);
            this.pnItemsMenuVertical.TabIndex = 3;
            // 
            // bntSair
            // 
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bntSair.FlatAppearance.BorderSize = 0;
            this.bntSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.bntSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.bntSair.Image = ((System.Drawing.Image)(resources.GetObject("bntSair.Image")));
            this.bntSair.Location = new System.Drawing.Point(0, 343);
            this.bntSair.Margin = new System.Windows.Forms.Padding(2);
            this.bntSair.Name = "bntSair";
            this.bntSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bntSair.Size = new System.Drawing.Size(170, 46);
            this.bntSair.TabIndex = 11;
            this.bntSair.Text = "Logout";
            this.bntSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.Location = new System.Drawing.Point(0, 230);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProdutos.Size = new System.Drawing.Size(170, 46);
            this.btnProdutos.TabIndex = 10;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnControleEconomico
            // 
            this.btnControleEconomico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControleEconomico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControleEconomico.FlatAppearance.BorderSize = 0;
            this.btnControleEconomico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnControleEconomico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleEconomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleEconomico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.btnControleEconomico.Image = ((System.Drawing.Image)(resources.GetObject("btnControleEconomico.Image")));
            this.btnControleEconomico.Location = new System.Drawing.Point(0, 184);
            this.btnControleEconomico.Margin = new System.Windows.Forms.Padding(2);
            this.btnControleEconomico.Name = "btnControleEconomico";
            this.btnControleEconomico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnControleEconomico.Size = new System.Drawing.Size(170, 46);
            this.btnControleEconomico.TabIndex = 9;
            this.btnControleEconomico.Text = "Economico";
            this.btnControleEconomico.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnControleEconomico.UseVisualStyleBackColor = true;
            this.btnControleEconomico.Click += new System.EventHandler(this.btnControleEconomico_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(0, 138);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEstoque.Size = new System.Drawing.Size(170, 46);
            this.btnEstoque.TabIndex = 8;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnPVD
            // 
            this.btnPVD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPVD.FlatAppearance.BorderSize = 0;
            this.btnPVD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnPVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPVD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.btnPVD.Image = ((System.Drawing.Image)(resources.GetObject("btnPVD.Image")));
            this.btnPVD.Location = new System.Drawing.Point(0, 92);
            this.btnPVD.Margin = new System.Windows.Forms.Padding(2);
            this.btnPVD.Name = "btnPVD";
            this.btnPVD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPVD.Size = new System.Drawing.Size(170, 46);
            this.btnPVD.TabIndex = 7;
            this.btnPVD.Text = "Area PDV";
            this.btnPVD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPVD.UseVisualStyleBackColor = true;
            this.btnPVD.Click += new System.EventHandler(this.btnPVD_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.btnCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnCaixa.Image")));
            this.btnCaixa.Location = new System.Drawing.Point(0, 46);
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCaixa.Size = new System.Drawing.Size(170, 46);
            this.btnCaixa.TabIndex = 6;
            this.btnCaixa.Text = "Info Caixa";
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDashboard.Size = new System.Drawing.Size(170, 46);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.lblStatus);
            this.grbProduto.Controls.Add(this.btnCadastrar);
            this.grbProduto.Controls.Add(this.txt_quantidade);
            this.grbProduto.Controls.Add(this.lblQuantidade);
            this.grbProduto.Controls.Add(this.txt_preco);
            this.grbProduto.Controls.Add(this.lblPreco);
            this.grbProduto.Controls.Add(this.txt_nome);
            this.grbProduto.Controls.Add(this.lblNome);
            this.grbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProduto.Location = new System.Drawing.Point(183, 45);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(805, 207);
            this.grbProduto.TabIndex = 3;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "Produto";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStatus.Location = new System.Drawing.Point(10, 170);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 26);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "STATUS:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(408, 124);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(383, 33);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(15, 125);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(376, 32);
            this.txt_quantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(11, 102);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(407, 61);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(384, 32);
            this.txt_preco.TabIndex = 2;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(403, 38);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(14, 61);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(376, 32);
            this.txt_nome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(10, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lsvProdutos
            // 
            this.lsvProdutos.HideSelection = false;
            this.lsvProdutos.Location = new System.Drawing.Point(183, 274);
            this.lsvProdutos.Name = "lsvProdutos";
            this.lsvProdutos.Size = new System.Drawing.Size(805, 234);
            this.lsvProdutos.TabIndex = 4;
            this.lsvProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // pnBarraTitulo
            // 
            this.pnBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(122)))), ((int)(((byte)(123)))));
            this.pnBarraTitulo.Controls.Add(this.lblTItulo);
            this.pnBarraTitulo.Controls.Add(this.picRestaurar);
            this.pnBarraTitulo.Controls.Add(this.picMinimizar);
            this.pnBarraTitulo.Controls.Add(this.picExpandir);
            this.pnBarraTitulo.Controls.Add(this.picFechar);
            this.pnBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraTitulo.Location = new System.Drawing.Point(170, 0);
            this.pnBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnBarraTitulo.Name = "pnBarraTitulo";
            this.pnBarraTitulo.Size = new System.Drawing.Size(830, 29);
            this.pnBarraTitulo.TabIndex = 25;
            // 
            // lblTItulo
            // 
            this.lblTItulo.AutoSize = true;
            this.lblTItulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItulo.Location = new System.Drawing.Point(5, 5);
            this.lblTItulo.Name = "lblTItulo";
            this.lblTItulo.Size = new System.Drawing.Size(124, 17);
            this.lblTItulo.TabIndex = 6;
            this.lblTItulo.Text = "Cadastrar Produto";
            // 
            // picRestaurar
            // 
            this.picRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("picRestaurar.Image")));
            this.picRestaurar.Location = new System.Drawing.Point(780, 4);
            this.picRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.picRestaurar.Name = "picRestaurar";
            this.picRestaurar.Size = new System.Drawing.Size(20, 20);
            this.picRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRestaurar.TabIndex = 5;
            this.picRestaurar.TabStop = false;
            this.picRestaurar.Visible = false;
            this.picRestaurar.Click += new System.EventHandler(this.picRestaurar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(756, 5);
            this.picMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(20, 20);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 4;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click_1);
            // 
            // picExpandir
            // 
            this.picExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExpandir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExpandir.Image = ((System.Drawing.Image)(resources.GetObject("picExpandir.Image")));
            this.picExpandir.Location = new System.Drawing.Point(780, 5);
            this.picExpandir.Margin = new System.Windows.Forms.Padding(2);
            this.picExpandir.Name = "picExpandir";
            this.picExpandir.Size = new System.Drawing.Size(20, 20);
            this.picExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExpandir.TabIndex = 3;
            this.picExpandir.TabStop = false;
            this.picExpandir.Click += new System.EventHandler(this.picExpandir_Click_1);
            // 
            // picFechar
            // 
            this.picFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFechar.Image = ((System.Drawing.Image)(resources.GetObject("picFechar.Image")));
            this.picFechar.Location = new System.Drawing.Point(804, 5);
            this.picFechar.Margin = new System.Windows.Forms.Padding(2);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(20, 20);
            this.picFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFechar.TabIndex = 2;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click_1);
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.pnBarraTitulo);
            this.Controls.Add(this.lsvProdutos);
            this.Controls.Add(this.grbProduto);
            this.Controls.Add(this.pnMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarProduto";
            this.pnMenuVertical.ResumeLayout(false);
            this.pnItemsMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbProduto.ResumeLayout(false);
            this.grbProduto.PerformLayout();
            this.pnBarraTitulo.ResumeLayout(false);
            this.pnBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMenuVertical;
        private System.Windows.Forms.Panel pnItemsMenuVertical;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnControleEconomico;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnPVD;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView lsvProdutos;
        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.PictureBox picRestaurar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picExpandir;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.Label lblTItulo;
    }
}