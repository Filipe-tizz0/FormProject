namespace WindowsFormsApp2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nome_Colaborador = new System.Windows.Forms.TextBox();
            this.Cargo_Colaborador = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Obrig_tarefa1 = new System.Windows.Forms.TextBox();
            this.Desc_tarefa1 = new System.Windows.Forms.TextBox();
            this.Desc_tarefa2 = new System.Windows.Forms.TextBox();
            this.Obrig_tarefa2 = new System.Windows.Forms.TextBox();
            this.Desc_tarefa3 = new System.Windows.Forms.TextBox();
            this.Obrig_tarefa3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.XML_Read_TextBox = new System.Windows.Forms.RichTextBox();
            this.Leitura_Singular_XMl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML Managment";
            // 
            // Nome_Colaborador
            // 
            this.Nome_Colaborador.Location = new System.Drawing.Point(55, 104);
            this.Nome_Colaborador.Name = "Nome_Colaborador";
            this.Nome_Colaborador.Size = new System.Drawing.Size(219, 22);
            this.Nome_Colaborador.TabIndex = 1;
            // 
            // Cargo_Colaborador
            // 
            this.Cargo_Colaborador.Location = new System.Drawing.Point(372, 103);
            this.Cargo_Colaborador.Name = "Cargo_Colaborador";
            this.Cargo_Colaborador.Size = new System.Drawing.Size(196, 22);
            this.Cargo_Colaborador.TabIndex = 2;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(52, 74);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(49, 17);
            this.nome_label.TabIndex = 3;
            this.nome_label.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargo:";
            // 
            // Obrig_tarefa1
            // 
            this.Obrig_tarefa1.Location = new System.Drawing.Point(679, 103);
            this.Obrig_tarefa1.Name = "Obrig_tarefa1";
            this.Obrig_tarefa1.Size = new System.Drawing.Size(140, 22);
            this.Obrig_tarefa1.TabIndex = 5;
            // 
            // Desc_tarefa1
            // 
            this.Desc_tarefa1.Location = new System.Drawing.Point(847, 104);
            this.Desc_tarefa1.Name = "Desc_tarefa1";
            this.Desc_tarefa1.Size = new System.Drawing.Size(219, 22);
            this.Desc_tarefa1.TabIndex = 6;
            // 
            // Desc_tarefa2
            // 
            this.Desc_tarefa2.Location = new System.Drawing.Point(847, 153);
            this.Desc_tarefa2.Name = "Desc_tarefa2";
            this.Desc_tarefa2.Size = new System.Drawing.Size(219, 22);
            this.Desc_tarefa2.TabIndex = 8;
            // 
            // Obrig_tarefa2
            // 
            this.Obrig_tarefa2.Location = new System.Drawing.Point(679, 153);
            this.Obrig_tarefa2.Name = "Obrig_tarefa2";
            this.Obrig_tarefa2.Size = new System.Drawing.Size(140, 22);
            this.Obrig_tarefa2.TabIndex = 7;
            // 
            // Desc_tarefa3
            // 
            this.Desc_tarefa3.Location = new System.Drawing.Point(847, 205);
            this.Desc_tarefa3.Name = "Desc_tarefa3";
            this.Desc_tarefa3.Size = new System.Drawing.Size(219, 22);
            this.Desc_tarefa3.TabIndex = 10;
            // 
            // Obrig_tarefa3
            // 
            this.Obrig_tarefa3.Location = new System.Drawing.Point(679, 204);
            this.Obrig_tarefa3.Name = "Obrig_tarefa3";
            this.Obrig_tarefa3.Size = new System.Drawing.Size(140, 22);
            this.Obrig_tarefa3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tarefas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(844, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrições:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Criar XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XML_Read_TextBox
            // 
            this.XML_Read_TextBox.Location = new System.Drawing.Point(52, 310);
            this.XML_Read_TextBox.Name = "XML_Read_TextBox";
            this.XML_Read_TextBox.Size = new System.Drawing.Size(1013, 426);
            this.XML_Read_TextBox.TabIndex = 14;
            this.XML_Read_TextBox.Text = "";
            // 
            // Leitura_Singular_XMl
            // 
            this.Leitura_Singular_XMl.Location = new System.Drawing.Point(195, 204);
            this.Leitura_Singular_XMl.Name = "Leitura_Singular_XMl";
            this.Leitura_Singular_XMl.Size = new System.Drawing.Size(104, 23);
            this.Leitura_Singular_XMl.TabIndex = 15;
            this.Leitura_Singular_XMl.Text = "Ler XML";
            this.Leitura_Singular_XMl.UseVisualStyleBackColor = true;
            this.Leitura_Singular_XMl.Click += new System.EventHandler(this.Leitura_Singular_XMl_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 765);
            this.Controls.Add(this.Leitura_Singular_XMl);
            this.Controls.Add(this.XML_Read_TextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Desc_tarefa3);
            this.Controls.Add(this.Obrig_tarefa3);
            this.Controls.Add(this.Desc_tarefa2);
            this.Controls.Add(this.Obrig_tarefa2);
            this.Controls.Add(this.Desc_tarefa1);
            this.Controls.Add(this.Obrig_tarefa1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.Cargo_Colaborador);
            this.Controls.Add(this.Nome_Colaborador);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Nome_Colaborador;
        public System.Windows.Forms.TextBox Cargo_Colaborador;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Obrig_tarefa1;
        public System.Windows.Forms.TextBox Desc_tarefa1;
        public System.Windows.Forms.TextBox Desc_tarefa2;
        public System.Windows.Forms.TextBox Obrig_tarefa2;
        public System.Windows.Forms.TextBox Desc_tarefa3;
        public System.Windows.Forms.TextBox Obrig_tarefa3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox XML_Read_TextBox;
        private System.Windows.Forms.Button Leitura_Singular_XMl;
    }
}