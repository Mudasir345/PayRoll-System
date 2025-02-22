namespace PayrollSytem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsPayroll = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmployee,
            this.tsPayroll,
            this.tsUser,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1490, 66);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsEmployee
            // 
            this.tsEmployee.Enabled = false;
            this.tsEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsEmployee.Image")));
            this.tsEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(102, 63);
            this.tsEmployee.Text = "Employees";
            this.tsEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEmployee.Click += new System.EventHandler(this.tsEmployee_Click);
            // 
            // tsPayroll
            // 
            this.tsPayroll.Enabled = false;
            this.tsPayroll.Image = ((System.Drawing.Image)(resources.GetObject("tsPayroll.Image")));
            this.tsPayroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPayroll.Name = "tsPayroll";
            this.tsPayroll.Size = new System.Drawing.Size(68, 63);
            this.tsPayroll.Text = "Payroll";
            this.tsPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPayroll.Click += new System.EventHandler(this.tsPayroll_Click);
            // 
            // tsUser
            // 
            this.tsUser.Enabled = false;
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(59, 63);
            this.tsUser.Text = "Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.Image = global::PayrollSytem.Properties.Resources._lock;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(60, 63);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1490, 777);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll System - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsEmployee;
        private System.Windows.Forms.ToolStripButton tsPayroll;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsLogin;
    }
}

