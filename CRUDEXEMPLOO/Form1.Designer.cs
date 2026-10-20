namespace CRUDEXEMPLOO
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TEXTBOXNOME = new TextBox();
            TEXTBOXSOBRENOME = new TextBox();
            TEXTBOXCURSO = new TextBox();
            TEXBOXIDADE = new TextBox();
            TEXTBOXRM = new TextBox();
            button1 = new Button();
            label6 = new Label();
            TEXTBOXANO = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 72);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "SOBRENOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 109);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "CURSO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 147);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "IDADE";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 188);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 4;
            label5.Text = "RM";
            label5.Click += label5_Click;
            // 
            // TEXTBOXNOME
            // 
            TEXTBOXNOME.BackColor = Color.LightSkyBlue;
            TEXTBOXNOME.Location = new Point(129, 24);
            TEXTBOXNOME.Name = "TEXTBOXNOME";
            TEXTBOXNOME.Size = new Size(174, 23);
            TEXTBOXNOME.TabIndex = 5;
            // 
            // TEXTBOXSOBRENOME
            // 
            TEXTBOXSOBRENOME.BackColor = Color.LightSkyBlue;
            TEXTBOXSOBRENOME.Location = new Point(129, 64);
            TEXTBOXSOBRENOME.Name = "TEXTBOXSOBRENOME";
            TEXTBOXSOBRENOME.Size = new Size(174, 23);
            TEXTBOXSOBRENOME.TabIndex = 6;
            // 
            // TEXTBOXCURSO
            // 
            TEXTBOXCURSO.BackColor = Color.LightSkyBlue;
            TEXTBOXCURSO.Location = new Point(129, 101);
            TEXTBOXCURSO.Name = "TEXTBOXCURSO";
            TEXTBOXCURSO.Size = new Size(174, 23);
            TEXTBOXCURSO.TabIndex = 7;
            // 
            // TEXBOXIDADE
            // 
            TEXBOXIDADE.BackColor = Color.LightSkyBlue;
            TEXBOXIDADE.Location = new Point(129, 139);
            TEXBOXIDADE.Name = "TEXBOXIDADE";
            TEXBOXIDADE.Size = new Size(174, 23);
            TEXBOXIDADE.TabIndex = 8;
            // 
            // TEXTBOXRM
            // 
            TEXTBOXRM.BackColor = Color.LightSkyBlue;
            TEXTBOXRM.Location = new Point(129, 180);
            TEXTBOXRM.Name = "TEXTBOXRM";
            TEXTBOXRM.Size = new Size(174, 23);
            TEXTBOXRM.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(177, 265);
            button1.Name = "button1";
            button1.Size = new Size(75, 49);
            button1.TabIndex = 10;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 226);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 11;
            label6.Text = "ANO";
            // 
            // TEXTBOXANO
            // 
            TEXTBOXANO.BackColor = Color.LightSkyBlue;
            TEXTBOXANO.Location = new Point(129, 218);
            TEXTBOXANO.Name = "TEXTBOXANO";
            TEXTBOXANO.Size = new Size(174, 23);
            TEXTBOXANO.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TEXTBOXANO);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(TEXTBOXRM);
            Controls.Add(TEXBOXIDADE);
            Controls.Add(TEXTBOXCURSO);
            Controls.Add(TEXTBOXSOBRENOME);
            Controls.Add(TEXTBOXNOME);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TEXTBOXNOME;
        private TextBox TEXTBOXSOBRENOME;
        private TextBox TEXTBOXCURSO;
        private TextBox TEXBOXIDADE;
        private TextBox TEXTBOXRM;
        private Button button1;
        private Label label6;
        private TextBox TEXTBOXANO;
    }
}
