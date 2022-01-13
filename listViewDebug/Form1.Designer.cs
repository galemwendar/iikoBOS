
namespace iikoBOS
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
            this.lv_Servers = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Console = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog_path = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Path = new System.Windows.Forms.Button();
            this.tb_Passwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lv_Servers
            // 
            this.lv_Servers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1});
            this.lv_Servers.FullRowSelect = true;
            this.lv_Servers.HideSelection = false;
            this.lv_Servers.Location = new System.Drawing.Point(13, 13);
            this.lv_Servers.Name = "lv_Servers";
            this.lv_Servers.Size = new System.Drawing.Size(427, 532);
            this.lv_Servers.TabIndex = 0;
            this.lv_Servers.UseCompatibleStateImageBehavior = false;
            this.lv_Servers.View = System.Windows.Forms.View.Details;
            this.lv_Servers.SelectedIndexChanged += new System.EventHandler(this.lv_Servers_SelectedIndexChanged);
            this.lv_Servers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_Servers_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Server Version";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Server Edition";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Server Name";
            // 
            // tb_Url
            // 
            this.tb_Url.Location = new System.Drawing.Point(477, 94);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(293, 22);
            this.tb_Url.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(719, 175);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(182, 51);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(477, 49);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(293, 22);
            this.tb_Path.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Адрес сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь до папки с бэками";
            // 
            // tb_Console
            // 
            this.tb_Console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Console.Location = new System.Drawing.Point(474, 333);
            this.tb_Console.Name = "tb_Console";
            this.tb_Console.Size = new System.Drawing.Size(427, 212);
            this.tb_Console.TabIndex = 7;
            this.tb_Console.Text = "";
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(828, 49);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(73, 36);
            this.btn_Path.TabIndex = 8;
            this.btn_Path.Text = "Path";
            this.btn_Path.UseVisualStyleBackColor = true;
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // tb_Passwd
            // 
            this.tb_Passwd.Location = new System.Drawing.Point(477, 220);
            this.tb_Passwd.Name = "tb_Passwd";
            this.tb_Passwd.Size = new System.Drawing.Size(182, 22);
            this.tb_Passwd.TabIndex = 9;
            this.tb_Passwd.TextChanged += new System.EventHandler(this.tb_Passwd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Логин";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(477, 175);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(182, 22);
            this.tb_Login.TabIndex = 11;
            this.tb_Login.TextChanged += new System.EventHandler(this.tb_Login_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Passwd);
            this.Controls.Add(this.btn_Path);
            this.Controls.Add(this.tb_Console);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_Url);
            this.Controls.Add(this.lv_Servers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Servers;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tb_Url;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tb_Console;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_path;
        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.TextBox tb_Passwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Login;
    }
}

