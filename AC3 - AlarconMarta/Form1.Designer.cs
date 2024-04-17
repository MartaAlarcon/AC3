namespace AC3___AlarconMarta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Gestioner = new Label();
            Year = new Label();
            Comarca = new Label();
            Poblation = new Label();
            AnyText = new ComboBox();
            ComarcaText = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            PoblacióText = new TextBox();
            ConsumText = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TotalText = new TextBox();
            ActivitatsText = new TextBox();
            DomésticText = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            LBLCMB = new Label();
            LBLCMA = new Label();
            LBLCM = new Label();
            LBLPoblacio = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            Cuadro = new DataGridView();
            Positive = new ErrorProvider(components);
            Number = new ErrorProvider(components);
            Void = new ErrorProvider(components);
            BTNNext = new Button();
            BTNAfter = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Cuadro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Positive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Number).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Void).BeginInit();
            SuspendLayout();
            // 
            // Gestioner
            // 
            Gestioner.AutoSize = true;
            Gestioner.Location = new Point(25, 51);
            Gestioner.Name = "Gestioner";
            Gestioner.Size = new Size(295, 20);
            Gestioner.TabIndex = 0;
            Gestioner.Text = "Gestió de dades demogràfiques de regions";
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(30, 41);
            Year.Name = "Year";
            Year.Size = new Size(34, 20);
            Year.TabIndex = 1;
            Year.Text = "Any\r\n";
            // 
            // Comarca
            // 
            Comarca.AutoSize = true;
            Comarca.Location = new Point(210, 41);
            Comarca.Name = "Comarca";
            Comarca.Size = new Size(68, 20);
            Comarca.TabIndex = 2;
            Comarca.Text = "Comarca";
            // 
            // Poblation
            // 
            Poblation.AutoSize = true;
            Poblation.Location = new Point(439, 148);
            Poblation.Name = "Poblation";
            Poblation.Size = new Size(74, 20);
            Poblation.TabIndex = 3;
            Poblation.Text = "Población";
            // 
            // AnyText
            // 
            AnyText.DropDownStyle = ComboBoxStyle.DropDownList;
            AnyText.FormattingEnabled = true;
            AnyText.Items.AddRange(new object[] { "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050" });
            AnyText.Location = new Point(30, 65);
            AnyText.Margin = new Padding(3, 4, 3, 4);
            AnyText.Name = "AnyText";
            AnyText.Size = new Size(138, 28);
            AnyText.TabIndex = 4;
            AnyText.Validating += AnyText_Validating;
            // 
            // ComarcaText
            // 
            ComarcaText.DropDownStyle = ComboBoxStyle.DropDownList;
            ComarcaText.FormattingEnabled = true;
            ComarcaText.Location = new Point(210, 65);
            ComarcaText.Margin = new Padding(3, 4, 3, 4);
            ComarcaText.Name = "ComarcaText";
            ComarcaText.Size = new Size(138, 28);
            ComarcaText.TabIndex = 5;
            ComarcaText.Validating += ComarcaText_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 113);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 7;
            label1.Text = "Domèstic xarxa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PoblacióText);
            groupBox1.Controls.Add(ConsumText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TotalText);
            groupBox1.Controls.Add(ComarcaText);
            groupBox1.Controls.Add(Comarca);
            groupBox1.Controls.Add(ActivitatsText);
            groupBox1.Controls.Add(AnyText);
            groupBox1.Controls.Add(DomésticText);
            groupBox1.Controls.Add(Year);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 107);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(697, 305);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // PoblacióText
            // 
            PoblacióText.Location = new Point(425, 67);
            PoblacióText.Margin = new Padding(3, 4, 3, 4);
            PoblacióText.Name = "PoblacióText";
            PoblacióText.Size = new Size(134, 27);
            PoblacióText.TabIndex = 15;
            PoblacióText.Validating += PoblacióText_Validating;
            // 
            // ConsumText
            // 
            ConsumText.Location = new Point(457, 155);
            ConsumText.Margin = new Padding(3, 4, 3, 4);
            ConsumText.Name = "ConsumText";
            ConsumText.Size = new Size(114, 27);
            ConsumText.TabIndex = 11;
            ConsumText.Validating += ConsumText_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 203);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 14;
            label4.Text = "Total\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 132);
            label3.Name = "label3";
            label3.Size = new Size(127, 40);
            label3.TabIndex = 13;
            label3.Text = "Consum domèstic\r\nper càpita\r\n";
            // 
            // TotalText
            // 
            TotalText.Location = new Point(457, 203);
            TotalText.Margin = new Padding(3, 4, 3, 4);
            TotalText.Name = "TotalText";
            TotalText.Size = new Size(114, 27);
            TotalText.TabIndex = 12;
            TotalText.Validating += TotalText_Validating;
            // 
            // ActivitatsText
            // 
            ActivitatsText.Location = new Point(210, 159);
            ActivitatsText.Margin = new Padding(3, 4, 3, 4);
            ActivitatsText.Name = "ActivitatsText";
            ActivitatsText.Size = new Size(114, 27);
            ActivitatsText.TabIndex = 10;
            ActivitatsText.Validating += ActivitatsText_Validating;
            // 
            // DomésticText
            // 
            DomésticText.Location = new Point(30, 159);
            DomésticText.Margin = new Padding(3, 4, 3, 4);
            DomésticText.Name = "DomésticText";
            DomésticText.Size = new Size(114, 27);
            DomésticText.TabIndex = 9;
            DomésticText.Validating += DomésticText_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 113);
            label2.Name = "label2";
            label2.Size = new Size(163, 40);
            label2.TabIndex = 8;
            label2.Text = "Activitats econòmiques\r\ni fonts pròpies";
            // 
            // button1
            // 
            button1.Location = new Point(531, 443);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(422, 443);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 10;
            button2.Text = "Netejar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LBLCMB);
            groupBox2.Controls.Add(LBLCMA);
            groupBox2.Controls.Add(LBLCM);
            groupBox2.Controls.Add(LBLPoblacio);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Location = new Point(731, 113);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(358, 180);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            groupBox2.UseCompatibleTextRendering = true;
            // 
            // LBLCMB
            // 
            LBLCMB.AutoSize = true;
            LBLCMB.ForeColor = Color.RoyalBlue;
            LBLCMB.Location = new Point(277, 150);
            LBLCMB.Name = "LBLCMB";
            LBLCMB.Size = new Size(58, 20);
            LBLCMB.TabIndex = 22;
            LBLCMB.Text = "label14";
            // 
            // LBLCMA
            // 
            LBLCMA.AutoSize = true;
            LBLCMA.ForeColor = Color.RoyalBlue;
            LBLCMA.Location = new Point(266, 109);
            LBLCMA.Name = "LBLCMA";
            LBLCMA.Size = new Size(58, 20);
            LBLCMA.TabIndex = 21;
            LBLCMA.Text = "label13";
            // 
            // LBLCM
            // 
            LBLCM.AutoSize = true;
            LBLCM.ForeColor = Color.RoyalBlue;
            LBLCM.Location = new Point(170, 68);
            LBLCM.Name = "LBLCM";
            LBLCM.Size = new Size(58, 20);
            LBLCM.TabIndex = 20;
            LBLCM.Text = "label12";
            // 
            // LBLPoblacio
            // 
            LBLPoblacio.AutoSize = true;
            LBLPoblacio.ForeColor = Color.RoyalBlue;
            LBLPoblacio.Location = new Point(158, 33);
            LBLPoblacio.Name = "LBLPoblacio";
            LBLPoblacio.Size = new Size(58, 20);
            LBLPoblacio.TabIndex = 19;
            LBLPoblacio.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 151);
            label10.Name = "label10";
            label10.Size = new Size(264, 20);
            label10.TabIndex = 18;
            label10.Text = "Consum domèstic per càpita més baix:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 109);
            label9.Name = "label9";
            label9.Size = new Size(253, 20);
            label9.TabIndex = 17;
            label9.Text = "Consum domèstic per càpita més alt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 68);
            label8.Name = "label8";
            label8.Size = new Size(168, 20);
            label8.TabIndex = 16;
            label8.Text = "Consum domèstic mitjà:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 33);
            label7.Name = "label7";
            label7.Size = new Size(159, 20);
            label7.TabIndex = 15;
            label7.Text = "Població > 20000 hab.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 199);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 14;
            label5.Text = "Total\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(409, 123);
            label6.Name = "label6";
            label6.Size = new Size(127, 40);
            label6.TabIndex = 13;
            label6.Text = "Consum domèstic\r\nper càpita\r\n";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(535, 195);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(535, 123);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 11;
            // 
            // Cuadro
            // 
            Cuadro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Cuadro.Location = new Point(64, 482);
            Cuadro.Margin = new Padding(3, 4, 3, 4);
            Cuadro.Name = "Cuadro";
            Cuadro.RowHeadersWidth = 51;
            Cuadro.Size = new Size(1182, 312);
            Cuadro.TabIndex = 16;
            // 
            // Positive
            // 
            Positive.ContainerControl = this;
            // 
            // Number
            // 
            Number.ContainerControl = this;
            // 
            // Void
            // 
            Void.ContainerControl = this;
            // 
            // BTNNext
            // 
            BTNNext.Location = new Point(224, 823);
            BTNNext.Name = "BTNNext";
            BTNNext.Size = new Size(94, 29);
            BTNNext.TabIndex = 17;
            BTNNext.Text = "-->";
            BTNNext.UseVisualStyleBackColor = true;
            BTNNext.Click += BTNNext_Click_1;
            // 
            // BTNAfter
            // 
            BTNAfter.Location = new Point(106, 823);
            BTNAfter.Name = "BTNAfter";
            BTNAfter.Size = new Size(94, 29);
            BTNAfter.TabIndex = 18;
            BTNAfter.Text = "<--";
            BTNAfter.UseVisualStyleBackColor = true;
            BTNAfter.Click += BTNAfter_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1268, 878);
            Controls.Add(BTNAfter);
            Controls.Add(BTNNext);
            Controls.Add(Cuadro);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Poblation);
            Controls.Add(Gestioner);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Cuadro).EndInit();
            ((System.ComponentModel.ISupportInitialize)Positive).EndInit();
            ((System.ComponentModel.ISupportInitialize)Number).EndInit();
            ((System.ComponentModel.ISupportInitialize)Void).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Gestioner;
        private Label Year;
        private Label Comarca;
        private Label Poblation;
        private ComboBox AnyText;
        private ComboBox ComarcaText;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox ActivitatsText;
        private TextBox DomésticText;
        private Label label4;
        private Label label3;
        private TextBox TotalText;
        private TextBox ConsumText;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label LBLCM;
        private Label LBLPoblacio;
        private Label LBLCMB;
        private Label LBLCMA;
        private TextBox PoblacióText;
        private DataGridView Cuadro;
        private ErrorProvider Positive;
        private ErrorProvider Number;
        private ErrorProvider Void;
        private Button BTNAfter;
        private Button BTNNext;
    }
}
