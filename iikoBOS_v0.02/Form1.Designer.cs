
namespace iikoCheckVersion._02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TB_url = new System.Windows.Forms.TextBox();
            this.TB_console = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog_path = new System.Windows.Forms.FolderBrowserDialog();
            this.LA_url = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_checkServerProperties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_url
            // 
            this.TB_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_url.Location = new System.Drawing.Point(12, 40);
            this.TB_url.Name = "TB_url";
            this.TB_url.Size = new System.Drawing.Size(412, 27);
            this.TB_url.TabIndex = 2;
            this.TB_url.TextChanged += new System.EventHandler(this.TB_url_TextChanged);
            this.TB_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_url_KeyDown);
            // 
            // TB_console
            // 
            this.TB_console.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TB_console.Location = new System.Drawing.Point(12, 103);
            this.TB_console.Multiline = true;
            this.TB_console.Name = "TB_console";
            this.TB_console.ReadOnly = true;
            this.TB_console.Size = new System.Drawing.Size(412, 108);
            this.TB_console.TabIndex = 3;
            // 
            // folderBrowserDialog_path
            // 
            this.folderBrowserDialog_path.Description = "Выберите папку с бэками. Обратите внимание, что она не должна находиться в корне " +
    "любого диска";
            this.folderBrowserDialog_path.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog_path.ShowNewFolderButton = false;
            // 
            // LA_url
            // 
            this.LA_url.AutoSize = true;
            this.LA_url.Location = new System.Drawing.Point(12, 20);
            this.LA_url.Name = "LA_url";
            this.LA_url.Size = new System.Drawing.Size(106, 17);
            this.LA_url.TabIndex = 6;
            this.LA_url.Text = "Адрес сервера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вывод";
            // 
            // BTN_checkServerProperties
            // 
            this.BTN_checkServerProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_checkServerProperties.Location = new System.Drawing.Point(146, 242);
            this.BTN_checkServerProperties.Name = "BTN_checkServerProperties";
            this.BTN_checkServerProperties.Size = new System.Drawing.Size(129, 47);
            this.BTN_checkServerProperties.TabIndex = 8;
            this.BTN_checkServerProperties.Text = "Проверить";
            this.BTN_checkServerProperties.UseVisualStyleBackColor = true;
            this.BTN_checkServerProperties.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(446, 309);
            this.Controls.Add(this.BTN_checkServerProperties);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LA_url);
            this.Controls.Add(this.TB_console);
            this.Controls.Add(this.TB_url);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "iikoBOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_url;
        private System.Windows.Forms.TextBox TB_console;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_path;
        private System.Windows.Forms.Label LA_url;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_checkServerProperties;
    }
}

