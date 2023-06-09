namespace Plod_i_Zelenchuk
{
    partial class PlodIZelenchuk
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_baza = new System.Windows.Forms.ListBox();
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.cmb_price = new System.Windows.Forms.ComboBox();
            this.cmb_description = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(56, 86);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(46, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "NAME";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(56, 181);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(47, 16);
            this.lbl_price.TabIndex = 1;
            this.lbl_price.Text = "PRICE";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(56, 277);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(98, 16);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "DESCRIPTION";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(65, 350);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(142, 39);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(288, 350);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(142, 39);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(515, 350);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(142, 39);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // lb_baza
            // 
            this.lb_baza.FormattingEnabled = true;
            this.lb_baza.ItemHeight = 16;
            this.lb_baza.Location = new System.Drawing.Point(401, 83);
            this.lb_baza.Name = "lb_baza";
            this.lb_baza.Size = new System.Drawing.Size(377, 212);
            this.lb_baza.TabIndex = 10;
            // 
            // cmb_name
            // 
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(206, 83);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(155, 24);
            this.cmb_name.TabIndex = 11;
            // 
            // cmb_price
            // 
            this.cmb_price.FormattingEnabled = true;
            this.cmb_price.Location = new System.Drawing.Point(206, 178);
            this.cmb_price.Name = "cmb_price";
            this.cmb_price.Size = new System.Drawing.Size(155, 24);
            this.cmb_price.TabIndex = 12;
            // 
            // cmb_description
            // 
            this.cmb_description.FormattingEnabled = true;
            this.cmb_description.Location = new System.Drawing.Point(206, 274);
            this.cmb_description.Name = "cmb_description";
            this.cmb_description.Size = new System.Drawing.Size(155, 24);
            this.cmb_description.TabIndex = 13;
            // 
            // PlodIZelenchuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_description);
            this.Controls.Add(this.cmb_price);
            this.Controls.Add(this.cmb_name);
            this.Controls.Add(this.lb_baza);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_name);
            this.Name = "PlodIZelenchuk";
            this.Text = "PlodIZelenchuk";
            this.Load += new System.EventHandler(this.PlodIZelenchuk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox lb_baza;
        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.ComboBox cmb_price;
        private System.Windows.Forms.ComboBox cmb_description;
    }
}