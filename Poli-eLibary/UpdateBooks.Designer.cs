namespace Poli_eLibary
{
    partial class UpdateBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBooks));
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.TextBox();
            this.booktitle = new System.Windows.Forms.TextBox();
            this.bookauthor = new System.Windows.Forms.TextBox();
            this.bookpublisher = new System.Windows.Forms.TextBox();
            this.bookpages = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(12, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 21);
            this.close.TabIndex = 35;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 264);
            this.label1.TabIndex = 36;
            this.label1.Text = "\r\nBook ID Number:\r\n\r\nBook Title:\r\n\r\nName of the Author:\r\n\r\nName of the Publisher:" +
    "\r\n\r\nNumber of Book Pages:\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(150, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 45);
            this.label2.TabIndex = 37;
            this.label2.Text = "Book Information.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(162, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 47);
            this.label3.TabIndex = 38;
            this.label3.Text = "Poli - eLibrary";
            // 
            // bookid
            // 
            this.bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid.Location = new System.Drawing.Point(295, 116);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(216, 26);
            this.bookid.TabIndex = 39;
            this.bookid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bookid_KeyPress);
            // 
            // booktitle
            // 
            this.booktitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booktitle.Location = new System.Drawing.Point(295, 160);
            this.booktitle.Name = "booktitle";
            this.booktitle.Size = new System.Drawing.Size(216, 26);
            this.booktitle.TabIndex = 40;
            // 
            // bookauthor
            // 
            this.bookauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookauthor.Location = new System.Drawing.Point(295, 215);
            this.bookauthor.Name = "bookauthor";
            this.bookauthor.Size = new System.Drawing.Size(216, 26);
            this.bookauthor.TabIndex = 41;
            // 
            // bookpublisher
            // 
            this.bookpublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookpublisher.Location = new System.Drawing.Point(295, 257);
            this.bookpublisher.Name = "bookpublisher";
            this.bookpublisher.Size = new System.Drawing.Size(216, 26);
            this.bookpublisher.TabIndex = 42;
            // 
            // bookpages
            // 
            this.bookpages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookpages.Location = new System.Drawing.Point(295, 306);
            this.bookpages.Name = "bookpages";
            this.bookpages.Size = new System.Drawing.Size(216, 26);
            this.bookpages.TabIndex = 43;
            this.bookpages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bookid_KeyPress);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Transparent;
            this.insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insert.BackgroundImage")));
            this.insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert.FlatAppearance.BorderSize = 0;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(50, 359);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(140, 37);
            this.insert.TabIndex = 44;
            this.insert.Text = "Insert Information";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(217, 359);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(153, 37);
            this.update.TabIndex = 45;
            this.update.Text = "Update Information";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Transparent;
            this.remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remove.BackgroundImage")));
            this.remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.FlatAppearance.BorderSize = 0;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(397, 359);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(160, 37);
            this.remove.TabIndex = 46;
            this.remove.Text = "Remove Information";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // UpdateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(612, 434);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.bookpages);
            this.Controls.Add(this.bookpublisher);
            this.Controls.Add(this.bookauthor);
            this.Controls.Add(this.booktitle);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.TextBox booktitle;
        private System.Windows.Forms.TextBox bookauthor;
        private System.Windows.Forms.TextBox bookpublisher;
        private System.Windows.Forms.TextBox bookpages;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button remove;
    }
}