
namespace Gym
{
    partial class frmmessag
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
            this.lbltext = new DevComponents.DotNetBar.LabelX();
            this.picyes = new System.Windows.Forms.PictureBox();
            this.picno = new System.Windows.Forms.PictureBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picno)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltext
            // 
            this.lbltext.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbltext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbltext.Location = new System.Drawing.Point(3, 3);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(384, 63);
            this.lbltext.TabIndex = 19;
            this.lbltext.Text = "روز";
            this.lbltext.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // picyes
            // 
            this.picyes.BackColor = System.Drawing.Color.Transparent;
            this.picyes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picyes.Image = global::Gym.Properties.Resources.thin_0154_ok_successful_check;
            this.picyes.Location = new System.Drawing.Point(211, 81);
            this.picyes.Name = "picyes";
            this.picyes.Size = new System.Drawing.Size(51, 50);
            this.picyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picyes.TabIndex = 21;
            this.picyes.TabStop = false;
            this.picyes.Visible = false;
            this.picyes.Click += new System.EventHandler(this.picyes_Click);
            // 
            // picno
            // 
            this.picno.BackColor = System.Drawing.Color.Transparent;
            this.picno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picno.Image = global::Gym.Properties.Resources.thin_0060_error_warning_danger_stop_delete_exit;
            this.picno.Location = new System.Drawing.Point(128, 81);
            this.picno.Name = "picno";
            this.picno.Size = new System.Drawing.Size(51, 50);
            this.picno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picno.TabIndex = 20;
            this.picno.TabStop = false;
            this.picno.Visible = false;
            this.picno.Click += new System.EventHandler(this.picno_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.picyes);
            this.groupPanel1.Controls.Add(this.lbltext);
            this.groupPanel1.Controls.Add(this.picno);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 13);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(396, 157);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 22;
            this.groupPanel1.Text = "پیغام";
            // 
            // frmmessag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 182);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmessag";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmmessag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picno)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.LabelX lbltext;
        public System.Windows.Forms.PictureBox picno;
        public System.Windows.Forms.PictureBox picyes;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
    }
}