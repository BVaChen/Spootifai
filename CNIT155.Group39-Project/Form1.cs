/* --------------------------------------------------------------------------------------------
 * Group 39
 * Ben Chen, Grace Chen, Iris Chu, Jason Lam
 * 
 * 
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.IO;

namespace CNIT155.Group39_Project
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer Music = new WindowsMediaPlayer();
        private const int mSize = 30;
        private string[] mSongs = new string[mSize]; //song titles
        private string[] mDurations = new string[mSize]; // list of song durations
        private string[] mSongLocation = new string[mSize]; // path to file
        private string[] mPlaying = new string[mSize]; //used for "Playing indicator"
        private string[] mArtist = new string[mSize]; //song artists, if applicable
        private int mIndex = 0;
        private int mCurrentArrIndex = 0;
        Random rndIndex = new Random(); //by declaring this here system clock isn't as much a factor
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trkVolume.Value = 50;
            Music.settings.volume = trkVolume.Value;
            radDefaultPlay.Checked = true;
            AddColumnHeaders();
        }

        //
        //Open button
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Multiselect = true;
            Open.Title = "Select music to add...";

            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                foreach (String fileName in Open.FileNames)
                {
                    //string fileName = Open.FileName;
                    Music.URL = fileName;

                    mSongs[mIndex] = Music.currentMedia.name;
                    mDurations[mIndex] = Music.controls.currentItem.durationString;
                    mPlaying[mIndex] = "";
                    mSongLocation[mIndex] = fileName;
                    mArtist[mIndex] = Music.currentMedia.durationString;


                    //8 12 16
                    lstPlaylist.Items.Add(mPlaying[mIndex].PadRight(10) + mArtist[mIndex].PadRight(14) + mSongs[mIndex].PadRight(40) + mDurations[mIndex]);

                    mIndex++;
                }
                Music.controls.stop();

            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //Initialize the open-file dialog.
            OpenFileDialog Open = new OpenFileDialog();
            Open.Multiselect = false;
            Open.Title = "Select a playlist to add...";
            Open.DefaultExt = ".39mp"; //Default ext to look for
            Open.Filter = "Super Proprietary Format™ 39MP (*.39mp)|*.39mp"; //filter files
            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader plFileRead = new StreamReader(Open.FileName);
                string line;
                if (plFileRead.ReadLine() != "MP39PlaylistFile") //check and ignore first if valid
                {
                    MessageBox.Show("The playlist file is not a valid Super Proprietary Format™ 39MP Playlist File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    plFileRead.Close();
                    return;
                }
                while (plFileRead.Peek() != -1)
                {
                    line = plFileRead.ReadLine();
                    string[] parts = line.Split('\t');
                    mSongs[mIndex] = parts[0];
                    mSongLocation[mIndex] = parts[1];
                    mDurations[mIndex] = parts[2];
                    mArtist[mIndex] = parts[2];
                    mPlaying[mIndex] = "";
                    mIndex++;
                }
                plFileRead.Close();
                for (int ctr = 0; ctr < mIndex; ctr++)
                {
                    lstPlaylist.Items.Add(mPlaying[ctr].PadRight(10) + mArtist[ctr].PadRight(14) + mSongs[ctr].PadRight(40) + mDurations[ctr]);
                }
            }
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    lvwPlaylist.Items.Clear();
        //    for (int ctr = 0; ctr < mIndex; ctr++)
        //    {
        //        if (mSongs[ctr].Contains(txtStuff.Text))
        //        {
        //            Console.WriteLine("lol");

        //        }
        //    }
        //}

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //PAUSE
            if (Music.playState == (WMPPlayState)3) //playing
            {
                Music.controls.pause();
                return;
            }
            //PLAY
            if (Music.playState == (WMPPlayState)2) //paused
            {
                Music.controls.play();
                return;
            }
            //mPlaying[lvwPlaylist.SelectedIndices[0]] = ">>";

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Music.controls.stop();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            Music.controls.stop();
            if (mCurrentArrIndex == mSize) return;
            mCurrentArrIndex++;
            Music.URL = mSongLocation[mCurrentArrIndex];
            Music.controls.play();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            Music.controls.stop();
            if (mCurrentArrIndex == 0) return;
            mCurrentArrIndex--;
            Music.URL = mSongLocation[mCurrentArrIndex];
            Music.controls.play();
        }

        //private void trkPlayTime_ValueChanged(object sender, EventArgs e)
        //{

        //    double duration = Music.currentMedia.duration;
        //    double fraction = trkPlayTime.Value;
        //    double settime = fraction / trkPlayTime.Maximum;
        //    double lol = settime * duration;
        //    Music.controls.currentPosition = lol;
        //    //Music.controls.play();
        //    Console.WriteLine(settime + "   /  " + duration);
        //}
        private void trkPlayTime_Scroll(object sender, EventArgs e)
        {
            double duration = Music.currentMedia.duration;
            double fraction = trkPlayTime.Value;
            double settime = fraction / trkPlayTime.Maximum;
            double lol = settime * duration;
            Music.controls.currentPosition = lol;
            //Music.controls.play();
            Console.WriteLine(settime + "   /  " + duration);
        }

        private void trkVolume_ValueChanged(object sender, EventArgs e)
        {
            Music.settings.volume = trkVolume.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Super Proprietary™ Playlist (*.39mp)|*.39mp";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter playlistWrite = new StreamWriter(saveFile.FileName);
                playlistWrite.WriteLine("MP39PlaylistFile");
                for (int ctr = 0; ctr < mIndex; ctr++)
                {
                    playlistWrite.WriteLine(mSongs[ctr] + "\t" + mSongLocation[ctr] + "\t" + mDurations[ctr]);
                }
                playlistWrite.Close();
            }

        }

        private void txtStuff_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Clear all items in playlist? Unsaved changes will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            for (int ctr = 0; ctr < mIndex; ctr++)
            {
                mSongs[ctr] = null;
                mDurations[ctr] = null;
                mPlaying[ctr] = null;
            }
            mIndex = 0;
            lstPlaylist.Items.Clear();
            AddColumnHeaders();


        }


        private void PlaybackModeCheck()
        {
            if (radRpt1ce.Checked == true)
            {
                Music.URL = mSongLocation[mCurrentArrIndex];
                Music.controls.play();
            }
            if (radRptList.Checked == true)
            {
                if (mCurrentArrIndex == mIndex)
                {
                    mCurrentArrIndex = 0; //to the beginning
                }
                else
                {
                    mCurrentArrIndex++;
                }
                Music.URL = mSongLocation[mCurrentArrIndex];
                Music.controls.play();
            }
            if (radShuffle.Checked == true)
            {
                mCurrentArrIndex = rndIndex.Next(0, mIndex);
                Music.URL = mSongLocation[mCurrentArrIndex]; //this finds a random index between 0 and mIndex
                Music.controls.play();
            }
            if (radDefaultPlay.Checked == true)
            {
                if (mCurrentArrIndex == mIndex)
                {
                    return;
                }
                mCurrentArrIndex++;
                Music.URL = mSongLocation[mCurrentArrIndex]; //to next file
                Music.controls.play();
            }
        }



        private void btnSort_Click_1(object sender, EventArgs e)
        {
            plSort sort = new plSort();
            sort.ShowDialog();
            string plcompare = sort.sortCrit;


            if (sort.sortType == "ttl")
            {

                for (int pass = 0; pass < mIndex-1; pass++)
                {
                    for (int ctr = 0; ctr < mIndex; ctr++)
                    {
                        if (string.Compare(mSongs[ctr], mSongs[ctr + 1]) == 1)
                        {
                            string tmpttl = mSongs[ctr];
                            mSongs[ctr + 1] = mSongs[ctr];
                            mSongs[ctr] = tmpttl;

                            string tmppath = mSongLocation[ctr];
                            mSongLocation[ctr + 1] = mSongLocation[ctr];
                            mSongLocation[ctr] = tmppath;

                            string tmpDuration = mDurations[ctr];
                            mDurations[ctr + 1] = mDurations[ctr];
                            mDurations[ctr] = tmpDuration;


                        }
                    }
                }
            }
            //refresh the boxlist
            lstPlaylist.Items.Clear();
            AddColumnHeaders();
            for (int ctr = 0; ctr < mIndex; ctr++)
            {
                lstPlaylist.Items.Add(mPlaying[ctr].PadRight(10) + mArtist[ctr].PadRight(14) + mSongs[ctr].PadRight(40) + mDurations[ctr]);
            }
        }

        //not explicitly a button
        private void lstPlaylist_DoubleClick(object sender, EventArgs e)
        {
            mCurrentArrIndex = lstPlaylist.SelectedIndex-2;
            if (lstPlaylist.SelectedIndex < 2) return;


            Music.URL = mSongLocation[mCurrentArrIndex]; 
            Music.controls.play();
        }

        //unhelpful methods
        private void AddColumnHeaders()
        {
            lstPlaylist.Items.Add("Playing".PadRight(10) + "Artist".PadRight(14) + "Title".PadRight(40) + "Duration");
            lstPlaylist.Items.Add("============================================================================");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Music.playState == (WMPPlayState)3)
            {
                double incValue = (Music.controls.currentPosition / Music.currentMedia.duration) * trkPlayTime.Maximum;
                int sldk = (int)Math.Round(incValue);
                Console.WriteLine("Value:" + incValue + " " + sldk);
                trkPlayTime.Value = Clamp(sldk, trkPlayTime.Minimum, trkPlayTime.Maximum);
            }
            if (Music.playState == (WMPPlayState)1)
            {
                PlaybackModeCheck();
            }
        }
        public static int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }
    }
    
}
