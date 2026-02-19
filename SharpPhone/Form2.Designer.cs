namespace SharpPhone
{
    partial class fmMain
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
            lblBrand = new Label();
            lblModel = new Label();
            lblSize = new Label();
            lblPrize = new Label();
            lblStock = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            txtbCancel = new Button();
            txtbOk = new Button();
            SuspendLayout();
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(12, 13);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(42, 20);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Merk";
            lblBrand.Click += this.label1_Click;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(12, 63);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model";
            lblModel.Click += label2_Click;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(12, 113);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 20);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size";
            lblSize.Click += lblSize_Click;
            // 
            // lblPrize
            // 
            lblPrize.AutoSize = true;
            lblPrize.Location = new Point(12, 163);
            lblPrize.Name = "lblPrize";
            lblPrize.Size = new Size(36, 20);
            lblPrize.TabIndex = 3;
            lblPrize.Text = "Prijs";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 213);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(70, 20);
            lblStock.TabIndex = 4;
            lblStock.Text = "Voorraad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(123, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(123, 210);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(293, 27);
            textBox5.TabIndex = 9;
            // 
            // txtbCancel
            // 
            txtbCancel.Location = new Point(12, 279);
            txtbCancel.Name = "txtbCancel";
            txtbCancel.Size = new Size(138, 36);
            txtbCancel.TabIndex = 10;
            txtbCancel.Text = "Cancel";
            txtbCancel.UseVisualStyleBackColor = true;
            // 
            // txtbOk
            // 
            txtbOk.Location = new Point(278, 279);
            txtbOk.Name = "txtbOk";
            txtbOk.Size = new Size(138, 36);
            txtbOk.TabIndex = 11;
            txtbOk.Text = "Ok";
            txtbOk.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 327);
            Controls.Add(txtbOk);
            Controls.Add(txtbCancel);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblStock);
            Controls.Add(lblPrize);
            Controls.Add(lblSize);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Name = "fmMain";
            Text = "  ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrand;
        private Label lblModel;
        private Label lblSize;
        private Label lblPrize;
        private Label lblStock;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button txtbCancel;
        private Button txtbOk;
    }
}