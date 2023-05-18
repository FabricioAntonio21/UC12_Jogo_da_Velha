namespace UC12_Jogo_da_Velha
{
    partial class Form_INICIO
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
            this.button_selecionar1 = new System.Windows.Forms.Button();
            this.button_selecionar2 = new System.Windows.Forms.Button();
            this.button_comecar = new System.Windows.Forms.Button();
            this.textBox_nome1 = new System.Windows.Forms.TextBox();
            this.textBox_nome2 = new System.Windows.Forms.TextBox();
            this.label_Nome1 = new System.Windows.Forms.Label();
            this.label_nome2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_selecionar1
            // 
            this.button_selecionar1.Location = new System.Drawing.Point(63, 257);
            this.button_selecionar1.Name = "button_selecionar1";
            this.button_selecionar1.Size = new System.Drawing.Size(103, 33);
            this.button_selecionar1.TabIndex = 0;
            this.button_selecionar1.Text = "Escolher";
            this.button_selecionar1.UseVisualStyleBackColor = true;
            this.button_selecionar1.Click += new System.EventHandler(this.button_selecionar1_Click);
            // 
            // button_selecionar2
            // 
            this.button_selecionar2.Location = new System.Drawing.Point(473, 257);
            this.button_selecionar2.Name = "button_selecionar2";
            this.button_selecionar2.Size = new System.Drawing.Size(103, 33);
            this.button_selecionar2.TabIndex = 1;
            this.button_selecionar2.Text = "Escolher";
            this.button_selecionar2.UseVisualStyleBackColor = true;
            this.button_selecionar2.Click += new System.EventHandler(this.button_selecionar2_Click);
            // 
            // button_comecar
            // 
            this.button_comecar.Location = new System.Drawing.Point(258, 348);
            this.button_comecar.Name = "button_comecar";
            this.button_comecar.Size = new System.Drawing.Size(103, 33);
            this.button_comecar.TabIndex = 2;
            this.button_comecar.Text = "Começar";
            this.button_comecar.UseVisualStyleBackColor = true;
            this.button_comecar.Click += new System.EventHandler(this.button_comecar_Click);
            // 
            // textBox_nome1
            // 
            this.textBox_nome1.Location = new System.Drawing.Point(214, 138);
            this.textBox_nome1.Name = "textBox_nome1";
            this.textBox_nome1.Size = new System.Drawing.Size(216, 20);
            this.textBox_nome1.TabIndex = 3;
            // 
            // textBox_nome2
            // 
            this.textBox_nome2.Location = new System.Drawing.Point(214, 218);
            this.textBox_nome2.Name = "textBox_nome2";
            this.textBox_nome2.Size = new System.Drawing.Size(216, 20);
            this.textBox_nome2.TabIndex = 4;
            // 
            // label_Nome1
            // 
            this.label_Nome1.AutoSize = true;
            this.label_Nome1.Location = new System.Drawing.Point(224, 117);
            this.label_Nome1.Name = "label_Nome1";
            this.label_Nome1.Size = new System.Drawing.Size(54, 13);
            this.label_Nome1.TabIndex = 5;
            this.label_Nome1.Text = "Jogador 1";
            // 
            // label_nome2
            // 
            this.label_nome2.AutoSize = true;
            this.label_nome2.Location = new System.Drawing.Point(224, 202);
            this.label_nome2.Name = "label_nome2";
            this.label_nome2.Size = new System.Drawing.Size(54, 13);
            this.label_nome2.TabIndex = 6;
            this.label_nome2.Text = "Jogador 2";
            // 
            // label1
            // 
            this.label1.Image = global::UC12_Jogo_da_Velha.Properties.Resources.fechar;
            this.label1.Location = new System.Drawing.Point(50, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 137);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Image = global::UC12_Jogo_da_Velha.Properties.Resources.alfabeto;
            this.label2.Location = new System.Drawing.Point(456, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 137);
            this.label2.TabIndex = 8;
            // 
            // Form_INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_Jogo_da_Velha.Properties.Resources.fundo1_jogodavelha;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nome2);
            this.Controls.Add(this.label_Nome1);
            this.Controls.Add(this.textBox_nome2);
            this.Controls.Add(this.textBox_nome1);
            this.Controls.Add(this.button_comecar);
            this.Controls.Add(this.button_selecionar2);
            this.Controls.Add(this.button_selecionar1);
            this.Name = "Form_INICIO";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_selecionar1;
        private System.Windows.Forms.Button button_selecionar2;
        private System.Windows.Forms.Button button_comecar;
        private System.Windows.Forms.TextBox textBox_nome1;
        private System.Windows.Forms.TextBox textBox_nome2;
        private System.Windows.Forms.Label label_Nome1;
        private System.Windows.Forms.Label label_nome2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}