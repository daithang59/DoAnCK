using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
namespace Demo_UIDangKy
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, @"^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkPassword(string pw)
        {
            return Regex.IsMatch(pw, @"^[a-zA-Z0-9!@#$%^&*()_+]{6,24}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[\w.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void bt_registry_Click(object sender, EventArgs e)
        {
            string tentk = tb_username.Text;
            string matkhau = tb_password.Text;
            string email = tb_gmail.Text;
            if(!checkAccount(tentk))
            {
                MessageBox.Show("Tên tài khoản không hợp lệ. Vui lòng nhập tên tài khoản dài 6-24 kí tự, với các kí tự chữ và số, hoa và thường");
                return;
            }
            if (!checkPassword(matkhau))
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Vui lòng nhập mật khẩu dài 6-24 kí tự, với các kí tự chữ và số, hoa và thường");
                return;
            }
            if(tb_confirmpassword.Text != matkhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp");
                return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            if(modify.TaiKhoans("select * from TaiKhoan where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí, vui lòng đăng kí Email khác.","Thông báo", MessageBoxButtons.RetryCancel);
                return;
            }
            try
            {
                string query = "insert into TaiKhoan values ('" + tentk + "', '" + matkhau + "','" + email + "')";
                modify.Command(query);
                MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên tài khoản này đã tồn tại, vui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.RetryCancel);
            }
}
    }
}
