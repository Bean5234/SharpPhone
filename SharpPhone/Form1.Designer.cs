namespace SharpPhone
{
    partial class fmMain
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lsbStock = new ListBox();
            txtStock = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(339, 34);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(339, 69);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Aanpassen";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(339, 104);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Verwijderen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button3_Click;
            // 
            // lsbStock
            // 
            lsbStock.FormattingEnabled = true;
            lsbStock.Location = new Point(12, 34);
            lsbStock.Name = "lsbStock";
            lsbStock.Size = new Size(321, 404);
            lsbStock.TabIndex = 3;
            lsbStock.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtStock
            // 
            txtStock.AutoSize = true;
            txtStock.Location = new Point(12, 9);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(65, 20);
            txtStock.TabIndex = 4;
            txtStock.Text = "Vooraad";
            txtStock.Click += label1_Click;
            // 
            // fmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(txtStock);
            Controls.Add(lsbStock);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "fmMain";
            Text = "SharpPhone";
            Load += fmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private ListBox lsbStock;
        private Label txtStock;
    }
}
