using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUnionBuildingLoans
{
    public partial class FormDisplay : Form
    {
        public static FormDisplay accessF;
        public DataGridView dgvl;
        public FormDisplay()
        {
            InitializeComponent();
            accessF = this;
            dgvl = dgvLoans;

        }

        private void FormInput_Load(object sender, EventArgs e)
        {

        }
    }
}
