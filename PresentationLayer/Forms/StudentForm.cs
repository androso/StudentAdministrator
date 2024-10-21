using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class StudentForm : Form
    {
        private readonly StudentService _studentService;
        private readonly CareerService _careerService;
        bool isEdit = false;

        public StudentForm()
        {
            _studentService = new StudentService();
            _careerService = new CareerService();
            InitializeComponent();
            loadStudentsData();
        }

        private void loadStudentsData()
        {
            dgvStudents.DataSource = _studentService.GetAllStudents();
        }
        private void loadCbxCareers()
        {
            cbxCareerStudent.DataSource = _careerService.GetAllCareers();
            cbxCareerStudent.DisplayMember = "nameCareer";
            cbxCareerStudent.ValueMember = "idCareer";
        }
    }
}
