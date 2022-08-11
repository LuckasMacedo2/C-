namespace CapturarTeclas
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
            this.label_Tecla = new System.Windows.Forms.Label();
            this.button_Enter = new System.Windows.Forms.Button();
            this.button_X = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Tecla
            // 
            this.label_Tecla.Location = new System.Drawing.Point(14, 11);
            this.label_Tecla.Name = "label_Tecla";
            this.label_Tecla.Size = new System.Drawing.Size(679, 352);
            this.label_Tecla.TabIndex = 0;
            this.label_Tecla.Text = "Digite uma tecla";
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(473, 372);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(220, 66);
            this.button_Enter.TabIndex = 1;
            this.button_Enter.Text = "Tecla enter";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            this.button_Enter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            // 
            // button_X
            // 
            this.button_X.Location = new System.Drawing.Point(14, 366);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(231, 72);
            this.button_X.TabIndex = 2;
            this.button_X.Text = "Tecla X";
            this.button_X.UseVisualStyleBackColor = true;
            this.button_X.Click += new System.EventHandler(this.button_X_Click);
            this.button_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.button_X);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.label_Tecla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_Tecla;
        private Button button_Enter;
        private Button button_X;
    }
}