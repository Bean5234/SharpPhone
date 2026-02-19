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
            lstItems = new ListBox();
            lblStock = new Label();
            menuStrip1 = new MenuStrip();
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
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.Location = new Point(12, 34);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(321, 404);
            lstItems.TabIndex = 3;
            lstItems.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblStock
            // 
            lbl2Stock2.AutoSize = true;
            lbl2Stock2.Location = new Point(12, 9);
            lbl2Stock2.Name = "lblStock";
            lbl2Stock2.Size = new Size(65, 20);
            lbl2Stock2.TabIndex = 4;
            lbl2Stock2.Text = "Vooraad";
            lbl2Stock2.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(497, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(lbl2Stock2);
            Controls.Add(lstItems);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ListBox lstItems;
        private Label lbl2Stock2;
        private MenuStrip menuStrip1;
    }
}
