namespace Pila
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
            cmdAtras = new Button();
            cmdAdelnate = new Button();
            cmdIr = new Button();
            txtURL = new TextBox();
            SuspendLayout();
            // 
            // cmdAtras
            // 
            cmdAtras.Location = new Point(3, 12);
            cmdAtras.Name = "cmdAtras";
            cmdAtras.Size = new Size(54, 47);
            cmdAtras.TabIndex = 0;
            cmdAtras.Text = "<<";
            cmdAtras.UseVisualStyleBackColor = true;
            cmdAtras.Click += cmdAtras_Click;
            // 
            // cmdAdelnate
            // 
            cmdAdelnate.Location = new Point(63, 12);
            cmdAdelnate.Name = "cmdAdelnate";
            cmdAdelnate.Size = new Size(54, 47);
            cmdAdelnate.TabIndex = 1;
            cmdAdelnate.Text = ">>";
            cmdAdelnate.UseVisualStyleBackColor = true;
            cmdAdelnate.Click += cmdAdelnate_Click;
            // 
            // cmdIr
            // 
            cmdIr.BackColor = Color.FromArgb(128, 255, 128);
            cmdIr.FlatStyle = FlatStyle.Flat;
            cmdIr.Location = new Point(701, 12);
            cmdIr.Name = "cmdIr";
            cmdIr.Size = new Size(54, 47);
            cmdIr.TabIndex = 2;
            cmdIr.Text = "Ir";
            cmdIr.UseVisualStyleBackColor = false;
            cmdIr.Click += cmdIr_Click;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(123, 18);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(572, 34);
            txtURL.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(767, 92);
            Controls.Add(txtURL);
            Controls.Add(cmdIr);
            Controls.Add(cmdAdelnate);
            Controls.Add(cmdAtras);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form2";
            Text = "Navegador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAtras;
        private Button cmdAdelnate;
        private Button cmdIr;
        private TextBox txtURL;
    }
}