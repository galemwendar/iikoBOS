
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LA_url = new System.Windows.Forms.Label();
            this.LA_path = new System.Windows.Forms.Label();
            this.TB_console = new System.Windows.Forms.RichTextBox();
            this.TB_url = new System.Windows.Forms.TextBox();
            this.TB_path = new System.Windows.Forms.TextBox();
            this.BTN_path = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BTN_check = new System.Windows.Forms.Button();
            this.BTN_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LA_url);
            this.panel1.Controls.Add(this.LA_path);
            this.panel1.Controls.Add(this.TB_console);
            this.panel1.Controls.Add(this.TB_url);
            this.panel1.Controls.Add(this.TB_path);
            this.panel1.Controls.Add(this.BTN_path);
            this.panel1.Location = new System.Drawing.Point(299, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 362);
            this.panel1.TabIndex = 0;
            // 
            // LA_url
            // 
            this.LA_url.AutoSize = true;
            this.LA_url.Location = new System.Drawing.Point(22, 95);
            this.LA_url.Name = "LA_url";
            this.LA_url.Size = new System.Drawing.Size(106, 17);
            this.LA_url.TabIndex = 8;
            this.LA_url.Text = "Адрес сервера";
            // 
            // LA_path
            // 
            this.LA_path.AutoSize = true;
            this.LA_path.Location = new System.Drawing.Point(22, 32);
            this.LA_path.Name = "LA_path";
            this.LA_path.Size = new System.Drawing.Size(164, 17);
            this.LA_path.TabIndex = 7;
            this.LA_path.Text = "Путь до папки с бэками";
            // 
            // TB_console
            // 
            this.TB_console.Location = new System.Drawing.Point(25, 163);
            this.TB_console.Name = "TB_console";
            this.TB_console.Size = new System.Drawing.Size(363, 178);
            this.TB_console.TabIndex = 6;
            this.TB_console.Text = "";
            // 
            // TB_url
            // 
            this.TB_url.Location = new System.Drawing.Point(25, 115);
            this.TB_url.Name = "TB_url";
            this.TB_url.Size = new System.Drawing.Size(363, 22);
            this.TB_url.TabIndex = 5;
            this.TB_url.TextChanged += new System.EventHandler(this.TB_url_TextChanged);
            // 
            // TB_path
            // 
            this.TB_path.Location = new System.Drawing.Point(25, 52);
            this.TB_path.Name = "TB_path";
            this.TB_path.Size = new System.Drawing.Size(267, 22);
            this.TB_path.TabIndex = 4;
            // 
            // BTN_path
            // 
            this.BTN_path.Location = new System.Drawing.Point(313, 51);
            this.BTN_path.Name = "BTN_path";
            this.BTN_path.Size = new System.Drawing.Size(75, 23);
            this.BTN_path.TabIndex = 3;
            this.BTN_path.Text = "browse";
            this.BTN_path.UseVisualStyleBackColor = true;
            this.BTN_path.Click += new System.EventHandler(this.BTN_path_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(257, 430);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // BTN_check
            // 
            this.BTN_check.Location = new System.Drawing.Point(372, 412);
            this.BTN_check.Name = "BTN_check";
            this.BTN_check.Size = new System.Drawing.Size(137, 44);
            this.BTN_check.TabIndex = 2;
            this.BTN_check.Text = "Check";
            this.BTN_check.UseVisualStyleBackColor = true;
            this.BTN_check.Click += new System.EventHandler(this.BTN_check_Click);
            // 
            // BTN_open
            // 
            this.BTN_open.Location = new System.Drawing.Point(577, 412);
            this.BTN_open.Name = "BTN_open";
            this.BTN_open.Size = new System.Drawing.Size(137, 44);
            this.BTN_open.TabIndex = 3;
            this.BTN_open.Text = "Open";
            this.BTN_open.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список серверов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Параметры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вывод";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_open);
            this.Controls.Add(this.BTN_check);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_url;
        private System.Windows.Forms.TextBox TB_path;
        private System.Windows.Forms.Button BTN_path;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BTN_check;
        private System.Windows.Forms.Button BTN_open;
        private System.Windows.Forms.RichTextBox TB_console;
        private System.Windows.Forms.Label LA_path;
        private System.Windows.Forms.Label LA_url;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

