
namespace WinFormsApp1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxJogador = new System.Windows.Forms.PictureBox();
            this.pictureBoxPC = new System.Windows.Forms.PictureBox();
            this.pictureResultado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(799, 89);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Escolha: pedra, papel ou tesoura ";
            // 
            // pictureBoxJogador
            // 
            this.pictureBoxJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxJogador.Location = new System.Drawing.Point(12, 92);
            this.pictureBoxJogador.Name = "pictureBoxJogador";
            this.pictureBoxJogador.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxJogador.TabIndex = 1;
            this.pictureBoxJogador.TabStop = false;
            // 
            // pictureBoxPC
            // 
            this.pictureBoxPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPC.Location = new System.Drawing.Point(284, 92);
            this.pictureBoxPC.Name = "pictureBoxPC";
            this.pictureBoxPC.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxPC.TabIndex = 2;
            this.pictureBoxPC.TabStop = false;
            // 
            // pictureResultado
            // 
            this.pictureResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureResultado.Location = new System.Drawing.Point(561, 92);
            this.pictureResultado.Name = "pictureResultado";
            this.pictureResultado.Size = new System.Drawing.Size(200, 200);
            this.pictureResultado.TabIndex = 3;
            this.pictureResultado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(76, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Você";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(368, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "PC";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResultado.Location = new System.Drawing.Point(647, 180);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(22, 30);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(228, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "VS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(510, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::WinFormsApp1.Properties.Resources.Tesoura1;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Location = new System.Drawing.Point(12, 305);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(200, 200);
            this.btnPedra.TabIndex = 9;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::WinFormsApp1.Properties.Resources.Papel;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Location = new System.Drawing.Point(284, 305);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(200, 200);
            this.btnPapel.TabIndex = 10;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::WinFormsApp1.Properties.Resources.Tesoura;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Location = new System.Drawing.Point(561, 305);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(200, 200);
            this.btnTesoura.TabIndex = 11;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 517);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureResultado);
            this.Controls.Add(this.pictureBoxPC);
            this.Controls.Add(this.pictureBoxJogador);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxJogador;
        private System.Windows.Forms.PictureBox pictureBoxPC;
        private System.Windows.Forms.PictureBox pictureResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        protected internal System.Windows.Forms.Button btnTesoura;
    }
}

