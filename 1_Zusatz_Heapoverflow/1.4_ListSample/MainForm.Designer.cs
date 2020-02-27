namespace _1._4_ListSample
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBreakfast = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxBreakfast);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxFood);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(752, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Was ich heute frühstückte";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(333, 69);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 35);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(333, 114);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(78, 35);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "<<";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Frühstück";
            // 
            // listBoxBreakfast
            // 
            this.listBoxBreakfast.FormattingEnabled = true;
            this.listBoxBreakfast.ItemHeight = 20;
            this.listBoxBreakfast.Location = new System.Drawing.Point(444, 72);
            this.listBoxBreakfast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBreakfast.Name = "listBoxBreakfast";
            this.listBoxBreakfast.Size = new System.Drawing.Size(283, 124);
            this.listBoxBreakfast.TabIndex = 3;
            this.listBoxBreakfast.Enter += new System.EventHandler(this.listBoxBreakfast_Enter);
            this.listBoxBreakfast.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxBreakfast_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nahrungsmittel auswählen";
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(22, 72);
            this.comboBoxFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(283, 28);
            this.comboBoxFood.TabIndex = 1;
            this.comboBoxFood.Enter += new System.EventHandler(this.comboBoxFood_Enter);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 263);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.4 ListSample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxBreakfast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFood;

    }
}

