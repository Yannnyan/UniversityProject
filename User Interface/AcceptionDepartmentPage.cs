using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class AcceptionDepartmentPage : Form
    {
        public AcceptionDepartmentPage()
        {
            InitializeComponent();
        }

        private void goHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
