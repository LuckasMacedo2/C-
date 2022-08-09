namespace CriptografiaDeArquivos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChave = new System.Windows.Forms.TextBox();
            this.buttonCriptografarArquivo = new System.Windows.Forms.Button();
            this.buttonExportarChave = new System.Windows.Forms.Button();
            this.buttonDecriptarArquivo = new System.Windows.Forms.Button();
            this.buttonImportarChave = new System.Windows.Forms.Button();
            this.buttonCriarChaves = new System.Windows.Forms.Button();
            this.buttonObterChavePrivada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chave não definida";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxChave
            // 
            this.textBoxChave.Location = new System.Drawing.Point(12, 55);
            this.textBoxChave.Name = "textBoxChave";
            this.textBoxChave.Size = new System.Drawing.Size(582, 23);
            this.textBoxChave.TabIndex = 1;
            this.textBoxChave.TextChanged += new System.EventHandler(this.textBoxChave_TextChanged);
            // 
            // buttonCriptografarArquivo
            // 
            this.buttonCriptografarArquivo.Location = new System.Drawing.Point(13, 84);
            this.buttonCriptografarArquivo.Name = "buttonCriptografarArquivo";
            this.buttonCriptografarArquivo.Size = new System.Drawing.Size(190, 67);
            this.buttonCriptografarArquivo.TabIndex = 2;
            this.buttonCriptografarArquivo.Text = "Criptografar Arquivo";
            this.buttonCriptografarArquivo.UseVisualStyleBackColor = true;
            this.buttonCriptografarArquivo.Click += new System.EventHandler(this.buttonCriptografarArquivo_Click);
            // 
            // buttonExportarChave
            // 
            this.buttonExportarChave.Location = new System.Drawing.Point(13, 157);
            this.buttonExportarChave.Name = "buttonExportarChave";
            this.buttonExportarChave.Size = new System.Drawing.Size(190, 67);
            this.buttonExportarChave.TabIndex = 3;
            this.buttonExportarChave.Text = "Exportar Chave Pública";
            this.buttonExportarChave.UseVisualStyleBackColor = true;
            this.buttonExportarChave.Click += new System.EventHandler(this.buttonExportarChave_Click);
            // 
            // buttonDecriptarArquivo
            // 
            this.buttonDecriptarArquivo.Location = new System.Drawing.Point(209, 84);
            this.buttonDecriptarArquivo.Name = "buttonDecriptarArquivo";
            this.buttonDecriptarArquivo.Size = new System.Drawing.Size(190, 67);
            this.buttonDecriptarArquivo.TabIndex = 4;
            this.buttonDecriptarArquivo.Text = "Decriptar Arquivo";
            this.buttonDecriptarArquivo.UseVisualStyleBackColor = true;
            this.buttonDecriptarArquivo.Click += new System.EventHandler(this.buttonDecriptarArquivo_Click);
            // 
            // buttonImportarChave
            // 
            this.buttonImportarChave.Location = new System.Drawing.Point(209, 157);
            this.buttonImportarChave.Name = "buttonImportarChave";
            this.buttonImportarChave.Size = new System.Drawing.Size(190, 67);
            this.buttonImportarChave.TabIndex = 5;
            this.buttonImportarChave.Text = "Importar Chave Pública";
            this.buttonImportarChave.UseVisualStyleBackColor = true;
            this.buttonImportarChave.Click += new System.EventHandler(this.buttonImportarChave_Click);
            // 
            // buttonCriarChaves
            // 
            this.buttonCriarChaves.Location = new System.Drawing.Point(405, 84);
            this.buttonCriarChaves.Name = "buttonCriarChaves";
            this.buttonCriarChaves.Size = new System.Drawing.Size(190, 67);
            this.buttonCriarChaves.TabIndex = 6;
            this.buttonCriarChaves.Text = "Criar Chaves";
            this.buttonCriarChaves.UseVisualStyleBackColor = true;
            this.buttonCriarChaves.Click += new System.EventHandler(this.buttonCriarChaves_Click);
            // 
            // buttonObterChavePrivada
            // 
            this.buttonObterChavePrivada.Location = new System.Drawing.Point(405, 157);
            this.buttonObterChavePrivada.Name = "buttonObterChavePrivada";
            this.buttonObterChavePrivada.Size = new System.Drawing.Size(190, 67);
            this.buttonObterChavePrivada.TabIndex = 7;
            this.buttonObterChavePrivada.Text = "Obter Chave Privada";
            this.buttonObterChavePrivada.UseVisualStyleBackColor = true;
            this.buttonObterChavePrivada.Click += new System.EventHandler(this.buttonObterChavePrivada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 244);
            this.Controls.Add(this.buttonObterChavePrivada);
            this.Controls.Add(this.buttonCriarChaves);
            this.Controls.Add(this.buttonImportarChave);
            this.Controls.Add(this.buttonDecriptarArquivo);
            this.Controls.Add(this.buttonExportarChave);
            this.Controls.Add(this.buttonCriptografarArquivo);
            this.Controls.Add(this.textBoxChave);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxChave;
        private Button buttonCriptografarArquivo;
        private Button buttonExportarChave;
        private Button buttonDecriptarArquivo;
        private Button buttonImportarChave;
        private Button buttonCriarChaves;
        private Button buttonObterChavePrivada;
    }
}