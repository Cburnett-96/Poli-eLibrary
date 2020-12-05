namespace Poli_eLibary
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.close = new System.Windows.Forms.Button();
            this.studentid_textbox = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.bookreturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loss = new System.Windows.Forms.TextBox();
            this.penalty = new System.Windows.Forms.TextBox();
            this.datereturn = new System.Windows.Forms.DateTimePicker();
            this.dateborrow = new System.Windows.Forms.DateTimePicker();
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
            // studentid_textbox
            // 
            this.studentid_textbox.Enabled = false;
            this.studentid_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentid_textbox.Location = new System.Drawing.Point(238, 124);
            this.studentid_textbox.Name = "studentid_textbox";
            this.studentid_textbox.Size = new System.Drawing.Size(130, 22);
            this.studentid_textbox.TabIndex = 43;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Transparent;
            this.calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calculate.BackgroundImage")));
            this.calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculate.FlatAppearance.BorderSize = 0;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(258, 334);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(85, 27);
            this.calculate.TabIndex = 56;
            this.calculate.Text = "Compute";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // bookreturn
            // 
            this.bookreturn.BackColor = System.Drawing.Color.Transparent;
            this.bookreturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookreturn.BackgroundImage")));
            this.bookreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookreturn.FlatAppearance.BorderSize = 0;
            this.bookreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookreturn.Location = new System.Drawing.Point(138, 379);
            this.bookreturn.Name = "bookreturn";
            this.bookreturn.Size = new System.Drawing.Size(138, 50);
            this.bookreturn.TabIndex = 55;
            this.bookreturn.Text = "Return Book";
            this.bookreturn.UseVisualStyleBackColor = false;
            this.bookreturn.Click += new System.EventHandler(this.bookreturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(83, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 47);
            this.label3.TabIndex = 54;
            this.label3.Text = "Poli - eLibrary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 37);
            this.label4.TabIndex = 53;
            this.label4.Text = "Returning Book Information.";
            // 
            // bookid
            // 
            this.bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid.Location = new System.Drawing.Point(238, 162);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(130, 22);
            this.bookid.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 180);
            this.label1.TabIndex = 50;
            this.label1.Text = "\r\nBook ID Number:\r\n\r\nBorrow Date:\r\n\r\nDate of Return:\r\n\r\nValue of Book if Loss/Dam" +
    "age:\r\n\r\nPenalty Total Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Student ID:";
            // 
            // loss
            // 
            this.loss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loss.Location = new System.Drawing.Point(238, 272);
            this.loss.Name = "loss";
            this.loss.Size = new System.Drawing.Size(130, 22);
            this.loss.TabIndex = 58;
            this.loss.Text = "0";
            // 
            // penalty
            // 
            this.penalty.Enabled = false;
            this.penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penalty.Location = new System.Drawing.Point(238, 311);
            this.penalty.Name = "penalty";
            this.penalty.Size = new System.Drawing.Size(130, 22);
            this.penalty.TabIndex = 59;
            this.penalty.Text = "0";
            // 
            // datereturn
            // 
            this.datereturn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datereturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datereturn.Location = new System.Drawing.Point(238, 235);
            this.datereturn.Name = "datereturn";
            this.datereturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datereturn.Size = new System.Drawing.Size(130, 20);
            this.datereturn.TabIndex = 60;
            // 
            // dateborrow
            // 
            this.dateborrow.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateborrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateborrow.Location = new System.Drawing.Point(238, 196);
            this.dateborrow.Name = "dateborrow";
            this.dateborrow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateborrow.Size = new System.Drawing.Size(130, 20);
            this.dateborrow.TabIndex = 61;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 441);
            this.Controls.Add(this.dateborrow);
            this.Controls.Add(this.datereturn);
            this.Controls.Add(this.penalty);
            this.Controls.Add(this.loss);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.bookreturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentid_textbox);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox studentid_textbox;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button bookreturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loss;
        private System.Windows.Forms.TextBox penalty;
        private System.Windows.Forms.DateTimePicker datereturn;
        private System.Windows.Forms.DateTimePicker dateborrow;
    }
}