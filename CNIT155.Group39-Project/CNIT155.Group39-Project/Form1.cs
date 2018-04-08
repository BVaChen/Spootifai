/* --------------------------------------------------------------------------------------------
 * Group 39
 * Ben Chen, Grace Chen, Iris Chu, Jason Lam
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CNIT155.Group39_Project
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer Music = new WindowsMediaPlayer();
        private const int mSize = 30;
        private string[] mSongs = new string[mSize];
        private int mIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();

            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = Open.FileName;

                txtStuff.Text = fileName;
                Music.URL = fileName;
            }
        }


    }
    
}
