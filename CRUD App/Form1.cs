using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_App
{
    public partial class StudentDetails : Form
    {

        StudentDbDataContext db;
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void bindgridview()
        {
            db=new StudentDbDataContext();
            dataGridView1.DataSource = db.students;
             
        }

        private void clear()
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    TextBox txt = ctr as TextBox;
                    txt.Clear();

                }
            }

            nametxt.Focus();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            db = new StudentDbDataContext();
            student std = new student();
            std.NAME = nametxt.Text;
            std.GENDER = gendertxt.Text;
            std.AGE = int.Parse(agetxt.Text);
            std.STANDARD = int.Parse(classtxt.Text);
            db.students.InsertOnSubmit(std);
            db.SubmitChanges();
            MessageBox.Show("Successfully inserted Data","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clear();    
            bindgridview();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            bindgridview();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); 
            gendertxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            agetxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            classtxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            db = new StudentDbDataContext();
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
)
        }
    }
}
