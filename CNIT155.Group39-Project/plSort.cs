using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNIT155.Group39_Project
{
    public partial class plSort : Form
    {
        public string sortType { get; set; }
        public string sortCrit { get; set; }
        public plSort()
        {
            InitializeComponent();
        }

        private void SortCriteria()
        {
            if (radArtist.Checked == true)
            {
                sortType = "art";
            }
            if (radDuration.Checked == true)
            {
                sortType = "dur";
            }
            sortType = "ttl";
        }
        private void btnAsc_Click(object sender, EventArgs e)
        {
            sortCrit = "asc";
            SortCriteria();
        }

        private void btnDsc_Click(object sender, EventArgs e)
        {
            sortCrit = "dsc";
            SortCriteria();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
