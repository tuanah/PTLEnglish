namespace PTLEnglish
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
			this.cbCourse = new System.Windows.Forms.ComboBox();
			this.cbTopic = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lvWord = new System.Windows.Forms.ListView();
			this.lbl_Topic_Name = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbCourse
			// 
			this.cbCourse.FormattingEnabled = true;
			this.cbCourse.Location = new System.Drawing.Point(70, 44);
			this.cbCourse.Name = "cbCourse";
			this.cbCourse.Size = new System.Drawing.Size(151, 21);
			this.cbCourse.TabIndex = 0;
			this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
			// 
			// cbTopic
			// 
			this.cbTopic.FormattingEnabled = true;
			this.cbTopic.Location = new System.Drawing.Point(70, 85);
			this.cbTopic.Name = "cbTopic";
			this.cbTopic.Size = new System.Drawing.Size(151, 21);
			this.cbTopic.TabIndex = 1;
			this.cbTopic.SelectedIndexChanged += new System.EventHandler(this.cbTopic_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Course";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Topic";
			// 
			// lvWord
			// 
			this.lvWord.Location = new System.Drawing.Point(70, 122);
			this.lvWord.Name = "lvWord";
			this.lvWord.Size = new System.Drawing.Size(537, 340);
			this.lvWord.TabIndex = 4;
			this.lvWord.UseCompatibleStateImageBehavior = false;
			// 
			// lbl_Topic_Name
			// 
			this.lbl_Topic_Name.AutoSize = true;
			this.lbl_Topic_Name.Location = new System.Drawing.Point(262, 92);
			this.lbl_Topic_Name.Name = "lbl_Topic_Name";
			this.lbl_Topic_Name.Size = new System.Drawing.Size(35, 13);
			this.lbl_Topic_Name.TabIndex = 5;
			this.lbl_Topic_Name.Text = "label3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 474);
			this.Controls.Add(this.lbl_Topic_Name);
			this.Controls.Add(this.lvWord);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbTopic);
			this.Controls.Add(this.cbCourse);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbCourse;
		private System.Windows.Forms.ComboBox cbTopic;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView lvWord;
		private System.Windows.Forms.Label lbl_Topic_Name;
	}
}

