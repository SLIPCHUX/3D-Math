namespace LR1_4
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button9 = new System.Windows.Forms.Button();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(6, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 49);
            this.button9.TabIndex = 4;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // xuiClock1
            // 
            this.xuiClock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(551, 6);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(120, 130);
            this.xuiClock1.TabIndex = 5;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.linkLabel1.Location = new System.Drawing.Point(232, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 22);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://diit.edu.ua";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 181);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(650, 376);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("http://diit.edu.ua", System.UriKind.Absolute);
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(674, 569);
            this.xuiFormDesign1.TabIndex = 8;
            this.xuiFormDesign1.TitleText = "Questions?";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiClock1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.linkLabel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.button9);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(674, 530);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 569);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private XanderUI.XUIFormDesign xuiFormDesign1;
    }
}