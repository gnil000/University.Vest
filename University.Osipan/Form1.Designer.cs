namespace University.Osipan
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			richTextBox1 = new RichTextBox();
			label1 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(590, 240);
			button1.Name = "button1";
			button1.Size = new Size(165, 49);
			button1.TabIndex = 0;
			button1.Text = "Зашифровать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(194, 34);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(561, 84);
			richTextBox1.TabIndex = 1;
			richTextBox1.Text = "";
			richTextBox1.TextChanged += richTextBox1_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 34);
			label1.Name = "label1";
			label1.Size = new Size(161, 15);
			label1.TabIndex = 2;
			label1.Text = "Сообщение для шифровки:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 257);
			label3.Name = "label3";
			label3.Size = new Size(106, 15);
			label3.TabIndex = 4;
			label3.Text = "Приватный ключ:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 135);
			label4.Name = "label4";
			label4.Size = new Size(170, 15);
			label4.TabIndex = 5;
			label4.Text = "Зашифрованное сообщение:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 150);
			label5.Name = "label5";
			label5.Size = new Size(0, 15);
			label5.TabIndex = 6;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(12, 272);
			label7.Name = "label7";
			label7.Size = new Size(31, 15);
			label7.TabIndex = 8;
			label7.Text = "2314";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(12, 193);
			label8.Name = "label8";
			label8.Size = new Size(176, 15);
			label8.TabIndex = 9;
			label8.Text = "Расшифрованное сообщение:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(12, 208);
			label9.Name = "label9";
			label9.Size = new Size(0, 15);
			label9.TabIndex = 10;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(764, 296);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(richTextBox1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private RichTextBox richTextBox1;
		private Label label1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label7;
		private Label label8;
		private Label label9;
	}
}
