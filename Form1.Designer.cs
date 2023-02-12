
namespace Network
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
			this.label2 = new System.Windows.Forms.Label();
			this.l_status = new System.Windows.Forms.Label();
			this.bt_ok = new System.Windows.Forms.Button();
			this.tb_uri = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_content = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolstrip = new System.Windows.Forms.ToolStripMenuItem();
			this.вывестиНаЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.countTags = new System.Windows.Forms.ToolStripMenuItem();
			this.uniqueTags = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.save_all = new System.Windows.Forms.ToolStripMenuItem();
			this.save_unique = new System.Windows.Forms.ToolStripMenuItem();
			this.ReadAll = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(334, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Консоль вывода";
			// 
			// l_status
			// 
			this.l_status.AutoSize = true;
			this.l_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.l_status.Location = new System.Drawing.Point(365, 426);
			this.l_status.Name = "l_status";
			this.l_status.Size = new System.Drawing.Size(60, 24);
			this.l_status.TabIndex = 4;
			this.l_status.Text = "Status";
			// 
			// bt_ok
			// 
			this.bt_ok.Location = new System.Drawing.Point(489, 28);
			this.bt_ok.Name = "bt_ok";
			this.bt_ok.Size = new System.Drawing.Size(54, 23);
			this.bt_ok.TabIndex = 5;
			this.bt_ok.Text = "ОК";
			this.bt_ok.UseVisualStyleBackColor = true;
			this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
			// 
			// tb_uri
			// 
			this.tb_uri.Location = new System.Drawing.Point(239, 30);
			this.tb_uri.Name = "tb_uri";
			this.tb_uri.Size = new System.Drawing.Size(244, 20);
			this.tb_uri.TabIndex = 6;
			this.tb_uri.Text = "https://vk.com/xxxxxxxxxxxxxx666xxxxxxxxxxxxxx";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(204, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "URI:";
			// 
			// tb_content
			// 
			this.tb_content.Location = new System.Drawing.Point(0, 93);
			this.tb_content.Multiline = true;
			this.tb_content.Name = "tb_content";
			this.tb_content.ReadOnly = true;
			this.tb_content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tb_content.Size = new System.Drawing.Size(800, 330);
			this.tb_content.TabIndex = 8;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolstrip
			// 
			this.toolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиНаЭкранToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
			this.toolstrip.Name = "toolstrip";
			this.toolstrip.Size = new System.Drawing.Size(48, 20);
			this.toolstrip.Text = "Файл";
			// 
			// вывестиНаЭкранToolStripMenuItem
			// 
			this.вывестиНаЭкранToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countTags,
            this.uniqueTags,
            this.ReadAll});
			this.вывестиНаЭкранToolStripMenuItem.Name = "вывестиНаЭкранToolStripMenuItem";
			this.вывестиНаЭкранToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.вывестиНаЭкранToolStripMenuItem.Text = "Вывести на экран...";
			// 
			// countTags
			// 
			this.countTags.Name = "countTags";
			this.countTags.Size = new System.Drawing.Size(180, 22);
			this.countTags.Text = "Количество тегов";
			this.countTags.Click += new System.EventHandler(this.countTags_Click);
			// 
			// uniqueTags
			// 
			this.uniqueTags.Name = "uniqueTags";
			this.uniqueTags.Size = new System.Drawing.Size(180, 22);
			this.uniqueTags.Text = "Уникальные теги";
			this.uniqueTags.Click += new System.EventHandler(this.uniqueTags_Click);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save_all,
            this.save_unique});
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить...";
			// 
			// save_all
			// 
			this.save_all.Name = "save_all";
			this.save_all.Size = new System.Drawing.Size(180, 22);
			this.save_all.Text = "Весь контент";
			this.save_all.Click += new System.EventHandler(this.save_all_Click);
			// 
			// save_unique
			// 
			this.save_unique.Name = "save_unique";
			this.save_unique.Size = new System.Drawing.Size(180, 22);
			this.save_unique.Text = "Уникальные теги";
			// 
			// ReadAll
			// 
			this.ReadAll.Name = "ReadAll";
			this.ReadAll.Size = new System.Drawing.Size(180, 22);
			this.ReadAll.Text = "Весь контент";
			this.ReadAll.Click += new System.EventHandler(this.ReadAll_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.l_status);
			this.Controls.Add(this.tb_content);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_uri);
			this.Controls.Add(this.bt_ok);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label l_status;
		private System.Windows.Forms.Button bt_ok;
		private System.Windows.Forms.TextBox tb_uri;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_content;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolstrip;
		private System.Windows.Forms.ToolStripMenuItem вывестиНаЭкранToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem countTags;
		private System.Windows.Forms.ToolStripMenuItem uniqueTags;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem save_all;
		private System.Windows.Forms.ToolStripMenuItem save_unique;
		private System.Windows.Forms.ToolStripMenuItem ReadAll;
	}
}

