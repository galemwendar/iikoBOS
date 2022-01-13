
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_console = new System.Windows.Forms.RichTextBox();
            this.TB_url = new System.Windows.Forms.TextBox();
            this.TB_path = new System.Windows.Forms.TextBox();
            this.BTN_path = new System.Windows.Forms.Button();
            this.BTN_check = new System.Windows.Forms.Button();
            this.BTN_open = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TB_passwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_auth = new System.Windows.Forms.Button();
            this.lv_Servers = new System.Windows.Forms.ListView();
            this.columnServerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnServerAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnServerVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnServerEdition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TB_console
            // 
            this.TB_console.Location = new System.Drawing.Point(742, 263);
            this.TB_console.Name = "TB_console";
            this.TB_console.Size = new System.Drawing.Size(378, 284);
            this.TB_console.TabIndex = 6;
            this.TB_console.Text = "";
            // 
            // TB_url
            // 
            this.TB_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_url.Location = new System.Drawing.Point(742, 135);
            this.TB_url.Name = "TB_url";
            this.TB_url.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_url.Size = new System.Drawing.Size(363, 22);
            this.TB_url.TabIndex = 5;
            this.TB_url.TextChanged += new System.EventHandler(this.TB_url_TextChanged);
            // 
            // TB_path
            // 
            this.TB_path.Location = new System.Drawing.Point(742, 57);
            this.TB_path.Name = "TB_path";
            this.TB_path.Size = new System.Drawing.Size(267, 22);
            this.TB_path.TabIndex = 4;
            // 
            // BTN_path
            // 
            this.BTN_path.Location = new System.Drawing.Point(1030, 56);
            this.BTN_path.Name = "BTN_path";
            this.BTN_path.Size = new System.Drawing.Size(75, 23);
            this.BTN_path.TabIndex = 3;
            this.BTN_path.Text = "browse";
            this.BTN_path.UseVisualStyleBackColor = true;
            this.BTN_path.Click += new System.EventHandler(this.BTN_path_Click);
            // 
            // BTN_check
            // 
            this.BTN_check.Location = new System.Drawing.Point(742, 608);
            this.BTN_check.Name = "BTN_check";
            this.BTN_check.Size = new System.Drawing.Size(137, 44);
            this.BTN_check.TabIndex = 2;
            this.BTN_check.Text = "Check";
            this.BTN_check.UseVisualStyleBackColor = true;
            this.BTN_check.Click += new System.EventHandler(this.BTN_check_Click);
            // 
            // BTN_open
            // 
            this.BTN_open.Location = new System.Drawing.Point(1079, 608);
            this.BTN_open.Name = "BTN_open";
            this.BTN_open.Size = new System.Drawing.Size(137, 44);
            this.BTN_open.TabIndex = 3;
            this.BTN_open.Text = "Open";
            this.BTN_open.UseVisualStyleBackColor = true;
            this.BTN_open.Click += new System.EventHandler(this.BTN_open_Click);
            // 
            // TB_passwd
            // 
            this.TB_passwd.Location = new System.Drawing.Point(742, 206);
            this.TB_passwd.Name = "TB_passwd";
            this.TB_passwd.Size = new System.Drawing.Size(216, 22);
            this.TB_passwd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "passwd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(739, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "path";
            // 
            // BTN_auth
            // 
            this.BTN_auth.Location = new System.Drawing.Point(915, 608);
            this.BTN_auth.Name = "BTN_auth";
            this.BTN_auth.Size = new System.Drawing.Size(137, 44);
            this.BTN_auth.TabIndex = 11;
            this.BTN_auth.Text = "Authorize";
            this.BTN_auth.UseVisualStyleBackColor = true;
            this.BTN_auth.Click += new System.EventHandler(this.BTN_auth_Click);
            // 
            // lv_Servers
            // 
            this.lv_Servers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnServerName,
            this.columnServerAddress,
            this.columnServerVersion,
            this.columnServerEdition});
            this.lv_Servers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lv_Servers.FullRowSelect = true;
            this.lv_Servers.HideSelection = false;
            this.lv_Servers.Location = new System.Drawing.Point(0, 0);
            this.lv_Servers.MultiSelect = false;
            this.lv_Servers.Name = "lv_Servers";
            this.lv_Servers.Size = new System.Drawing.Size(722, 664);
            this.lv_Servers.TabIndex = 12;
            this.lv_Servers.UseCompatibleStateImageBehavior = false;
            this.lv_Servers.View = System.Windows.Forms.View.Details;
            this.lv_Servers.SelectedIndexChanged += new System.EventHandler(this.lv_Servers_SelectedIndexChanged);
            // 
            // columnServerName
            // 
            this.columnServerName.Text = "ServerName";
            this.columnServerName.Width = 115;
            // 
            // columnServerAddress
            // 
            this.columnServerAddress.Text = "ServerAddress";
            this.columnServerAddress.Width = 148;
            // 
            // columnServerVersion
            // 
            this.columnServerVersion.Text = "ServerVersion";
            this.columnServerVersion.Width = 111;
            // 
            // columnServerEdition
            // 
            this.columnServerEdition.Text = "ServerEdition";
            this.columnServerEdition.Width = 94;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 664);
            this.Controls.Add(this.lv_Servers);
            this.Controls.Add(this.BTN_auth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_passwd);
            this.Controls.Add(this.TB_console);
            this.Controls.Add(this.BTN_open);
            this.Controls.Add(this.BTN_check);
            this.Controls.Add(this.BTN_path);
            this.Controls.Add(this.TB_url);
            this.Controls.Add(this.TB_path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_url;
        private System.Windows.Forms.TextBox TB_path;
        private System.Windows.Forms.Button BTN_path;
        private System.Windows.Forms.Button BTN_check;
        private System.Windows.Forms.Button BTN_open;
        private System.Windows.Forms.RichTextBox TB_console;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox TB_passwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_auth;
        private System.Windows.Forms.ListView lv_Servers;
        private System.Windows.Forms.ColumnHeader columnServerName;
        private System.Windows.Forms.ColumnHeader columnServerAddress;
        private System.Windows.Forms.ColumnHeader columnServerVersion;
        private System.Windows.Forms.ColumnHeader columnServerEdition;
    }
}

