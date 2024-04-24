namespace WinTrust_Secure_Checker
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
            PN_Title = new Panel();
            cButton2 = new Custom_Controls.CButton();
            cButton1 = new Custom_Controls.CButton();
            PB_Icon = new PictureBox();
            LB_Form_Text = new Label();
            cDragForm1 = new Custom_Controls.CDragForm();
            cDragForm2 = new Custom_Controls.CDragForm();
            cDragForm3 = new Custom_Controls.CDragForm();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            cButton3 = new Custom_Controls.CButton();
            openFileDialog1 = new OpenFileDialog();
            PN_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PN_Title
            // 
            PN_Title.BackColor = Color.Transparent;
            PN_Title.Controls.Add(cButton2);
            PN_Title.Controls.Add(cButton1);
            PN_Title.Controls.Add(PB_Icon);
            PN_Title.Controls.Add(LB_Form_Text);
            PN_Title.Dock = DockStyle.Top;
            PN_Title.Location = new Point(0, 0);
            PN_Title.Name = "PN_Title";
            PN_Title.Size = new Size(527, 38);
            PN_Title.TabIndex = 0;
            // 
            // cButton2
            // 
            cButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cButton2.ButtonHoveredColor1 = Color.FromArgb(58, 62, 68);
            cButton2.ButtonHoveredColor2 = Color.FromArgb(58, 62, 68);
            cButton2.ButtonNormalColor1 = Color.FromArgb(38, 42, 48);
            cButton2.ButtonNormalColor2 = Color.FromArgb(38, 42, 48);
            cButton2.ButtonPressedColor1 = Color.FromArgb(28, 32, 38);
            cButton2.ButtonPressedColor2 = Color.FromArgb(28, 32, 38);
            cButton2.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cButton2.Location = new Point(450, 4);
            cButton2.Name = "cButton2";
            cButton2.Size = new Size(34, 34);
            cButton2.StringTrimming = StringTrimming.EllipsisCharacter;
            cButton2.TabIndex = 2;
            cButton2.Text = "0";
            cButton2.TextHoveredColor = Color.Gainsboro;
            cButton2.TextNormalColor = Color.LightGray;
            cButton2.TextPressedColor = Color.Silver;
            cButton2.MouseClick += cButton2_MouseClick;
            // 
            // cButton1
            // 
            cButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cButton1.ButtonHoveredColor1 = Color.FromArgb(58, 62, 68);
            cButton1.ButtonHoveredColor2 = Color.FromArgb(58, 62, 68);
            cButton1.ButtonNormalColor1 = Color.FromArgb(38, 42, 48);
            cButton1.ButtonNormalColor2 = Color.FromArgb(38, 42, 48);
            cButton1.ButtonPressedColor1 = Color.FromArgb(28, 32, 38);
            cButton1.ButtonPressedColor2 = Color.FromArgb(28, 32, 38);
            cButton1.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cButton1.Location = new Point(490, 4);
            cButton1.Name = "cButton1";
            cButton1.Size = new Size(34, 34);
            cButton1.StringTrimming = StringTrimming.EllipsisCharacter;
            cButton1.TabIndex = 1;
            cButton1.Text = "r";
            cButton1.TextHoveredColor = Color.Gainsboro;
            cButton1.TextNormalColor = Color.LightGray;
            cButton1.TextPressedColor = Color.Silver;
            cButton1.MouseClick += cButton1_MouseClick;
            // 
            // PB_Icon
            // 
            PB_Icon.BackColor = Color.Transparent;
            PB_Icon.Location = new Point(10, 8);
            PB_Icon.Name = "PB_Icon";
            PB_Icon.Size = new Size(20, 20);
            PB_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            PB_Icon.TabIndex = 1;
            PB_Icon.TabStop = false;
            // 
            // LB_Form_Text
            // 
            LB_Form_Text.AutoSize = true;
            LB_Form_Text.BackColor = Color.Transparent;
            LB_Form_Text.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Form_Text.ForeColor = Color.LightGray;
            LB_Form_Text.Location = new Point(34, 9);
            LB_Form_Text.Name = "LB_Form_Text";
            LB_Form_Text.Size = new Size(92, 19);
            LB_Form_Text.TabIndex = 1;
            LB_Form_Text.Text = "LB_Form_Text";
            // 
            // cDragForm1
            // 
            cDragForm1.Form = this;
            cDragForm1.MaximizeFullScreen = false;
            cDragForm1.SupportMaximize = false;
            cDragForm1.TargetControl = PN_Title;
            // 
            // cDragForm2
            // 
            cDragForm2.Form = this;
            cDragForm2.MaximizeFullScreen = false;
            cDragForm2.SupportMaximize = false;
            cDragForm2.TargetControl = PB_Icon;
            // 
            // cDragForm3
            // 
            cDragForm3.Form = this;
            cDragForm3.MaximizeFullScreen = false;
            cDragForm3.SupportMaximize = false;
            cDragForm3.TargetControl = LB_Form_Text;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_file_100;
            pictureBox1.Location = new Point(34, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(38, 42, 48);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.BulletIndent = 1;
            richTextBox1.DetectUrls = false;
            richTextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.LightGray;
            richTextBox1.HideSelection = false;
            richTextBox1.Location = new Point(129, 64);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ShortcutsEnabled = false;
            richTextBox1.Size = new Size(363, 100);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "File Name:\nLocation:\nSize:\nDate creation:";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(30, 151);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 3;
            label1.Text = "Secure level:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(30, 177);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Unknown";
            // 
            // cButton3
            // 
            cButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cButton3.ButtonHoveredColor1 = Color.FromArgb(68, 72, 78);
            cButton3.ButtonHoveredColor2 = Color.FromArgb(68, 72, 78);
            cButton3.ButtonNormalColor1 = Color.FromArgb(58, 62, 68);
            cButton3.ButtonNormalColor2 = Color.FromArgb(58, 62, 68);
            cButton3.ButtonPressedColor1 = Color.FromArgb(48, 52, 58);
            cButton3.ButtonPressedColor2 = Color.FromArgb(48, 52, 58);
            cButton3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cButton3.Location = new Point(409, 170);
            cButton3.Name = "cButton3";
            cButton3.Size = new Size(83, 23);
            cButton3.StringTrimming = StringTrimming.EllipsisCharacter;
            cButton3.TabIndex = 3;
            cButton3.Text = "Check";
            cButton3.TextHoveredColor = Color.Gainsboro;
            cButton3.TextNormalColor = Color.LightGray;
            cButton3.TextPressedColor = Color.Silver;
            cButton3.MouseClick += cButton3_MouseClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Title = "Choose file to check signature";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(38, 42, 48);
            ClientSize = new Size(527, 237);
            Controls.Add(cButton3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(PN_Title);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinTrust Secure Checker";
            Load += Form1_Load;
            PN_Title.ResumeLayout(false);
            PN_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PN_Title;
        private Custom_Controls.CDragForm cDragForm1;
        private PictureBox PB_Icon;
        private Label LB_Form_Text;
        private Custom_Controls.CDragForm cDragForm2;
        private Custom_Controls.CDragForm cDragForm3;
        private Custom_Controls.CButton cButton1;
        private Custom_Controls.CButton cButton2;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Custom_Controls.CButton cButton3;
        private OpenFileDialog openFileDialog1;
    }
}
