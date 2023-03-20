namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.wishList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fillB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.countB = new System.Windows.Forms.Button();
            this.selTB = new System.Windows.Forms.TextBox();
            this.countTbox = new System.Windows.Forms.TextBox();
            this.sortB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wishList
            // 
            this.wishList.FormattingEnabled = true;
            this.wishList.Location = new System.Drawing.Point(57, 93);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(167, 173);
            this.wishList.TabIndex = 0;
            this.wishList.SelectedIndexChanged += new System.EventHandler(this.wishList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wish List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Count";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fillB
            // 
            this.fillB.Location = new System.Drawing.Point(258, 93);
            this.fillB.Name = "fillB";
            this.fillB.Size = new System.Drawing.Size(75, 23);
            this.fillB.TabIndex = 4;
            this.fillB.Text = "Fill";
            this.fillB.UseVisualStyleBackColor = true;
            this.fillB.Click += new System.EventHandler(this.fillB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(258, 169);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 5;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.button2_Click);
            // 
            // countB
            // 
            this.countB.Location = new System.Drawing.Point(258, 207);
            this.countB.Name = "countB";
            this.countB.Size = new System.Drawing.Size(75, 23);
            this.countB.TabIndex = 6;
            this.countB.Text = "Count";
            this.countB.UseVisualStyleBackColor = true;
            this.countB.Click += new System.EventHandler(this.countB_Click);
            // 
            // selTB
            // 
            this.selTB.Location = new System.Drawing.Point(91, 296);
            this.selTB.Name = "selTB";
            this.selTB.Size = new System.Drawing.Size(148, 20);
            this.selTB.TabIndex = 7;
            this.selTB.TextChanged += new System.EventHandler(this.selTB_TextChanged);
            // 
            // countTbox
            // 
            this.countTbox.Location = new System.Drawing.Point(91, 330);
            this.countTbox.Name = "countTbox";
            this.countTbox.Size = new System.Drawing.Size(148, 20);
            this.countTbox.TabIndex = 8;
            this.countTbox.TextChanged += new System.EventHandler(this.countTbox_TextChanged);
            // 
            // sortB
            // 
            this.sortB.Location = new System.Drawing.Point(258, 131);
            this.sortB.Name = "sortB";
            this.sortB.Size = new System.Drawing.Size(75, 23);
            this.sortB.TabIndex = 9;
            this.sortB.Text = "Sort";
            this.sortB.UseVisualStyleBackColor = true;
            this.sortB.Click += new System.EventHandler(this.sortB_Click);
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(258, 243);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 23);
            this.exitB.TabIndex = 10;
            this.exitB.Text = "Close";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.sortB);
            this.Controls.Add(this.countTbox);
            this.Controls.Add(this.selTB);
            this.Controls.Add(this.countB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.fillB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wishList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wishList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fillB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button countB;
        private System.Windows.Forms.TextBox selTB;
        private System.Windows.Forms.TextBox countTbox;
        private System.Windows.Forms.Button sortB;
        private System.Windows.Forms.Button exitB;

    }
}

