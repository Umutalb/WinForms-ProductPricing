namespace ProductPricingApp
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
            lbl_name = new Label();
            lbl_quantity = new Label();
            lbl_unitPrice = new Label();
            txt_name = new TextBox();
            txt_quantity = new TextBox();
            txt_unitPrice = new TextBox();
            btn_add = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(7, 15);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(52, 20);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name:";
            // 
            // lbl_quantity
            // 
            lbl_quantity.AutoSize = true;
            lbl_quantity.Location = new Point(7, 74);
            lbl_quantity.Name = "lbl_quantity";
            lbl_quantity.Size = new Size(68, 20);
            lbl_quantity.TabIndex = 1;
            lbl_quantity.Text = "Quantity:";
            // 
            // lbl_unitPrice
            // 
            lbl_unitPrice.AutoSize = true;
            lbl_unitPrice.Location = new Point(7, 138);
            lbl_unitPrice.Name = "lbl_unitPrice";
            lbl_unitPrice.Size = new Size(75, 20);
            lbl_unitPrice.TabIndex = 2;
            lbl_unitPrice.Text = "Unit Price:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(104, 12);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 3;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(104, 74);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(125, 27);
            txt_quantity.TabIndex = 4;
            // 
            // txt_unitPrice
            // 
            txt_unitPrice.Location = new Point(104, 138);
            txt_unitPrice.Name = "txt_unitPrice";
            txt_unitPrice.Size = new Size(125, 27);
            txt_unitPrice.TabIndex = 5;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(104, 204);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // listBox1
            // 
            listBox1.Location = new Point(261, 15);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(527, 364);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btn_add);
            Controls.Add(txt_unitPrice);
            Controls.Add(txt_quantity);
            Controls.Add(txt_name);
            Controls.Add(lbl_unitPrice);
            Controls.Add(lbl_quantity);
            Controls.Add(lbl_name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_quantity;
        private Label lbl_unitPrice;
        private TextBox txt_name;
        private TextBox txt_quantity;
        private TextBox txt_unitPrice;
        private Button btn_add;
        private ListBox listBox1;
    }
}
