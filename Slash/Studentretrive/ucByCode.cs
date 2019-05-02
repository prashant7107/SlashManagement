using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Slash.Studentretrive
{
    public partial class ucByCode : UserControl
    {
        public ucByCode()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            dgvStudents.DataSource = GlobalClass.StudentRetrive.StudentRetriveCOde(txtCode.Text);
            dgvStudents.Columns["Id"].Visible = false;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var _idget = (dgvStudents.CurrentRow.Cells["Id"].Value);
                int _id = (int)_idget;
                frmStudentParticular std = new frmStudentParticular();
                std.txtGetData.Text = _id.ToString();
                std.Show();
            }
        }
    }
}
