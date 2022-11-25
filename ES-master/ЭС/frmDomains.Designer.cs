namespace ЭС
{
    partial class frmDomains
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDomains));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.btnEditDomain = new System.Windows.Forms.Button();
            this.btnDelDomain = new System.Windows.Forms.Button();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.btnEditValue = new System.Windows.Forms.Button();
            this.btnDelValue = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.listBox1 = new ЭС.DragListBox();
            this.listBox2 = new ЭС.DragListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Домени:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значення:";
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.Location = new System.Drawing.Point(11, 283);
            this.btnAddDomain.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(89, 32);
            this.btnAddDomain.TabIndex = 4;
            this.btnAddDomain.Text = "Додати";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // btnEditDomain
            // 
            this.btnEditDomain.Location = new System.Drawing.Point(110, 283);
            this.btnEditDomain.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnEditDomain.Name = "btnEditDomain";
            this.btnEditDomain.Size = new System.Drawing.Size(89, 32);
            this.btnEditDomain.TabIndex = 5;
            this.btnEditDomain.Text = "Змінити";
            this.btnEditDomain.UseVisualStyleBackColor = true;
            this.btnEditDomain.Click += new System.EventHandler(this.btnEditDomain_Click);
            // 
            // btnDelDomain
            // 
            this.btnDelDomain.Location = new System.Drawing.Point(11, 323);
            this.btnDelDomain.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDelDomain.Name = "btnDelDomain";
            this.btnDelDomain.Size = new System.Drawing.Size(188, 32);
            this.btnDelDomain.TabIndex = 6;
            this.btnDelDomain.Text = "Видалити";
            this.btnDelDomain.UseVisualStyleBackColor = true;
            this.btnDelDomain.Click += new System.EventHandler(this.btnDelDomain_Click);
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(250, 283);
            this.btnAddValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(89, 32);
            this.btnAddValue.TabIndex = 7;
            this.btnAddValue.Text = "Додати";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // btnEditValue
            // 
            this.btnEditValue.Location = new System.Drawing.Point(349, 283);
            this.btnEditValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnEditValue.Name = "btnEditValue";
            this.btnEditValue.Size = new System.Drawing.Size(89, 32);
            this.btnEditValue.TabIndex = 8;
            this.btnEditValue.Text = "Змінити";
            this.btnEditValue.UseVisualStyleBackColor = true;
            this.btnEditValue.Click += new System.EventHandler(this.btnEditValue_Click);
            // 
            // btnDelValue
            // 
            this.btnDelValue.Location = new System.Drawing.Point(250, 323);
            this.btnDelValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDelValue.Name = "btnDelValue";
            this.btnDelValue.Size = new System.Drawing.Size(188, 32);
            this.btnDelValue.TabIndex = 9;
            this.btnDelValue.Text = "Видалити";
            this.btnDelValue.UseVisualStyleBackColor = true;
            this.btnDelValue.Click += new System.EventHandler(this.btnDelValue_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(11, 401);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(427, 32);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Зберегти";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(11, 39);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 238);
            this.listBox1.TabIndex = 12;
            this.listBox1.AfterDrop += new ЭС.AfterDropEventHandler(this.listBox1_AfterDrop);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(250, 39);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 238);
            this.listBox2.TabIndex = 13;
            this.listBox2.AfterDrop += new ЭС.AfterDropEventHandler(this.listBox2_AfterDrop);
            // 
            // frmDomains
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(449, 460);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDelValue);
            this.Controls.Add(this.btnEditValue);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.btnDelDomain);
            this.Controls.Add(this.btnEditDomain);
            this.Controls.Add(this.btnAddDomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 499);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(465, 499);
            this.Name = "frmDomains";
            this.Text = "Домени значень";
            this.Load += new System.EventHandler(this.frmDomains_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.Button btnEditDomain;
        private System.Windows.Forms.Button btnDelDomain;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Button btnEditValue;
        private System.Windows.Forms.Button btnDelValue;
        private System.Windows.Forms.Button btnOk;
        private DragListBox listBox1;
        private DragListBox listBox2;
    }
}