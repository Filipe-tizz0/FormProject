namespace WindowsFormsApp2
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
            this.Conectar = new System.Windows.Forms.Button();
            this.richTextBox_Query = new System.Windows.Forms.RichTextBox();
            this.Execute_button = new System.Windows.Forms.Button();
            this.datagrid_result = new System.Windows.Forms.DataGridView();
            this.Xml_Button = new System.Windows.Forms.Button();
            this.Chamada_api_Button = new System.Windows.Forms.Button();
            this.Querys_prontas_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_result)).BeginInit();
            this.SuspendLayout();
            // 
            // Conectar
            // 
            this.Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Conectar.Location = new System.Drawing.Point(22, 40);
            this.Conectar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(112, 31);
            this.Conectar.TabIndex = 2;
            this.Conectar.Text = "Editar conexão";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // richTextBox_Query
            // 
            this.richTextBox_Query.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.richTextBox_Query.Location = new System.Drawing.Point(159, 41);
            this.richTextBox_Query.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_Query.Name = "richTextBox_Query";
            this.richTextBox_Query.Size = new System.Drawing.Size(852, 331);
            this.richTextBox_Query.TabIndex = 3;
            this.richTextBox_Query.Text = "";
            // 
            // Execute_button
            // 
            this.Execute_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Execute_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Execute_button.Location = new System.Drawing.Point(879, 376);
            this.Execute_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Execute_button.Name = "Execute_button";
            this.Execute_button.Size = new System.Drawing.Size(130, 31);
            this.Execute_button.TabIndex = 4;
            this.Execute_button.Text = "Executar";
            this.Execute_button.UseVisualStyleBackColor = true;
            this.Execute_button.Click += new System.EventHandler(this.Execute_button_Click);
            // 
            // datagrid_result
            // 
            this.datagrid_result.AllowUserToOrderColumns = true;
            this.datagrid_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_result.Location = new System.Drawing.Point(159, 422);
            this.datagrid_result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagrid_result.Name = "datagrid_result";
            this.datagrid_result.RowTemplate.Height = 24;
            this.datagrid_result.Size = new System.Drawing.Size(850, 202);
            this.datagrid_result.TabIndex = 5;
            // 
            // Xml_Button
            // 
            this.Xml_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Xml_Button.Location = new System.Drawing.Point(22, 88);
            this.Xml_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Xml_Button.Name = "Xml_Button";
            this.Xml_Button.Size = new System.Drawing.Size(112, 31);
            this.Xml_Button.TabIndex = 6;
            this.Xml_Button.Text = "XML";
            this.Xml_Button.UseVisualStyleBackColor = true;
            this.Xml_Button.Click += new System.EventHandler(this.Xml_Button_Click);
            // 
            // Chamada_api_Button
            // 
            this.Chamada_api_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Chamada_api_Button.Location = new System.Drawing.Point(22, 142);
            this.Chamada_api_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Chamada_api_Button.Name = "Chamada_api_Button";
            this.Chamada_api_Button.Size = new System.Drawing.Size(112, 31);
            this.Chamada_api_Button.TabIndex = 7;
            this.Chamada_api_Button.Text = "Chamada API";
            this.Chamada_api_Button.UseVisualStyleBackColor = true;
            this.Chamada_api_Button.Click += new System.EventHandler(this.Chamada_api_Button_Click);
            // 
            // Querys_prontas_Button
            // 
            this.Querys_prontas_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Querys_prontas_Button.Location = new System.Drawing.Point(22, 199);
            this.Querys_prontas_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Querys_prontas_Button.Name = "Querys_prontas_Button";
            this.Querys_prontas_Button.Size = new System.Drawing.Size(112, 31);
            this.Querys_prontas_Button.TabIndex = 8;
            this.Querys_prontas_Button.Text = "Querys prontas";
            this.Querys_prontas_Button.UseVisualStyleBackColor = true;
            this.Querys_prontas_Button.Click += new System.EventHandler(this.Querys_prontas_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 643);
            this.Controls.Add(this.Querys_prontas_Button);
            this.Controls.Add(this.Chamada_api_Button);
            this.Controls.Add(this.Xml_Button);
            this.Controls.Add(this.datagrid_result);
            this.Controls.Add(this.Execute_button);
            this.Controls.Add(this.richTextBox_Query);
            this.Controls.Add(this.Conectar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.RichTextBox richTextBox_Query;
        private System.Windows.Forms.Button Execute_button;
        public System.Windows.Forms.DataGridView datagrid_result;
        private System.Windows.Forms.Button Xml_Button;
        private System.Windows.Forms.Button Chamada_api_Button;
        private System.Windows.Forms.Button Querys_prontas_Button;
    }
}

