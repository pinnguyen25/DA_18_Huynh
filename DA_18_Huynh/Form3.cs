using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_18_Huynh
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // Xử lý sự kiện để giải phương trình bậc nhất
        private void btnPT1_18_Huynh_Click(object sender, EventArgs e)
        {
            // Phân tích hệ số từ các ô văn bản
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);

            // Gọi phương thức GiaiPT1 để giải phương trình bậc nhất
            string ketqua = GiaiPT_18_Huynh.GiaiPT1(a, b);
            // Hiển thị kết quả trong ô văn bản kết quả
            txtKQ.Text = ketqua;
        }

        // Xử lý sự kiện để xóa đầu vào và đầu ra
        private void btnRS_18_Huynh_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtKQ.Clear();
        }

        // Xử lý sự kiện để giải phương trình bậc hai
        private void btnPT2_18_Huynh_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem hệ số c có được cung cấp không
            if (string.IsNullOrEmpty(txtC.Text))
            {
                MessageBox.Show("Hãy nhập hệ số c", "Bị thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Phân tích hệ số từ các ô văn bản
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);

            // Gọi phương thức GiaiPT2 để giải phương trình bậc hai
            string ketqua = GiaiPT_18_Huynh.GiaiPT2(a, b, c);
            // Hiển thị kết quả trong ô văn bản kết quả
            txtKQ.Text = ketqua;
        }
    }
}
