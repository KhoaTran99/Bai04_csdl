using Bai04_csdl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04_csdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // khởi tạo đối tượng đại diện cho Database
            ModelStudentDB context = new ModelStudentDB();
            //tạo danh sách khoa
            List<Faculty> listFaculty = context.Faculties.ToList();
            // tạo danh sách sinh viên
            List<Student> students = context.Students.ToList();


            //tạo phương thức lấy dữ liệu đổ vào combobox khoa viện
            fillCBBKhoa(listFaculty);
            // Tạo phương thức đổ dữ liệu vào dgv sinh viên
            fillDGVSinhvien(students);
        }

        private void fillDGVSinhvien(List<Student> students) // students là ds sinh viên
        {
            // xoá dữ liệu cũ
            dgvSinhVien.Rows.Clear();

            foreach (Student student in students)
            {
                // tạo dòng trống
                int indexRow = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[indexRow].Cells[0].Value = student.FacultyID;
                dgvSinhVien.Rows[indexRow].Cells[1].Value = student.StudentName;
                dgvSinhVien.Rows[indexRow].Cells[2].Value = student.AveregeScore;
                
                dgvSinhVien.Rows[indexRow].Cells[3].Value = student.Faculty.FacultyName;
                dgvSinhVien.Rows[indexRow].Cells[4].Value = student.Gioitinh;
            }




        }

        private void fillCBBKhoa(List<Faculty> listFaculty)
        {
            cbbKhoa.DataSource = listFaculty;
            cbbKhoa.DisplayMember = "FacultyName";
            cbbKhoa.ValueMember = "FacultyID";
        }
    }
}
