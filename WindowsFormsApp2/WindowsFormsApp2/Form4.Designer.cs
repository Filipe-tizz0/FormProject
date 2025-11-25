namespace WindowsFormsApp2
{
    partial class Form4
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
            this.URL_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Realizar_Chamada = new System.Windows.Forms.Button();
            this.API_Result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // URL_TextBox
            // 
            this.URL_TextBox.Location = new System.Drawing.Point(62, 153);
            this.URL_TextBox.Name = "URL_TextBox";
            this.URL_TextBox.Size = new System.Drawing.Size(735, 22);
            this.URL_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta API";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL de consulta:";
            // 
            // Realizar_Chamada
            // 
            this.Realizar_Chamada.Location = new System.Drawing.Point(823, 153);
            this.Realizar_Chamada.Name = "Realizar_Chamada";
            this.Realizar_Chamada.Size = new System.Drawing.Size(146, 23);
            this.Realizar_Chamada.TabIndex = 16;
            this.Realizar_Chamada.Text = "Chamar URL";
            this.Realizar_Chamada.UseVisualStyleBackColor = true;
            this.Realizar_Chamada.Click += new System.EventHandler(this.Realizar_Chamada_Click);
            // 
            // API_Result
            // 
            this.API_Result.Location = new System.Drawing.Point(62, 295);
            this.API_Result.Name = "API_Result";
            this.API_Result.Size = new System.Drawing.Size(1154, 377);
            this.API_Result.TabIndex = 17;
            this.API_Result.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 765);
            this.Controls.Add(this.API_Result);
            this.Controls.Add(this.Realizar_Chamada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URL_TextBox);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox URL_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Realizar_Chamada;
        public System.Windows.Forms.RichTextBox API_Result;
    }
}