using WinTrust_Library;
namespace WinTrust_Secure_Checker
{
    // From documentation:
    //https://learn.microsoft.com/en-us/windows/win32/api/wintrust/nf-wintrust-winverifytrust

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(0, 168, 148)), 1), 0, 0, Width - 1, Height - 1);
            base.OnPaint(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PB_Icon.Image = Icon.ToBitmap();
            LB_Form_Text.Text = Text;
        }

        private void cButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Close();
        }

        private void cButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) WindowState = FormWindowState.Minimized;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            cButton1.Location = new Point(Width - 38, 4);
            cButton2.Location = new Point(Width - cButton1.Width - 38, 4);
            base.OnClientSizeChanged(e);
        }

        private void cButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                openFileDialog1.Filter = "All files |*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var checkfs = WinTrust_Library.WinTrust.GetFileWinVerifyTrustResult(openFileDialog1.FileName);
                    FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                    richTextBox1.Text = "File name: " + fileInfo.Name + "\n\n" + "Location: " + fileInfo.DirectoryName + "\n\n" + "Size: " + ConvertSizeString(fileInfo.Length) + " Bytes\n\n" +
                        "Createion time: " + fileInfo.CreationTime;
                    label2.Text = WinTrust.ToDefinitionString((uint)checkfs);
                    label2.ForeColor= System.Drawing.ColorTranslator.FromHtml(ToColorCodeString((uint)checkfs));
                }
            }
        }


        public static string ConvertSizeString(long bytes)
        {
            string[] units = { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            int unitIndex = 0;
            double size = bytes;
            while (size >= 1024 && unitIndex < units.Length - 1)
            {
                size /= 1024;
                unitIndex++;
            }

            return $"{size:0.00} {units[unitIndex]}";
        }

        //Chuyển sang Hex
        public static string ToColorCodeString(uint trustCode)
        {
            switch (trustCode)
            {
                case 0u:
                    return "#00FF00"; // Green (Success)
                case 0x800B0100u:
                    return "#FFFF00"; // Yellow (No signature)
                case 0x800B0004u:
                    return "#FF0000"; // Red (Subject not trusted)
                case 0x800B0001u:
                case 0x800B0002u:
                    return "#FFA500"; // Orange (Unknown provider/action)
                case 0x800B0003u:
                    return "#FF00FF"; // Magenta (Unknown subject form)
                case 0x80092026u:
                    return "#0000FF"; // Blue (Security settings error)
                case 0x80092003u:
                    return "#8B0000"; // Dark Red (File error)
                default:
                    return "#808080"; // Grey (Unknown error code)
            }
        }
    }
}
