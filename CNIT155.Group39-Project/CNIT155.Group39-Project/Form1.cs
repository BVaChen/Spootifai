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
            //Import button is also Enter button
            OpenFileDialog Open = new OpenFileDialog();

            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = Open.FileName;
                //lstOutput.Items.Add(fileName);
                txtStuff.Text = fileName;
                Music.URL = fileName;

                mSongs[mIndex] = fileName;
                mIndex++;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStuff.Text = "";
            lstOutput.Items.Clear();
            radShuffle.Enabled = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            for (int ctr = 0; ctr < mIndex; ctr++)
            {
                lstOutput.Items.Add(mSongs[ctr]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            for (int ctr = 0; ctr < mIndex; ctr++)
            {
                if (mSongs[ctr].Contains(txtStuff.Text))
                {
                    lstOutput.Items.Add(mSongs[ctr]);

                }
            }
        }
    }
    
}
