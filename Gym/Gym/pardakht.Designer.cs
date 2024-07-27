
namespace Gym
{
    partial class pardakht
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtmablagh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblday = new DevComponents.DotNetBar.LabelX();
            this.cmdsall = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmdmah = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmdday = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.etebardate = new DevComponents.DotNetBar.LabelX();
            this.btnpardakht = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnpardakht);
            this.groupPanel1.Controls.Add(this.cmdsall);
            this.groupPanel1.Controls.Add(this.cmdmah);
            this.groupPanel1.Controls.Add(this.cmdday);
            this.groupPanel1.Controls.Add(this.etebardate);
            this.groupPanel1.Controls.Add(this.lblday);
            this.groupPanel1.Controls.Add(this.txtmablagh);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(360, 181);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "شهریه";
            // 
            // txtmablagh
            // 
            // 
            // 
            // 
            this.txtmablagh.Border.Class = "TextBoxBorder";
            this.txtmablagh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmablagh.Location = new System.Drawing.Point(18, 18);
            this.txtmablagh.Name = "txtmablagh";
            this.txtmablagh.PreventEnterBeep = true;
            this.txtmablagh.Size = new System.Drawing.Size(217, 22);
            this.txtmablagh.TabIndex = 1;
            this.txtmablagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmablagh.WatermarkText = "0";
            this.txtmablagh.TextChanged += new System.EventHandler(this.txtmablagh_TextChanged);
            this.txtmablagh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmablagh_KeyPress);
            // 
            // lblday
            // 
            this.lblday.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblday.Location = new System.Drawing.Point(269, 16);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(66, 23);
            this.lblday.TabIndex = 19;
            this.lblday.Text = "مبلغ:";
            this.lblday.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cmdsall
            // 
            this.cmdsall.DisplayMember = "Text";
            this.cmdsall.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmdsall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdsall.FormattingEnabled = true;
            this.cmdsall.ItemHeight = 17;
            this.cmdsall.Location = new System.Drawing.Point(17, 59);
            this.cmdsall.Name = "cmdsall";
            this.cmdsall.Size = new System.Drawing.Size(78, 23);
            this.cmdsall.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdsall.TabIndex = 23;
            // 
            // cmdmah
            // 
            this.cmdmah.DisplayMember = "Text";
            this.cmdmah.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmdmah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdmah.FormattingEnabled = true;
            this.cmdmah.ItemHeight = 17;
            this.cmdmah.Location = new System.Drawing.Point(101, 58);
            this.cmdmah.Name = "cmdmah";
            this.cmdmah.Size = new System.Drawing.Size(66, 23);
            this.cmdmah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdmah.TabIndex = 22;
            // 
            // cmdday
            // 
            this.cmdday.DisplayMember = "Text";
            this.cmdday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmdday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdday.FormattingEnabled = true;
            this.cmdday.ItemHeight = 17;
            this.cmdday.Location = new System.Drawing.Point(173, 58);
            this.cmdday.Name = "cmdday";
            this.cmdday.Size = new System.Drawing.Size(62, 23);
            this.cmdday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdday.TabIndex = 21;
            // 
            // etebardate
            // 
            this.etebardate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.etebardate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etebardate.Location = new System.Drawing.Point(269, 58);
            this.etebardate.Name = "etebardate";
            this.etebardate.Size = new System.Drawing.Size(66, 24);
            this.etebardate.TabIndex = 20;
            this.etebardate.Text = "تمدید اعتبار تا:";
            // 
            // btnpardakht
            // 
            this.btnpardakht.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnpardakht.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnpardakht.Location = new System.Drawing.Point(18, 98);
            this.btnpardakht.Name = "btnpardakht";
            this.btnpardakht.Size = new System.Drawing.Size(317, 38);
            this.btnpardakht.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnpardakht.TabIndex = 24;
            this.btnpardakht.Text = "پرداخت شهریه";
            this.btnpardakht.Click += new System.EventHandler(this.btnpardakht_Click);
            // 
            // pardakht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 207);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pardakht";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرداخت شهریه";
            this.Load += new System.EventHandler(this.pardakht_Load);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmablagh;
        public DevComponents.DotNetBar.LabelX lblday;
        private DevComponents.DotNetBar.LabelX etebardate;
        private DevComponents.DotNetBar.ButtonX btnpardakht;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmdsall;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmdmah;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmdday;
    }
}