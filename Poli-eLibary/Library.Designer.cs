namespace Poli_eLibary
{
    partial class Library
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.borrow = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.findbook = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // borrow
            // 
            this.borrow.BackColor = System.Drawing.Color.Transparent;
            this.borrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borrow.BackgroundImage")));
            this.borrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrow.FlatAppearance.BorderSize = 0;
            this.borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow.Location = new System.Drawing.Point(135, 271);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(137, 58);
            this.borrow.TabIndex = 29;
            this.borrow.Text = "Borrow";
            this.borrow.UseVisualStyleBackColor = false;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(226, 103);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(131, 35);
            this.search.TabIndex = 30;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Books ID #:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label1, "Input Books By Name or Book ID Number.\r\n");
            // 
            // findbook
            // 
            this.findbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.findbook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.findbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbook.Location = new System.Drawing.Point(196, 64);
            this.findbook.Name = "findbook";
            this.findbook.Size = new System.Drawing.Size(188, 22);
            this.findbook.TabIndex = 32;
            this.findbook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.findbook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findbook_TextChanged);
            this.findbook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.findbook_KeyPress);
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
            this.update.Location = new System.Drawing.Point(226, 143);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(131, 30);
            this.update.TabIndex = 35;
            this.update.Text = "Update Books";
            this.toolTip1.SetToolTip(this.update, "Only Authorized Personnel Can Access.");
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(146, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 54);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
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
            this.close.TabIndex = 34;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Return.BackgroundImage")));
            this.Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(340, 270);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(137, 58);
            this.Return.TabIndex = 36;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Student ID:";
            // 
            // studentid
            // 
            this.studentid.AutoSize = true;
            this.studentid.BackColor = System.Drawing.Color.Transparent;
            this.studentid.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentid.ForeColor = System.Drawing.Color.White;
            this.studentid.Location = new System.Drawing.Point(270, 8);
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(0, 19);
            this.studentid.TabIndex = 38;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(606, 330);
            this.Controls.Add(this.studentid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.update);
            this.Controls.Add(this.close);
            this.Controls.Add(this.findbook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox findbook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentid;
    }
}