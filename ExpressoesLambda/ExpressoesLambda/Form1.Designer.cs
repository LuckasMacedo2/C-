namespace ExpressoesLambda
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
            this.label_Resultado = new System.Windows.Forms.Label();
            this.button_Resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Resultado
            // 
            this.label_Resultado.Location = new System.Drawing.Point(12, 9);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(776, 212);
            this.label_Resultado.TabIndex = 0;
            this.label_Resultado.Text = "Resultado";
            // 
            // button_Resultado
            // 
            this.button_Resultado.Location = new System.Drawing.Point(585, 359);
            this.button_Resultado.Name = "button_Resultado";
            this.button_Resultado.Size = new System.Drawing.Size(203, 79);
            this.button_Resultado.TabIndex = 1;
            this.button_Resultado.Text = "Executar";
            this.button_Resultado.UseVisualStyleBackColor = true;
            this.button_Resultado.Click += new System.EventHandler(this.button_Resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Resultado);
            this.Controls.Add(this.label_Resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_Resultado;
        private Button button_Resultado;
    }
}