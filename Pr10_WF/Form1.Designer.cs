namespace Pr10_WF
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
			this.execute_button = new System.Windows.Forms.Button();
			this.process_box = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// execute_button
			// 
			this.execute_button.Location = new System.Drawing.Point(0, 305);
			this.execute_button.Name = "execute_button";
			this.execute_button.Size = new System.Drawing.Size(411, 50);
			this.execute_button.TabIndex = 3;
			this.execute_button.Text = "Выполнить";
			this.execute_button.UseVisualStyleBackColor = true;
			this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
			// 
			// process_box
			// 
			this.process_box.Dock = System.Windows.Forms.DockStyle.Top;
			this.process_box.Location = new System.Drawing.Point(0, 0);
			this.process_box.Name = "process_box";
			this.process_box.Size = new System.Drawing.Size(413, 299);
			this.process_box.TabIndex = 2;
			this.process_box.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 362);
			this.Controls.Add(this.execute_button);
			this.Controls.Add(this.process_box);
			this.Name = "Form1";
			this.Text = "Практика 10";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button execute_button;
		private System.Windows.Forms.RichTextBox process_box;
	}
}

