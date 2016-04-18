namespace TimeTracker
{
    partial class frm_Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txt_Task = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Detail = new System.Windows.Forms.TextBox();
            this.txt_Time_start = new System.Windows.Forms.MaskedTextBox();
            this.txt_Time_end = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Time Tracker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // txt_Task
            // 
            this.txt_Task.Location = new System.Drawing.Point(149, 29);
            this.txt_Task.Multiline = true;
            this.txt_Task.Name = "txt_Task";
            this.txt_Task.Size = new System.Drawing.Size(328, 46);
            this.txt_Task.TabIndex = 1;
            this.txt_Task.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(834, 81);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(46, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detail";
            // 
            // txt_Detail
            // 
            this.txt_Detail.AcceptsReturn = true;
            this.txt_Detail.AcceptsTab = true;
            this.txt_Detail.Location = new System.Drawing.Point(495, 29);
            this.txt_Detail.Multiline = true;
            this.txt_Detail.Name = "txt_Detail";
            this.txt_Detail.Size = new System.Drawing.Size(385, 46);
            this.txt_Detail.TabIndex = 7;
            // 
            // txt_Time_start
            // 
            this.txt_Time_start.Location = new System.Drawing.Point(16, 29);
            this.txt_Time_start.Name = "txt_Time_start";
            this.txt_Time_start.Size = new System.Drawing.Size(108, 20);
            this.txt_Time_start.TabIndex = 0;
            // 
            // txt_Time_end
            // 
            this.txt_Time_end.Location = new System.Drawing.Point(16, 55);
            this.txt_Time_end.Name = "txt_Time_end";
            this.txt_Time_end.Size = new System.Drawing.Size(108, 20);
            this.txt_Time_end.TabIndex = 1;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 115);
            this.Controls.Add(this.txt_Time_end);
            this.Controls.Add(this.txt_Time_start);
            this.Controls.Add(this.txt_Detail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Task);
            this.Name = "frm_Home";
            this.Opacity = 0.95D;
            this.Text = "TimeTracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txt_Task;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Detail;
        private System.Windows.Forms.MaskedTextBox txt_Time_start;
        private System.Windows.Forms.MaskedTextBox txt_Time_end;
    }
}

