namespace Calendar
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbDays = new System.Windows.Forms.Label();
            this.eventLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.Location = new System.Drawing.Point(34, 23);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(57, 24);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "label1";
            this.lbDays.Click += new System.EventHandler(this.lbDays_Click);
            // 
            // eventLabel
            // 
            this.eventLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel.Location = new System.Drawing.Point(3, 47);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(172, 62);
            this.eventLabel.TabIndex = 1;
            this.eventLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eventLabel.Click += new System.EventHandler(this.eventLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.lbDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(175, 109);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
