namespace lms2
{
    partial class LoggedIn
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
            this.publish = new System.Windows.Forms.Button();
            this.addstudent = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.borrow = new System.Windows.Forms.Button();
            this.returnbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publish
            // 
            this.publish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.publish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.publish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.publish.Location = new System.Drawing.Point(214, 247);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(211, 36);
            this.publish.TabIndex = 2;
            this.publish.Text = "Publish";
            this.publish.UseVisualStyleBackColor = false;
            this.publish.Click += new System.EventHandler(this.publish_Click);
            // 
            // addstudent
            // 
            this.addstudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.addstudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addstudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addstudent.Location = new System.Drawing.Point(214, 195);
            this.addstudent.Name = "addstudent";
            this.addstudent.Size = new System.Drawing.Size(211, 36);
            this.addstudent.TabIndex = 3;
            this.addstudent.Text = "Add Student";
            this.addstudent.UseVisualStyleBackColor = false;
            this.addstudent.Click += new System.EventHandler(this.addstudent_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Location = new System.Drawing.Point(214, 300);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(211, 36);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(267, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu";
            // 
            // borrow
            // 
            this.borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.borrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.borrow.Location = new System.Drawing.Point(214, 82);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(211, 36);
            this.borrow.TabIndex = 6;
            this.borrow.Text = "Borrow";
            this.borrow.UseVisualStyleBackColor = false;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // returnbtn
            // 
            this.returnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.returnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnbtn.Location = new System.Drawing.Point(214, 137);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(211, 36);
            this.returnbtn.TabIndex = 8;
            this.returnbtn.Text = "Return";
            this.returnbtn.UseVisualStyleBackColor = false;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(644, 387);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.addstudent);
            this.Controls.Add(this.publish);
            this.Name = "LoggedIn";
            this.Text = "LoggedIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button publish;
        private System.Windows.Forms.Button addstudent;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button returnbtn;
    }
}