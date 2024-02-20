namespace atv11
{
    partial class Cadastro
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
            label1 = new Label();
            Cnpj = new MaskedTextBox();
            label2 = new Label();
            RazaoSocial = new TextBox();
            label3 = new Label();
            SituacaoCadastral = new ComboBox();
            label4 = new Label();
            SimplesNacional = new RadioButton();
            LucroPresumido = new RadioButton();
            LucroReal = new RadioButton();
            label5 = new Label();
            DataInicio = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            telefone = new Label();
            label6 = new Label();
            CapitalSocial = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            Ruaa = new TextBox();
            Numeroo = new TextBox();
            Bairroo = new TextBox();
            Cepp = new TextBox();
            Cidadee = new TextBox();
            Estadoo = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            Matriz = new RadioButton();
            Filial = new RadioButton();
            label16 = new Label();
            Pequeno = new RadioButton();
            Medio = new RadioButton();
            Grande = new RadioButton();
            label17 = new Label();
            NaturezaPolitica = new ComboBox();
            label18 = new Label();
            label19 = new Label();
            NomeProprietario = new TextBox();
            CpfProprietario = new MaskedTextBox();
            button1 = new Button();
            label20 = new Label();
            NomeFantasia = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 122);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Cnpj:";
            // 
            // Cnpj
            // 
            Cnpj.Location = new Point(68, 119);
            Cnpj.Mask = " XX. XXX. XXX/0001-XX";
            Cnpj.Name = "Cnpj";
            Cnpj.Size = new Size(100, 23);
            Cnpj.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 162);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Razao Social";
            // 
            // RazaoSocial
            // 
            RazaoSocial.Location = new Point(105, 159);
            RazaoSocial.Name = "RazaoSocial";
            RazaoSocial.Size = new Size(100, 23);
            RazaoSocial.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 207);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 4;
            label3.Text = "situação cadastral";
            // 
            // SituacaoCadastral
            // 
            SituacaoCadastral.FormattingEnabled = true;
            SituacaoCadastral.Items.AddRange(new object[] { "Ativa", "Nula", "Suspensa", "Inapta", "Baixada" });
            SituacaoCadastral.Location = new Point(134, 204);
            SituacaoCadastral.Name = "SituacaoCadastral";
            SituacaoCadastral.Size = new Size(121, 23);
            SituacaoCadastral.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 246);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "regime tributario:";
            // 
            // SimplesNacional
            // 
            SimplesNacional.AutoSize = true;
            SimplesNacional.Location = new Point(0, 41);
            SimplesNacional.Name = "SimplesNacional";
            SimplesNacional.Size = new Size(113, 19);
            SimplesNacional.TabIndex = 7;
            SimplesNacional.TabStop = true;
            SimplesNacional.Text = "simples nacional";
            SimplesNacional.UseVisualStyleBackColor = true;
            // 
            // LucroPresumido
            // 
            LucroPresumido.AutoSize = true;
            LucroPresumido.Location = new Point(125, 40);
            LucroPresumido.Name = "LucroPresumido";
            LucroPresumido.Size = new Size(112, 19);
            LucroPresumido.TabIndex = 8;
            LucroPresumido.TabStop = true;
            LucroPresumido.Text = "lucro presumido";
            LucroPresumido.UseVisualStyleBackColor = true;
            // 
            // LucroReal
            // 
            LucroReal.AutoSize = true;
            LucroReal.Location = new Point(243, 40);
            LucroReal.Name = "LucroReal";
            LucroReal.Size = new Size(74, 19);
            LucroReal.TabIndex = 9;
            LucroReal.TabStop = true;
            LucroReal.Text = "lucro real";
            LucroReal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 349);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 10;
            label5.Text = "data inicio";
            // 
            // DataInicio
            // 
            DataInicio.Location = new Point(95, 346);
            DataInicio.Mask = "00/00/0000";
            DataInicio.Name = "DataInicio";
            DataInicio.Size = new Size(100, 23);
            DataInicio.TabIndex = 11;
            DataInicio.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(95, 390);
            maskedTextBox3.Mask = "(99)0 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 12;
            // 
            // telefone
            // 
            telefone.AutoSize = true;
            telefone.Location = new Point(27, 393);
            telefone.Name = "telefone";
            telefone.Size = new Size(50, 15);
            telefone.TabIndex = 13;
            telefone.Text = "telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 436);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 14;
            label6.Text = "capital social";
            // 
            // CapitalSocial
            // 
            CapitalSocial.Location = new Point(108, 433);
            CapitalSocial.Name = "CapitalSocial";
            CapitalSocial.Size = new Size(100, 23);
            CapitalSocial.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 484);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 16;
            label7.Text = "endereço";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 529);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 17;
            label8.Text = "rua";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(220, 529);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 18;
            label9.Text = "numero";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 558);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 19;
            label10.Text = "bairro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(229, 558);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 20;
            label11.Text = "cep";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 598);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 21;
            label12.Text = "cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(225, 598);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 22;
            label13.Text = "estado";
            // 
            // Ruaa
            // 
            Ruaa.Location = new Point(57, 526);
            Ruaa.Name = "Ruaa";
            Ruaa.Size = new Size(100, 23);
            Ruaa.TabIndex = 23;
            // 
            // Numeroo
            // 
            Numeroo.Location = new Point(275, 526);
            Numeroo.Name = "Numeroo";
            Numeroo.Size = new Size(100, 23);
            Numeroo.TabIndex = 24;
            // 
            // Bairroo
            // 
            Bairroo.Location = new Point(71, 555);
            Bairroo.Name = "Bairroo";
            Bairroo.Size = new Size(100, 23);
            Bairroo.TabIndex = 25;
            // 
            // Cepp
            // 
            Cepp.Location = new Point(261, 555);
            Cepp.Name = "Cepp";
            Cepp.Size = new Size(100, 23);
            Cepp.TabIndex = 26;
            // 
            // Cidadee
            // 
            Cidadee.Location = new Point(71, 595);
            Cidadee.Name = "Cidadee";
            Cidadee.Size = new Size(100, 23);
            Cidadee.TabIndex = 27;
            // 
            // Estadoo
            // 
            Estadoo.FormattingEnabled = true;
            Estadoo.Items.AddRange(new object[] { "Acre\tAC\t", "Alagoas\tAL\t", "Amapá\tAP\t", "Amazonas\tAM\t", "Bahia\tBA\t", "Ceará\tCE\t", "Espírito Santo  ES\t", "Goiás\tGO\t", "Maranhão\tMA\t", "Mato Grosso\tMT\t", "Mato Grosso do Sul\tMS\t", "Minas Gerais\tMG\t", "Pará\tPA\t", "Paraíba\tPB\t", "Paraná\tPR\t", "Pernambuco\tPE\t", "Piauí\tPI\t", "Rio de Janeiro\tRJ\t", "Rio Grande do Norte\tRN\t", "Rio Grande do Sul\tRS\t", "Rondônia\tRO\t", "Roraima\tRR\t", "Santa Catarina\tSC\t", "São Paulo\tSP\t", "Sergipe\tSE\t", "Tocantins  TO" });
            Estadoo.Location = new Point(273, 595);
            Estadoo.Name = "Estadoo";
            Estadoo.Size = new Size(121, 23);
            Estadoo.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(273, 36);
            label14.Name = "label14";
            label14.Size = new Size(116, 15);
            label14.TabIndex = 29;
            label14.Text = "cadastro de empresa";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(521, 120);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 30;
            label15.Text = "tipo";
            // 
            // Matriz
            // 
            Matriz.AutoSize = true;
            Matriz.Location = new Point(555, 118);
            Matriz.Name = "Matriz";
            Matriz.Size = new Size(58, 19);
            Matriz.TabIndex = 31;
            Matriz.TabStop = true;
            Matriz.Text = "Matriz";
            Matriz.UseVisualStyleBackColor = true;
            // 
            // Filial
            // 
            Filial.AutoSize = true;
            Filial.Location = new Point(655, 119);
            Filial.Name = "Filial";
            Filial.Size = new Size(49, 19);
            Filial.TabIndex = 32;
            Filial.TabStop = true;
            Filial.Text = "Filial";
            Filial.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(521, 162);
            label16.Name = "label16";
            label16.Size = new Size(99, 15);
            label16.TabIndex = 33;
            label16.Text = "Porte de empresa";
            // 
            // Pequeno
            // 
            Pequeno.AutoSize = true;
            Pequeno.Location = new Point(-11, 41);
            Pequeno.Name = "Pequeno";
            Pequeno.Size = new Size(72, 19);
            Pequeno.TabIndex = 34;
            Pequeno.TabStop = true;
            Pequeno.Text = "pequeno";
            Pequeno.UseVisualStyleBackColor = true;
            // 
            // Medio
            // 
            Medio.AutoSize = true;
            Medio.Location = new Point(67, 41);
            Medio.Name = "Medio";
            Medio.Size = new Size(59, 19);
            Medio.TabIndex = 35;
            Medio.TabStop = true;
            Medio.Text = "medio";
            Medio.UseVisualStyleBackColor = true;
            // 
            // Grande
            // 
            Grande.AutoSize = true;
            Grande.Location = new Point(132, 40);
            Grande.Name = "Grande";
            Grande.Size = new Size(62, 19);
            Grande.TabIndex = 36;
            Grande.TabStop = true;
            Grande.Text = "grande";
            Grande.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(521, 204);
            label17.Name = "label17";
            label17.Size = new Size(94, 15);
            label17.TabIndex = 37;
            label17.Text = "natureza Politica";
            // 
            // NaturezaPolitica
            // 
            NaturezaPolitica.FormattingEnabled = true;
            NaturezaPolitica.Items.AddRange(new object[] { "EI - Empresario Individual", "MEI - Microeemprendedor", "Sociedade Anonima" });
            NaturezaPolitica.Location = new Point(626, 204);
            NaturezaPolitica.Name = "NaturezaPolitica";
            NaturezaPolitica.Size = new Size(121, 23);
            NaturezaPolitica.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(521, 250);
            label18.Name = "label18";
            label18.Size = new Size(120, 15);
            label18.TabIndex = 39;
            label18.Text = "nome do proprietario";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(535, 288);
            label19.Name = "label19";
            label19.Size = new Size(106, 15);
            label19.TabIndex = 40;
            label19.Text = "cpf do proprietario";
            // 
            // NomeProprietario
            // 
            NomeProprietario.Location = new Point(647, 244);
            NomeProprietario.Name = "NomeProprietario";
            NomeProprietario.Size = new Size(100, 23);
            NomeProprietario.TabIndex = 41;
            // 
            // CpfProprietario
            // 
            CpfProprietario.Location = new Point(640, 280);
            CpfProprietario.Mask = "000-000-000-00";
            CpfProprietario.Name = "CpfProprietario";
            CpfProprietario.Size = new Size(100, 23);
            CpfProprietario.TabIndex = 42;
            // 
            // button1
            // 
            button1.Location = new Point(410, 630);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 43;
            button1.Text = "Cadastrar Empresa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(27, 82);
            label20.Name = "label20";
            label20.Size = new Size(86, 15);
            label20.TabIndex = 44;
            label20.Text = "Nome Fantasia";
            // 
            // NomeFantasia
            // 
            NomeFantasia.Location = new Point(119, 82);
            NomeFantasia.Name = "NomeFantasia";
            NomeFantasia.Size = new Size(100, 23);
            NomeFantasia.TabIndex = 45;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Grande);
            groupBox1.Controls.Add(Pequeno);
            groupBox1.Controls.Add(Medio);
            groupBox1.Location = new Point(716, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 60);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SimplesNacional);
            groupBox2.Controls.Add(LucroPresumido);
            groupBox2.Controls.Add(LucroReal);
            groupBox2.Location = new Point(134, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 74);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 690);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(NomeFantasia);
            Controls.Add(label20);
            Controls.Add(button1);
            Controls.Add(CpfProprietario);
            Controls.Add(NomeProprietario);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(NaturezaPolitica);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(Filial);
            Controls.Add(Matriz);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(Estadoo);
            Controls.Add(Cidadee);
            Controls.Add(Cepp);
            Controls.Add(Bairroo);
            Controls.Add(Numeroo);
            Controls.Add(Ruaa);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(CapitalSocial);
            Controls.Add(label6);
            Controls.Add(telefone);
            Controls.Add(maskedTextBox3);
            Controls.Add(DataInicio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(SituacaoCadastral);
            Controls.Add(label3);
            Controls.Add(RazaoSocial);
            Controls.Add(label2);
            Controls.Add(Cnpj);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox Cnpj;
        private Label label2;
        private TextBox RazaoSocial;
        private Label label3;
        private ComboBox SituacaoCadastral;
        private Label label4;
        private RadioButton SimplesNacional;
        private RadioButton LucroPresumido;
        private RadioButton LucroReal;
        private Label label5;
        private MaskedTextBox DataInicio;
        private MaskedTextBox maskedTextBox3;
        private Label telefone;
        private Label label6;
        private TextBox CapitalSocial;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox Ruaa;
        private TextBox Numeroo;
        private TextBox Bairroo;
        private TextBox Cepp;
        private TextBox Cidadee;
        private ComboBox Estadoo;
        private Label label14;
        private Label label15;
        private RadioButton Matriz;
        private RadioButton Filial;
        private Label label16;
        private RadioButton Pequeno;
        private RadioButton Medio;
        private RadioButton Grande;
        private Label label17;
        private ComboBox NaturezaPolitica;
        private Label label18;
        private Label label19;
        private TextBox NomeProprietario;
        private MaskedTextBox CpfProprietario;
        private Button button1;
        private Label label20;
        private TextBox NomeFantasia;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}