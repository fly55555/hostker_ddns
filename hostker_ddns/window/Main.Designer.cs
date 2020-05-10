namespace hostker_ddns.window
{
    partial class Main
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
            this.DNS_Manage_Button = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.dns_manage = new System.Windows.Forms.TabPage();
            this.account_manage = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DNS_Manage_Button
            // 
            this.DNS_Manage_Button.Location = new System.Drawing.Point(683, 62);
            this.DNS_Manage_Button.Name = "DNS_Manage_Button";
            this.DNS_Manage_Button.Size = new System.Drawing.Size(89, 38);
            this.DNS_Manage_Button.TabIndex = 0;
            this.DNS_Manage_Button.Text = "域名解析管理";
            this.DNS_Manage_Button.UseVisualStyleBackColor = true;
            this.DNS_Manage_Button.Click += new System.EventHandler(this.DNS_Manage_Button_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.dns_manage);
            this.TabControl.Controls.Add(this.account_manage);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(625, 537);
            this.TabControl.TabIndex = 1;
            // 
            // dns_manage
            // 
            this.dns_manage.Location = new System.Drawing.Point(4, 22);
            this.dns_manage.Name = "dns_manage";
            this.dns_manage.Padding = new System.Windows.Forms.Padding(3);
            this.dns_manage.Size = new System.Drawing.Size(617, 511);
            this.dns_manage.TabIndex = 0;
            this.dns_manage.Text = "dns_manage";
            this.dns_manage.UseVisualStyleBackColor = true;
            // 
            // account_manage
            // 
            this.account_manage.Location = new System.Drawing.Point(4, 22);
            this.account_manage.Name = "account_manage";
            this.account_manage.Padding = new System.Windows.Forms.Padding(3);
            this.account_manage.Size = new System.Drawing.Size(617, 511);
            this.account_manage.TabIndex = 1;
            this.account_manage.Text = "account_manage";
            this.account_manage.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.DNS_Manage_Button);
            this.Name = "Main";
            this.Text = "Main";
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DNS_Manage_Button;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage dns_manage;
        private System.Windows.Forms.TabPage account_manage;
    }
}