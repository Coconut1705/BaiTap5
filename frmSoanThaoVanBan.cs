using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap5
{
    public partial class frmSoanThaoVanBan : Form
    {
        public frmSoanThaoVanBan()
        {
            InitializeComponent();
        }

        private void frmSoanThaoVanBan_Load(object sender, EventArgs e)
        {
            loadFont(); 
            loadSize(); 
            rtbVanBan.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void loadFont()
        {
            foreach (FontFamily fontFamily in new InstalledFontCollection().Families)
            {
                cmbFont.Items.Add(fontFamily.Name);
            }
            cmbFont.SelectedItem = "Tahoma";
        }

        private void loadSize()
        {
            int[] sizeValues = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            cmbSize.ComboBox.DataSource = sizeValues;
            cmbSize.SelectedItem = 14;
        }

        private void toolStripMenuItemOpenFile_Click(object sender, EventArgs e)
        {
            rtbVanBan.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                try
                {
                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbVanBan.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtbVanBan.LoadFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }
                    MessageBox.Show("Tập tin đã được mở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình mở tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style; if (rtbVanBan.SelectionFont.Bold)
                {
                    style &= ~FontStyle.Bold;
                }
                else
                {
                    style |= FontStyle.Bold;
                }
                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;
                if (rtbVanBan.SelectionFont.Underline)
                {
                    style &= ~FontStyle.Underline;  // Nếu đã gạch chân, bỏ gạch chân
                }
                else
                {
                    style |= FontStyle.Underline;  // Nếu chưa gạch chân, thêm gạch chân
                }
                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }

        private void btnIttalic_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;
                if (rtbVanBan.SelectionFont.Italic)
                {
                    style &= ~FontStyle.Italic;  // Nếu đã in nghiêng, bỏ in nghiêng
                }
                else
                {
                    style |= FontStyle.Italic;  // Nếu chưa in nghiêng, thêm in nghiêng
                }
                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Xóa nội dung hiện tại trong RichTextBox
            rtbVanBan.Clear();

            // Đặt lại font mặc định cho RichTextBox
            rtbVanBan.Font = new Font("Tahoma", 14, FontStyle.Regular);

            // Đặt lại cỡ chữ mặc định cho ComboBox Size
            cmbSize.SelectedItem = 14;

            // Đặt lại font mặc định cho ComboBox Font
            cmbFont.SelectedItem = "Tahoma";
        }

        private string currentFilePath = null; // Biến lưu đường dẫn của tập tin hiện tại (null nếu chưa lưu)

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath)) // Kiểm tra nếu văn bản chưa được lưu trước đó
            {
                // Nếu là văn bản mới, hiển thị hộp thoại lưu tập tin
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "RichText files (*.rtf)|*.rtf"; // Chỉ cho phép lưu tập tin với định dạng .rtf
                saveFileDialog.DefaultExt = "rtf"; // Đặt phần mở rộng mặc định là .rtf
                saveFileDialog.AddExtension = true; // Tự động thêm phần mở rộng .rtf nếu người dùng không nhập

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lưu nội dung vào tập tin được chọn
                        currentFilePath = saveFileDialog.FileName; // Lưu đường dẫn của tập tin
                        rtbVanBan.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                        MessageBox.Show("Văn bản đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Nếu văn bản đã được lưu trước đó, chỉ cần lưu lại nội dung vào tập tin hiện tại
                try
                {
                    rtbVanBan.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Văn bản đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
