using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraCuuDiemSinhVien
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (string Name, string Diachi, string lop, double diem)> student = new Dictionary<string, (string, string, string,double)>
        {
            {"SV01",("Nguyen xuan thanh","Haiphong","D17cnpm5",8.0)},
            {"SV02",("Nguyen dinh hoan","Haiduong","D17cnpm5",9.2) },
            {"SV03",("Nguyen thi b","Hanoi","D17cnpm6",6.5) },
            {"SV04",("Nguyen van d","Namdinh","D17cnpm6",7.0) },
        };
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string studentID = txtID.Text;
            if (student.TryGetValue(studentID, out var studentInfo))
            {
                lblResult.Text = $"Thông tin sinh viên là:\n Mã sinh vien: {studentID}\n Tên sinh vien:{studentInfo.Name}\n Địa chỉ:{studentInfo.Diachi}\n Lớp:{studentInfo.lop}\n Điểm:{studentInfo.diem}";
            }
            else
            {
                lblResult.Text = "Không tìm thấy sinh viên nào!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
