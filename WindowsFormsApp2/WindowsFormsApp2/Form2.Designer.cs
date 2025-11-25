namespace WindowsFormsApp2
{
    partial class Form2
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
            this.Senha_Label = new System.Windows.Forms.Label();
            this.Senha_DB = new System.Windows.Forms.TextBox();
            this.Porta_Label = new System.Windows.Forms.Label();
            this.Porta_DB = new System.Windows.Forms.TextBox();
            this.Usuario_Label = new System.Windows.Forms.Label();
            this.Usuario_DB = new System.Windows.Forms.TextBox();
            this.Conectar = new System.Windows.Forms.Button();
            this.Nome_DB_Label = new System.Windows.Forms.Label();
            this.Nome_DB = new System.Windows.Forms.TextBox();
            this.Host_label = new System.Windows.Forms.Label();
            this.Host_DB = new System.Windows.Forms.TextBox();
            this.label_feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Senha_Label
            // 
            this.Senha_Label.AutoSize = true;
            this.Senha_Label.Location = new System.Drawing.Point(373, 121);
            this.Senha_Label.Name = "Senha_Label";
            this.Senha_Label.Size = new System.Drawing.Size(53, 17);
            this.Senha_Label.TabIndex = 17;
            this.Senha_Label.Text = "Senha:";
            // 
            // Senha_DB
            // 
            this.Senha_DB.Location = new System.Drawing.Point(376, 150);
            this.Senha_DB.Name = "Senha_DB";
            this.Senha_DB.Size = new System.Drawing.Size(276, 22);
            this.Senha_DB.TabIndex = 16;
            // 
            // Porta_Label
            // 
            this.Porta_Label.AutoSize = true;
            this.Porta_Label.Location = new System.Drawing.Point(373, 41);
            this.Porta_Label.Name = "Porta_Label";
            this.Porta_Label.Size = new System.Drawing.Size(46, 17);
            this.Porta_Label.TabIndex = 15;
            this.Porta_Label.Text = "Porta:";
            // 
            // Porta_DB
            // 
            this.Porta_DB.Location = new System.Drawing.Point(376, 70);
            this.Porta_DB.Name = "Porta_DB";
            this.Porta_DB.Size = new System.Drawing.Size(276, 22);
            this.Porta_DB.TabIndex = 14;
            // 
            // Usuario_Label
            // 
            this.Usuario_Label.AutoSize = true;
            this.Usuario_Label.Location = new System.Drawing.Point(31, 121);
            this.Usuario_Label.Name = "Usuario_Label";
            this.Usuario_Label.Size = new System.Drawing.Size(61, 17);
            this.Usuario_Label.TabIndex = 13;
            this.Usuario_Label.Text = "Usuário:";
            // 
            // Usuario_DB
            // 
            this.Usuario_DB.Location = new System.Drawing.Point(34, 150);
            this.Usuario_DB.Name = "Usuario_DB";
            this.Usuario_DB.Size = new System.Drawing.Size(276, 22);
            this.Usuario_DB.TabIndex = 12;
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(695, 387);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(75, 23);
            this.Conectar.TabIndex = 11;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Nome_DB_Label
            // 
            this.Nome_DB_Label.AutoSize = true;
            this.Nome_DB_Label.Location = new System.Drawing.Point(31, 41);
            this.Nome_DB_Label.Name = "Nome_DB_Label";
            this.Nome_DB_Label.Size = new System.Drawing.Size(112, 17);
            this.Nome_DB_Label.TabIndex = 10;
            this.Nome_DB_Label.Text = "Nome do banco:";
            // 
            // Nome_DB
            // 
            this.Nome_DB.Location = new System.Drawing.Point(34, 70);
            this.Nome_DB.Name = "Nome_DB";
            this.Nome_DB.Size = new System.Drawing.Size(276, 22);
            this.Nome_DB.TabIndex = 9;
            // 
            // Host_label
            // 
            this.Host_label.AutoSize = true;
            this.Host_label.Location = new System.Drawing.Point(31, 195);
            this.Host_label.Name = "Host_label";
            this.Host_label.Size = new System.Drawing.Size(104, 17);
            this.Host_label.TabIndex = 19;
            this.Host_label.Text = "Host do banco:";
            // 
            // Host_DB
            // 
            this.Host_DB.Location = new System.Drawing.Point(34, 224);
            this.Host_DB.Name = "Host_DB";
            this.Host_DB.Size = new System.Drawing.Size(276, 22);
            this.Host_DB.TabIndex = 18;
            // 
            // label_feedback
            // 
            this.label_feedback.AutoSize = true;
            this.label_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label_feedback.Location = new System.Drawing.Point(351, 393);
            this.label_feedback.Name = "label_feedback";
            this.label_feedback.Size = new System.Drawing.Size(0, 24);
            this.label_feedback.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_feedback);
            this.Controls.Add(this.Host_label);
            this.Controls.Add(this.Host_DB);
            this.Controls.Add(this.Senha_Label);
            this.Controls.Add(this.Senha_DB);
            this.Controls.Add(this.Porta_Label);
            this.Controls.Add(this.Porta_DB);
            this.Controls.Add(this.Usuario_Label);
            this.Controls.Add(this.Usuario_DB);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.Nome_DB_Label);
            this.Controls.Add(this.Nome_DB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Senha_Label;
        private System.Windows.Forms.TextBox Senha_DB;
        private System.Windows.Forms.Label Porta_Label;
        private System.Windows.Forms.TextBox Porta_DB;
        private System.Windows.Forms.Label Usuario_Label;
        private System.Windows.Forms.TextBox Usuario_DB;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Label Nome_DB_Label;
        private System.Windows.Forms.TextBox Nome_DB;
        private System.Windows.Forms.Label Host_label;
        private System.Windows.Forms.TextBox Host_DB;
        private System.Windows.Forms.Label label_feedback;
    }
}