﻿namespace Leoplastic
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_ordem = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt_expedicao = new System.Windows.Forms.RadioButton();
            this.rbt_corte = new System.Windows.Forms.RadioButton();
            this.rbt_rebobinadeira = new System.Windows.Forms.RadioButton();
            this.rbt_extrusora = new System.Windows.Forms.RadioButton();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_termino = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_operador = new System.Windows.Forms.ComboBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_densidade2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_densidade1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_corte2 = new System.Windows.Forms.RadioButton();
            this.rbt_corte1 = new System.Windows.Forms.RadioButton();
            this.rbt_rebobinadeira2 = new System.Windows.Forms.RadioButton();
            this.rbt_rebobinadeira1 = new System.Windows.Forms.RadioButton();
            this.rbt_extrusora3 = new System.Windows.Forms.RadioButton();
            this.rbt_extrusora2 = new System.Windows.Forms.RadioButton();
            this.rbt_extrusora1 = new System.Windows.Forms.RadioButton();
            this.txt_termino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_inicio = new System.Windows.Forms.TextBox();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.dtp_apontamento = new System.Windows.Forms.DateTimePicker();
            this.lbl_data = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_export_Excel = new System.Windows.Forms.Button();
            this.btn_gantt = new System.Windows.Forms.Button();
            this.btn_listagem = new System.Windows.Forms.Button();
            this.btn_extrusora = new System.Windows.Forms.Button();
            this.btn_rebobinadeira = new System.Windows.Forms.Button();
            this.btn_corte = new System.Windows.Forms.Button();
            this.btn_expedicao = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbx_ordem);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.btn_cadastrar);
            this.panel3.Controls.Add(this.btn_termino);
            this.panel3.Controls.Add(this.btn_inicio);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cbx_operador);
            this.panel3.Controls.Add(this.txt_peso);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_densidade2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_densidade1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_produto);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.txt_termino);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_inicio);
            this.panel3.Controls.Add(this.lbl_inicio);
            this.panel3.Controls.Add(this.dtp_apontamento);
            this.panel3.Controls.Add(this.lbl_data);
            this.panel3.Location = new System.Drawing.Point(231, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 532);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ordem";
            // 
            // cbx_ordem
            // 
            this.cbx_ordem.FormattingEnabled = true;
            this.cbx_ordem.Location = new System.Drawing.Point(369, 10);
            this.cbx_ordem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_ordem.Name = "cbx_ordem";
            this.cbx_ordem.Size = new System.Drawing.Size(224, 21);
            this.cbx_ordem.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_expedicao);
            this.groupBox2.Controls.Add(this.rbt_corte);
            this.groupBox2.Controls.Add(this.rbt_rebobinadeira);
            this.groupBox2.Controls.Add(this.rbt_extrusora);
            this.groupBox2.Location = new System.Drawing.Point(19, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 71);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processo";
            // 
            // rbt_expedicao
            // 
            this.rbt_expedicao.AutoSize = true;
            this.rbt_expedicao.Location = new System.Drawing.Point(324, 29);
            this.rbt_expedicao.Name = "rbt_expedicao";
            this.rbt_expedicao.Size = new System.Drawing.Size(75, 17);
            this.rbt_expedicao.TabIndex = 3;
            this.rbt_expedicao.TabStop = true;
            this.rbt_expedicao.Text = "Expedição";
            this.rbt_expedicao.UseVisualStyleBackColor = true;
            // 
            // rbt_corte
            // 
            this.rbt_corte.AutoSize = true;
            this.rbt_corte.Location = new System.Drawing.Point(233, 29);
            this.rbt_corte.Name = "rbt_corte";
            this.rbt_corte.Size = new System.Drawing.Size(50, 17);
            this.rbt_corte.TabIndex = 2;
            this.rbt_corte.TabStop = true;
            this.rbt_corte.Text = "Corte";
            this.rbt_corte.UseVisualStyleBackColor = true;
            // 
            // rbt_rebobinadeira
            // 
            this.rbt_rebobinadeira.AutoSize = true;
            this.rbt_rebobinadeira.Location = new System.Drawing.Point(118, 29);
            this.rbt_rebobinadeira.Name = "rbt_rebobinadeira";
            this.rbt_rebobinadeira.Size = new System.Drawing.Size(94, 17);
            this.rbt_rebobinadeira.TabIndex = 1;
            this.rbt_rebobinadeira.TabStop = true;
            this.rbt_rebobinadeira.Text = "Rebobinadeira";
            this.rbt_rebobinadeira.UseVisualStyleBackColor = true;
            // 
            // rbt_extrusora
            // 
            this.rbt_extrusora.AutoSize = true;
            this.rbt_extrusora.Location = new System.Drawing.Point(15, 29);
            this.rbt_extrusora.Name = "rbt_extrusora";
            this.rbt_extrusora.Size = new System.Drawing.Size(69, 17);
            this.rbt_extrusora.TabIndex = 0;
            this.rbt_extrusora.TabStop = true;
            this.rbt_extrusora.Text = "Extrusora";
            this.rbt_extrusora.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(400, 370);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(193, 72);
            this.btn_cadastrar.TabIndex = 20;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_termino
            // 
            this.btn_termino.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_termino.Location = new System.Drawing.Point(201, 370);
            this.btn_termino.Name = "btn_termino";
            this.btn_termino.Size = new System.Drawing.Size(193, 72);
            this.btn_termino.TabIndex = 19;
            this.btn_termino.Text = "Término";
            this.btn_termino.UseVisualStyleBackColor = true;
            this.btn_termino.Click += new System.EventHandler(this.btn_termino_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(3, 370);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(193, 72);
            this.btn_inicio.TabIndex = 18;
            this.btn_inicio.Text = "Início";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Operador";
            // 
            // cbx_operador
            // 
            this.cbx_operador.FormattingEnabled = true;
            this.cbx_operador.Location = new System.Drawing.Point(78, 343);
            this.cbx_operador.Name = "cbx_operador";
            this.cbx_operador.Size = new System.Drawing.Size(118, 21);
            this.cbx_operador.TabIndex = 16;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(78, 317);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(118, 20);
            this.txt_peso.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Peso";
            // 
            // txt_densidade2
            // 
            this.txt_densidade2.Location = new System.Drawing.Point(369, 321);
            this.txt_densidade2.Name = "txt_densidade2";
            this.txt_densidade2.Size = new System.Drawing.Size(53, 20);
            this.txt_densidade2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            // 
            // txt_densidade1
            // 
            this.txt_densidade1.Location = new System.Drawing.Point(282, 321);
            this.txt_densidade1.Name = "txt_densidade1";
            this.txt_densidade1.Size = new System.Drawing.Size(53, 20);
            this.txt_densidade1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Variação da densidade";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(78, 291);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(118, 20);
            this.txt_produto.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_corte2);
            this.groupBox1.Controls.Add(this.rbt_corte1);
            this.groupBox1.Controls.Add(this.rbt_rebobinadeira2);
            this.groupBox1.Controls.Add(this.rbt_rebobinadeira1);
            this.groupBox1.Controls.Add(this.rbt_extrusora3);
            this.groupBox1.Controls.Add(this.rbt_extrusora2);
            this.groupBox1.Controls.Add(this.rbt_extrusora1);
            this.groupBox1.Location = new System.Drawing.Point(19, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Máquina";
            // 
            // rbt_corte2
            // 
            this.rbt_corte2.AutoSize = true;
            this.rbt_corte2.Location = new System.Drawing.Point(324, 53);
            this.rbt_corte2.Name = "rbt_corte2";
            this.rbt_corte2.Size = new System.Drawing.Size(59, 17);
            this.rbt_corte2.TabIndex = 6;
            this.rbt_corte2.TabStop = true;
            this.rbt_corte2.Text = "Corte 2";
            this.rbt_corte2.UseVisualStyleBackColor = true;
            // 
            // rbt_corte1
            // 
            this.rbt_corte1.AutoSize = true;
            this.rbt_corte1.Location = new System.Drawing.Point(324, 20);
            this.rbt_corte1.Name = "rbt_corte1";
            this.rbt_corte1.Size = new System.Drawing.Size(59, 17);
            this.rbt_corte1.TabIndex = 5;
            this.rbt_corte1.TabStop = true;
            this.rbt_corte1.Text = "Corte 1";
            this.rbt_corte1.UseVisualStyleBackColor = true;
            // 
            // rbt_rebobinadeira2
            // 
            this.rbt_rebobinadeira2.AutoSize = true;
            this.rbt_rebobinadeira2.Location = new System.Drawing.Point(173, 53);
            this.rbt_rebobinadeira2.Name = "rbt_rebobinadeira2";
            this.rbt_rebobinadeira2.Size = new System.Drawing.Size(103, 17);
            this.rbt_rebobinadeira2.TabIndex = 4;
            this.rbt_rebobinadeira2.TabStop = true;
            this.rbt_rebobinadeira2.Text = "Rebobinadeira 2";
            this.rbt_rebobinadeira2.UseVisualStyleBackColor = true;
            // 
            // rbt_rebobinadeira1
            // 
            this.rbt_rebobinadeira1.AutoSize = true;
            this.rbt_rebobinadeira1.Location = new System.Drawing.Point(173, 20);
            this.rbt_rebobinadeira1.Name = "rbt_rebobinadeira1";
            this.rbt_rebobinadeira1.Size = new System.Drawing.Size(103, 17);
            this.rbt_rebobinadeira1.TabIndex = 3;
            this.rbt_rebobinadeira1.TabStop = true;
            this.rbt_rebobinadeira1.Text = "Rebobinadeira 1";
            this.rbt_rebobinadeira1.UseVisualStyleBackColor = true;
            // 
            // rbt_extrusora3
            // 
            this.rbt_extrusora3.AutoSize = true;
            this.rbt_extrusora3.Location = new System.Drawing.Point(25, 86);
            this.rbt_extrusora3.Name = "rbt_extrusora3";
            this.rbt_extrusora3.Size = new System.Drawing.Size(78, 17);
            this.rbt_extrusora3.TabIndex = 2;
            this.rbt_extrusora3.TabStop = true;
            this.rbt_extrusora3.Text = "Extrusora 3";
            this.rbt_extrusora3.UseVisualStyleBackColor = true;
            // 
            // rbt_extrusora2
            // 
            this.rbt_extrusora2.AutoSize = true;
            this.rbt_extrusora2.Location = new System.Drawing.Point(25, 53);
            this.rbt_extrusora2.Name = "rbt_extrusora2";
            this.rbt_extrusora2.Size = new System.Drawing.Size(78, 17);
            this.rbt_extrusora2.TabIndex = 1;
            this.rbt_extrusora2.TabStop = true;
            this.rbt_extrusora2.Text = "Extrusora 2";
            this.rbt_extrusora2.UseVisualStyleBackColor = true;
            // 
            // rbt_extrusora1
            // 
            this.rbt_extrusora1.AutoSize = true;
            this.rbt_extrusora1.Location = new System.Drawing.Point(25, 20);
            this.rbt_extrusora1.Name = "rbt_extrusora1";
            this.rbt_extrusora1.Size = new System.Drawing.Size(78, 17);
            this.rbt_extrusora1.TabIndex = 0;
            this.rbt_extrusora1.TabStop = true;
            this.rbt_extrusora1.Text = "Extrusora 1";
            this.rbt_extrusora1.UseVisualStyleBackColor = true;
            // 
            // txt_termino
            // 
            this.txt_termino.Location = new System.Drawing.Point(369, 38);
            this.txt_termino.Name = "txt_termino";
            this.txt_termino.Size = new System.Drawing.Size(224, 20);
            this.txt_termino.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Termino";
            // 
            // txt_inicio
            // 
            this.txt_inicio.Location = new System.Drawing.Point(78, 38);
            this.txt_inicio.Name = "txt_inicio";
            this.txt_inicio.Size = new System.Drawing.Size(200, 20);
            this.txt_inicio.TabIndex = 3;
            this.txt_inicio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(31, 42);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(34, 13);
            this.lbl_inicio.TabIndex = 2;
            this.lbl_inicio.Text = "Início";
            this.lbl_inicio.Click += new System.EventHandler(this.lbl_inicio_Click);
            // 
            // dtp_apontamento
            // 
            this.dtp_apontamento.Location = new System.Drawing.Point(78, 12);
            this.dtp_apontamento.Name = "dtp_apontamento";
            this.dtp_apontamento.Size = new System.Drawing.Size(200, 20);
            this.dtp_apontamento.TabIndex = 1;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(33, 16);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(30, 13);
            this.lbl_data.TabIndex = 0;
            this.lbl_data.Text = "Data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = global::Leoplastic.Properties.Resources.Leoplastic_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 105);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(2, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 69);
            this.button2.TabIndex = 0;
            this.button2.Text = "Inserir Apontamento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 107);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btn_expedicao);
            this.panel2.Controls.Add(this.btn_corte);
            this.panel2.Controls.Add(this.btn_rebobinadeira);
            this.panel2.Controls.Add(this.btn_extrusora);
            this.panel2.Controls.Add(this.btn_listagem);
            this.panel2.Controls.Add(this.btn_export_Excel);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_gantt);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 638);
            this.panel2.TabIndex = 11;
            // 
            // btn_export_Excel
            // 
            this.btn_export_Excel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_export_Excel.BackgroundImage")));
            this.btn_export_Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_export_Excel.Location = new System.Drawing.Point(166, 178);
            this.btn_export_Excel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_export_Excel.Name = "btn_export_Excel";
            this.btn_export_Excel.Size = new System.Drawing.Size(38, 39);
            this.btn_export_Excel.TabIndex = 12;
            this.btn_export_Excel.UseVisualStyleBackColor = true;
            this.btn_export_Excel.Visible = false;
            this.btn_export_Excel.Click += new System.EventHandler(this.btn_export_Excel_Click);
            // 
            // btn_gantt
            // 
            this.btn_gantt.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gantt.Location = new System.Drawing.Point(2, 523);
            this.btn_gantt.Name = "btn_gantt";
            this.btn_gantt.Size = new System.Drawing.Size(162, 69);
            this.btn_gantt.TabIndex = 8;
            this.btn_gantt.Text = "Gráficos";
            this.btn_gantt.UseVisualStyleBackColor = true;
            this.btn_gantt.Click += new System.EventHandler(this.btn_gantt_Click);
            // 
            // btn_listagem
            // 
            this.btn_listagem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_listagem.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listagem.Location = new System.Drawing.Point(2, 178);
            this.btn_listagem.Name = "btn_listagem";
            this.btn_listagem.Size = new System.Drawing.Size(162, 69);
            this.btn_listagem.TabIndex = 13;
            this.btn_listagem.Text = "Listagem Geral";
            this.btn_listagem.UseVisualStyleBackColor = true;
            this.btn_listagem.Click += new System.EventHandler(this.btn_listagem_Click);
            // 
            // btn_extrusora
            // 
            this.btn_extrusora.BackColor = System.Drawing.SystemColors.Control;
            this.btn_extrusora.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_extrusora.Location = new System.Drawing.Point(2, 247);
            this.btn_extrusora.Name = "btn_extrusora";
            this.btn_extrusora.Size = new System.Drawing.Size(162, 69);
            this.btn_extrusora.TabIndex = 14;
            this.btn_extrusora.Text = "Extrusora";
            this.btn_extrusora.UseVisualStyleBackColor = true;
            this.btn_extrusora.Click += new System.EventHandler(this.btn_extrusora_Click);
            // 
            // btn_rebobinadeira
            // 
            this.btn_rebobinadeira.BackColor = System.Drawing.SystemColors.Control;
            this.btn_rebobinadeira.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rebobinadeira.Location = new System.Drawing.Point(2, 316);
            this.btn_rebobinadeira.Name = "btn_rebobinadeira";
            this.btn_rebobinadeira.Size = new System.Drawing.Size(162, 69);
            this.btn_rebobinadeira.TabIndex = 15;
            this.btn_rebobinadeira.Text = "Rebobinadeira";
            this.btn_rebobinadeira.UseVisualStyleBackColor = true;
            this.btn_rebobinadeira.Click += new System.EventHandler(this.btn_rebobinadeira_Click);
            // 
            // btn_corte
            // 
            this.btn_corte.BackColor = System.Drawing.SystemColors.Control;
            this.btn_corte.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_corte.Location = new System.Drawing.Point(2, 385);
            this.btn_corte.Name = "btn_corte";
            this.btn_corte.Size = new System.Drawing.Size(162, 69);
            this.btn_corte.TabIndex = 16;
            this.btn_corte.Text = "Corte";
            this.btn_corte.UseVisualStyleBackColor = true;
            this.btn_corte.Click += new System.EventHandler(this.btn_corte_Click);
            // 
            // btn_expedicao
            // 
            this.btn_expedicao.BackColor = System.Drawing.SystemColors.Control;
            this.btn_expedicao.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expedicao.Location = new System.Drawing.Point(2, 454);
            this.btn_expedicao.Name = "btn_expedicao";
            this.btn_expedicao.Size = new System.Drawing.Size(162, 69);
            this.btn_expedicao.TabIndex = 17;
            this.btn_expedicao.Text = "Expedição";
            this.btn_expedicao.UseVisualStyleBackColor = true;
            this.btn_expedicao.Click += new System.EventHandler(this.btn_expedicao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "PCP V1.000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_inicio;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.DateTimePicker dtp_apontamento;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_termino;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_operador;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_densidade2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_densidade1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_corte2;
        private System.Windows.Forms.RadioButton rbt_corte1;
        private System.Windows.Forms.RadioButton rbt_rebobinadeira2;
        private System.Windows.Forms.RadioButton rbt_rebobinadeira1;
        private System.Windows.Forms.RadioButton rbt_extrusora3;
        private System.Windows.Forms.RadioButton rbt_extrusora2;
        private System.Windows.Forms.RadioButton rbt_extrusora1;
        private System.Windows.Forms.TextBox txt_termino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbt_extrusora;
        private System.Windows.Forms.RadioButton rbt_expedicao;
        private System.Windows.Forms.RadioButton rbt_corte;
        private System.Windows.Forms.RadioButton rbt_rebobinadeira;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_gantt;
        private System.Windows.Forms.Button btn_export_Excel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_ordem;
        private System.Windows.Forms.Button btn_listagem;
        private System.Windows.Forms.Button btn_expedicao;
        private System.Windows.Forms.Button btn_corte;
        private System.Windows.Forms.Button btn_rebobinadeira;
        private System.Windows.Forms.Button btn_extrusora;
    }
}

