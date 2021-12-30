
namespace iikoBOS_v0._02
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
            this.BTN_path = new System.Windows.Forms.Button();
            this.TB_path = new System.Windows.Forms.TextBox();
            this.TB_url = new System.Windows.Forms.TextBox();
            this.TB_console = new System.Windows.Forms.TextBox();
            this.BTN_start = new System.Windows.Forms.Button();
            this.folderBrowserDialog_path = new System.Windows.Forms.FolderBrowserDialog();
            this.LA_path = new System.Windows.Forms.Label();
            this.LA_url = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_path
            // 
            this.BTN_path.Location = new System.Drawing.Point(335, 51);
            this.BTN_path.Name = "BTN_path";
            this.BTN_path.Size = new System.Drawing.Size(108, 27);
            this.BTN_path.TabIndex = 0;
            this.BTN_path.Text = "Выбрать";
            this.BTN_path.UseVisualStyleBackColor = true;
            this.BTN_path.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_path
            // 
            this.TB_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_path.Location = new System.Drawing.Point(31, 50);
            this.TB_path.Name = "TB_path";
            this.TB_path.Size = new System.Drawing.Size(298, 27);
            this.TB_path.TabIndex = 1;
            // 
            // TB_url
            // 
            this.TB_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_url.Location = new System.Drawing.Point(31, 106);
            this.TB_url.Name = "TB_url";
            this.TB_url.Size = new System.Drawing.Size(412, 27);
            this.TB_url.TabIndex = 2;
            this.TB_url.TextChanged += new System.EventHandler(this.TB_url_TextChanged);
            // 
            // TB_console
            // 
            this.TB_console.Location = new System.Drawing.Point(31, 169);
            this.TB_console.Multiline = true;
            this.TB_console.Name = "TB_console";
            this.TB_console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_console.Size = new System.Drawing.Size(412, 174);
            this.TB_console.TabIndex = 3;
            // 
            // BTN_start
            // 
            this.BTN_start.Location = new System.Drawing.Point(137, 385);
            this.BTN_start.Name = "BTN_start";
            this.BTN_start.Size = new System.Drawing.Size(222, 53);
            this.BTN_start.TabIndex = 4;
            this.BTN_start.Text = "Открыть бэк";
            this.BTN_start.UseVisualStyleBackColor = true;
            this.BTN_start.Click += new System.EventHandler(this.BTN_start_Click);
            // 
            // folderBrowserDialog_path
            // 
            this.folderBrowserDialog_path.Description = "Выберите папку с бэками. Обратите внимание, что она не должна находиться в корне " +
    "любого диска";
            this.folderBrowserDialog_path.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog_path.ShowNewFolderButton = false;
            // 
            // LA_path
            // 
            this.LA_path.AutoSize = true;
            this.LA_path.Location = new System.Drawing.Point(31, 30);
            this.LA_path.Name = "LA_path";
            this.LA_path.Size = new System.Drawing.Size(164, 17);
            this.LA_path.TabIndex = 5;
            this.LA_path.Text = "Путь до папки с бэками";
            this.LA_path.Click += new System.EventHandler(this.LA_path_Click);
            // 
            // LA_url
            // 
            this.LA_url.AutoSize = true;
            this.LA_url.Location = new System.Drawing.Point(31, 86);
            this.LA_url.Name = "LA_url";
            this.LA_url.Size = new System.Drawing.Size(106, 17);
            this.LA_url.TabIndex = 6;
            this.LA_url.Text = "Адрес сервера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вывод";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LA_url);
            this.Controls.Add(this.LA_path);
            this.Controls.Add(this.BTN_start);
            this.Controls.Add(this.TB_console);
            this.Controls.Add(this.TB_url);
            this.Controls.Add(this.TB_path);
            this.Controls.Add(this.BTN_path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_path;
        private System.Windows.Forms.TextBox TB_path;
        private System.Windows.Forms.TextBox TB_url;
        private System.Windows.Forms.TextBox TB_console;
        private System.Windows.Forms.Button BTN_start;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_path;
        private System.Windows.Forms.Label LA_path;
        private System.Windows.Forms.Label LA_url;
        private System.Windows.Forms.Label label3;
    }
}

