namespace _1._2_TextSample
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEingabe = new System.Windows.Forms.TextBox();
            this.buttonHinzufuegen = new System.Windows.Forms.Button();
            this.listBoxResultat = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text: ";
            // 
            // textBoxEingabe
            // 
            this.textBoxEingabe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEingabe.Location = new System.Drawing.Point(79, 15);
            this.textBoxEingabe.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEingabe.Name = "textBoxEingabe";
            this.textBoxEingabe.Size = new System.Drawing.Size(403, 26);
            this.textBoxEingabe.TabIndex = 1;
            this.textBoxEingabe.TextChanged += new System.EventHandler(this.textBoxEingabe_TextChanged);
            // 
            // buttonHinzufuegen
            // 
            this.buttonHinzufuegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHinzufuegen.Location = new System.Drawing.Point(489, 11);
            this.buttonHinzufuegen.Margin = new System.Windows.Forms.Padding(5);
            this.buttonHinzufuegen.Name = "buttonHinzufuegen";
            this.buttonHinzufuegen.Size = new System.Drawing.Size(113, 35);
            this.buttonHinzufuegen.TabIndex = 2;
            this.buttonHinzufuegen.Text = "&Hinzufügen";
            this.buttonHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonHinzufuegen.Click += new System.EventHandler(this.buttonHinzufuegen_Click);
            // 
            // listBoxResultat
            // 
            this.listBoxResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxResultat.FormattingEnabled = true;
            this.listBoxResultat.ItemHeight = 20;
            this.listBoxResultat.Location = new System.Drawing.Point(18, 57);
            this.listBoxResultat.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxResultat.Name = "listBoxResultat";
            this.listBoxResultat.Size = new System.Drawing.Size(582, 184);
            this.listBoxResultat.TabIndex = 3;
            this.listBoxResultat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxResultat_KeyDown);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(489, 268);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 35);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonHinzufuegen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(624, 318);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listBoxResultat);
            this.Controls.Add(this.buttonHinzufuegen);
            this.Controls.Add(this.textBoxEingabe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.2 TextSample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEingabe;
        private System.Windows.Forms.Button buttonHinzufuegen;
        private System.Windows.Forms.ListBox listBoxResultat;
        private System.Windows.Forms.Button buttonCancel;
    }
}

