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
using System.IO;

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

        private void radShuffle_CheckedChanged(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = lstOutput.Items;
            Random random = new Random();
            int w;
            w = list.Count;
            lstOutput.BeginUpdate();
            while (w>1)
            {
                w--;
                int next;
                next = random.Next(w + 1);
                object value = list[next];
                list[next] = list[w];
                list[w] = value;
            }
            lstOutput.EndUpdate();
            lstOutput.Invalidate();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter SW = null;
            int ctr;
            SW = new StreamWriter("filename.txt");
            for (ctr = 0; ctr < mIndex; ctr++)
            {
                SW.WriteLine(mSongs[ctr]);
            }
            SW.Close();
        }
    }
    }
    
}
