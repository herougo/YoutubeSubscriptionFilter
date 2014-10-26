// http://i1.ytimg.com/vi/zjZmVC6KXNY/mqdefault.jpg

// NEXT STEPS
// incorporate thumbnails
// different deleting system
// "last day searched" box

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Google.YouTube;
using Google.GData.Client;
using Google.GData.YouTube;


namespace YoutubeVideoOrganizer
{
    public partial class Form1 : Form
    {
        string channelNamesPath = AppDomain.CurrentDomain.BaseDirectory + "ChannelNames.txt";
        string HPChannelNamesPath = AppDomain.CurrentDomain.BaseDirectory + "HPChannelNames.txt";
        string latestVideosPath = AppDomain.CurrentDomain.BaseDirectory + "LatestVideos.txt";
        string allEntriesPath = AppDomain.CurrentDomain.BaseDirectory + "AllEntries.txt";
        string[] channelNames = new string[100];
        string[] latestChannelVideos = new string[100];
        string[,] specifics = new string[100, 10];
        
        public Form1()
        {
            InitializeComponent();

            // Load Channel Names
            FileStream fs = new FileStream(channelNamesPath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            rTBAllChannelNames.Text = sr.ReadToEnd();

            sr.Close();
            fs.Close();

            // Load High Priority Channel Priority
            fs = new FileStream(HPChannelNamesPath, FileMode.Open);
            sr = new StreamReader(fs);

            rTBHPChannelNames.Text = sr.ReadToEnd();

            sr.Close();
            fs.Close();


            RefreshDGV();

            // dGVNewVideos.SelectionChanged += new EventHandler(dGVNewVideos_SelectionChanged);
        }        

        public void GetVideos()
        {
            var settings = new YouTubeRequestSettings("API_YouTube", 
                "AI39si5WA7mB2YVdMdstabh0A-aG8w44dcuKIhyisCCJDP_PbVzFdVT8uBJ760wbgqmZqE33XMRUbblrS0c1dhq3nWc5POg2TQ");
            int counter = 0;

            while (channelNames[counter] != null)
            {
                int index = 1;
                int pageSize = 50;
                
                string[] videoTitles = new string[1000];
                int[] videoDuration = new int[1000];
                string[] videoDate = new string[1000];
                string[] videoURL = new string[1000];

                string day;
                string month;
                string year;

                // Clear Videos
                int count = 0;
                while (videoTitles[count] != null)
                {
                    videoTitles[count] = null;
                    videoDuration[count] = 0;
                    videoDate[count] = null;
                    videoURL[count] = null;
                    count++;
                }

                #region Get Data

                var request = new YouTubeRequest (settings);
                var query = new YouTubeQuery("http://gdata.youtube.com/feeds/api/users/" + channelNames[counter] + "/uploads");
                
                query.OrderBy = "published";
                query.StartIndex = index;
                query.NumberToRetrieve = pageSize;
                
                Feed<Video> feed = null;

                try
                {
                    feed = request.Get<Video>(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error have occurred while retrieving data from YouTube: {0}", ex.Message);
                }
                
                if (feed != null && feed.Entries != null) 
                {
                    count = 0;
                    try
                    {
                        int videoCounter = 0;

                        foreach (var entry in feed.Entries)
                        {
                            string url = "http://www.youtube.com/watch?v=" + entry.VideoId.ToString();

                            if (url == latestChannelVideos[counter]) break;
                            else
                            {
                                if (videoCounter == 0) AddToLatestVideo(channelNames[counter], url);
                            }

                            if (specifics[counter, 0] != null)
                            {
                                // Check specifications
                                int tempCounter = 0;
                                bool matchSpecifics = false;
                                while (specifics[counter, tempCounter] != null)
                                {
                                    if (SearchString(entry.Title.ToUpper(), specifics[counter, tempCounter].ToUpper())) matchSpecifics = true;

                                    tempCounter++;
                                }

                                if (matchSpecifics)
                                {
                                    videoTitles[count] = entry.Title;
                                    videoDuration[count] = Convert.ToInt32(entry.YouTubeEntry.Duration.Seconds);
                                    videoDate[count] = entry.Updated.Date.ToString().Substring(0, InString(entry.Updated.Date.ToString(), " 12:00:00 AM"));

                                    // Edit date
                                    day = videoDate[count].Substring(0, InString(videoDate[count], "/"));
                                    videoDate[count] = videoDate[count].Substring(InString(videoDate[count], "/") + 1,
                                        videoDate[count].Length - (InString(videoDate[count], "/") + 1));
                                    month = videoDate[count].Substring(0, InString(videoDate[count], "/"));
                                    videoDate[count] = videoDate[count].Substring(InString(videoDate[count], "/") + 1,
                                        videoDate[count].Length - (InString(videoDate[count], "/") + 1));
                                    year = videoDate[count];
                                    videoDate[count] = month + "/" + day + "/" + year;
                                    
                                    videoURL[count] = "http://www.youtube.com/watch?v=" + entry.VideoId.ToString();
                                    count++;
                                }
                            }
                            else
                            {
                                videoTitles[count] = entry.Title;
                                videoDuration[count] = Convert.ToInt32(entry.YouTubeEntry.Duration.Seconds);
                                videoDate[count] = entry.Updated.Date.ToString().Substring(0, InString(entry.Updated.Date.ToString(), " 12:00:00 AM"));

                                // Edit date
                                day = videoDate[count].Substring(0, InString(videoDate[count], "/"));
                                videoDate[count] = videoDate[count].Substring(InString(videoDate[count], "/") + 1,
                                    videoDate[count].Length - (InString(videoDate[count], "/") + 1));
                                month = videoDate[count].Substring(0, InString(videoDate[count], "/"));
                                videoDate[count] = videoDate[count].Substring(InString(videoDate[count], "/") + 1,
                                    videoDate[count].Length - (InString(videoDate[count], "/") + 1));
                                year = videoDate[count];
                                videoDate[count] = month + "/" + day + "/" + year;

                                videoURL[count] = "http://www.youtube.com/watch?v=" + entry.VideoId.ToString();
                                count++;
                            }

                            videoCounter++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error have occurred while retrieving data from YouTube: {0}", ex.Message);
                        break;
                    }

                    if (count < pageSize)
                    {
                        // Success!
                    }

                    index = index + count + 1;
                }
                else
                {
                    MessageBox.Show("Error have occurred while retrieving data from YouTube.");
                    break;
                }

                #endregion
                
                // Show Videos
                count = 0;
                while (videoTitles[count] != null)
                {
                    AddRow(videoTitles[count], channelNames[counter], videoDuration[count], videoDate[count], videoURL[count]);
                    count++;
                }

                counter++;
            }
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateChannelNames();
            RefreshDGV();

            MessageBox.Show("Channel names have been updated!");
        }

        public void UpdateChannelNames()
        {
            string[] line = new string[100];
            int counter = 0;
            string channels = rTBAllChannelNames.Text;
            string entry;

            #region All Channels
            while (channels != "")
            {
                entry = "";                
                if (SearchString(channels, "\n"))
                {
                    entry = channels.Substring(0, InString(channels, "\n"));
                    channels = channels.Substring(InString(channels, "\n") + 1, channels.Length - (InString(channels, "\n") + 1));
                }
                else
                {
                    entry = channels;
                    channels = "";
                }

                if (entry.Trim() != "")
                {
                    line[counter] = entry.Trim();
                    counter++;
                }
            }
            
            FileStream fs = new FileStream(channelNamesPath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            counter = 0;
            while (line[counter] != null)
            {
                sw.WriteLine(line[counter]);
                counter++;
            }

            sw.Close();
            fs.Close();
            #endregion

            #region HP Channels
            for (int a = 0; a < 100; a++)
            {
                line[a] = null;
            }
            
            counter = 0;
            channels = rTBHPChannelNames.Text;

            while (channels != "")
            {

                entry = "";
                if (SearchString(channels, "\n"))
                {
                    entry = channels.Substring(0, InString(channels, "\n"));
                    channels = channels.Substring(InString(channels, "\n") + 1, channels.Length - (InString(channels, "\n") + 1));
                }
                else
                {
                    entry = channels;
                    channels = "";
                }

                if (entry.Trim() != "")
                {
                    line[counter] = entry.Trim();
                    counter++;
                }
            }

            fs = new FileStream(HPChannelNamesPath, FileMode.Create);
            sw = new StreamWriter(fs);

            counter = 0;
            while (line[counter] != null)
            {
                sw.WriteLine(line[counter]);
                counter++;
            }

            sw.Close();
            fs.Close();
            #endregion
        }

        public void AddRow(string title, string channel, int duration, string date, string link)
        {
            string minuteString = (duration / 60).ToString();
            if (minuteString.Length == 1) minuteString = "0" + minuteString;
            string secondString = (duration - (duration / 60) * 60).ToString();
            if (secondString.Length == 1) secondString = "0" + secondString;

            string durationString = minuteString + ":" + secondString;

            dGVNewVideos.Rows.Add(title, channel, durationString, date, link);

            FileStream fs = new FileStream(allEntriesPath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(title);
            sw.WriteLine(channel);
            sw.WriteLine(durationString);
            sw.WriteLine(date);
            sw.WriteLine(link);

            sw.Close();
            fs.Close();
        }

        public void RefreshDGV()
        {
            string[] line = new string[10000];
            int counter = 0;

            dGVAllResults.Rows.Clear();

            // Read Entries
            FileStream fs = new FileStream(allEntriesPath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (sr.Peek() != -1)
            {
                line[counter] = sr.ReadLine();
                counter++;
            }

            sr.Close();
            fs.Close();

            // All Entries
            counter = 0;
            while (line[counter] != null)
            {
                dGVAllResults.Rows.Add(line[counter], line[counter + 1], line[counter + 2], line[counter + 3], line[counter + 4]);

                counter += 5;
            }

            // High Priority Entries
            dGVHPResults.Rows.Clear();

            // Load Specifications
            string channelCollection = rTBHPChannelNames.Text;
            string[,] HPSpecifics = new string[100, 100];
            string[] HPChannelNames = new string[100];

            counter = 0;
            while (channelCollection != "")
            {
                if (SearchString(channelCollection, "\n"))
                {
                    string entry = channelCollection.Substring(0, InString(channelCollection, "\n"));
                    channelCollection = channelCollection.Substring(InString(channelCollection, "\n") + 1,
                        channelCollection.Length - (InString(channelCollection, "\n") + 1));

                    // Get name and specifics
                    if (SearchString(entry, ":"))
                    {
                        HPChannelNames[counter] = entry.Substring(0, InString(entry, ":"));

                        // Specifics
                        entry = entry.Substring(InString(entry, ":") + 1, entry.Length - (InString(entry, ":") + 1)).Trim();
                        int specificCounter = 0;
                        while (SearchString(entry, ","))
                        {
                            HPSpecifics[counter, specificCounter] = entry.Substring(0, InString(entry, ","));
                            entry = entry.Substring(InString(entry, ",") + 1, entry.Length - (InString(entry, ",") + 1)).Trim();

                            specificCounter++;
                        }
                        HPSpecifics[counter, specificCounter] = entry;

                    }
                    else
                    {
                        HPChannelNames[counter] = entry;
                    }
                }
                else
                {
                    HPChannelNames[counter] = channelCollection;
                    channelCollection = "";
                }
                counter++;
            }

            // Trim Channels
            counter = 0;
            while (HPChannelNames[counter] != null)
            {
                while (SearchString(HPChannelNames[counter], "\r")) HPChannelNames[counter] = Replace(HPChannelNames[counter], "\r", "");
                counter++;
            }

            // Show HP Entries
            counter = 0;
            while (line[counter] != null)
            {
                int tempCounter = 0;
                bool matchSpecifics = false;
                int channelCounter = 0;

                // find the channel name
                while (HPChannelNames[channelCounter] != null && matchSpecifics == false)
                {
                    if (HPChannelNames[channelCounter] == line[counter + 1]) matchSpecifics = true;
                    channelCounter++;
                }
                channelCounter--;

                if (matchSpecifics && HPSpecifics[channelCounter, 0] != null)
                {
                    matchSpecifics = false;
                    
                    // if the channel is found, check any speficications
                    while (HPSpecifics[channelCounter, tempCounter] != null)
                    {
                        // Check Title
                        if (SearchString(line[counter].ToUpper(), HPSpecifics[channelCounter, tempCounter].ToUpper())) matchSpecifics = true;

                        tempCounter++;
                    }
                }

                // Write Row
                if (matchSpecifics)
                {
                    dGVHPResults.Rows.Add(line[counter], line[counter + 1], line[counter + 2], line[counter + 3], line[counter + 4]);
                }

                counter += 5;
            }


        }

        public void AddToLatestVideo(string channel, string link)
        {
            int counter = 0;
            string[] line = new string[100];
            
            FileStream fs = new FileStream(latestVideosPath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            counter = 0;
            while (sr.Peek() != -1)
            {
                line[counter] = sr.ReadLine();
                counter++;
            }

            sr.Close();
            fs.Close();

            counter = 0;
            bool changed = false;
            while (line[counter] != null)
            {
                if (line[counter].Length > (channel.Length + 1))
                {
                    if (line[counter].Substring(0, channel.Length + 1) == ("*" + channel))
                    {
                        line[counter] = "*" + channel + " - " + link;
                        changed = true;
                    }
                }

                counter++;
            }

            if (changed == false)
            {
                line[counter] = "*" + channel + " - " + link;
            }

            fs = new FileStream(latestVideosPath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            counter = 0;
            while (line[counter] != null)
            {
                sw.WriteLine(line[counter]);
                counter++;
            }

            sw.Close();
            fs.Close();
        }

        private void btnGetVideos_Click(object sender, EventArgs e)
        {
            int counter;

            #region Clear Values

            // Clear Channel Names
            for (int a = 0; a < 100; a++)
            {
                channelNames[a] = null;
                latestChannelVideos[a] = null;

                for (int b = 0; b < 10; b++)
                {
                    specifics[a, b] = null;
                }
            }
            
            #endregion

            // Load Channel Names
            string channelCollection = rTBAllChannelNames.Text;

            UpdateChannelNames();

            counter = 0;
            while (channelCollection != "")
            {
                if (SearchString(channelCollection, "\n"))
                {
                    string entry = channelCollection.Substring(0, InString(channelCollection, "\n"));
                    channelCollection = channelCollection.Substring(InString(channelCollection, "\n") + 1,
                        channelCollection.Length - (InString(channelCollection, "\n") + 1));

                    if (entry.Trim() != "")
                    {
                        // Get name and specifics
                        if (SearchString(entry, ":"))
                        {
                            channelNames[counter] = entry.Substring(0, InString(entry, ":"));

                            // Specifics
                            entry = entry.Substring(InString(entry, ":") + 1, entry.Length - (InString(entry, ":") + 1)).Trim();
                            int specificCounter = 0;
                            while (SearchString(entry, ","))
                            {
                                specifics[counter, specificCounter] = entry.Substring(0, InString(entry, ","));
                                entry = entry.Substring(InString(entry, ",") + 1, entry.Length - (InString(entry, ",") + 1)).Trim();

                                specificCounter++;
                            }
                            specifics[counter, specificCounter] = entry;

                        }
                        else
                        {
                            channelNames[counter] = entry;
                        }
                    }
                    else { counter--; }
                }
                else
                {
                    if (channelCollection.Trim() != "")
                    {
                        channelNames[counter] = channelCollection;
                        channelCollection = "";
                    }
                    else { counter--; }
                }

                // Trim Channel
                
                // while (SearchString(channelNames[counter], "\r")) channelNames[counter] = Replace(channelNames[counter], "\r", "");
                channelNames[counter] = channelNames[counter].Trim();
                
                counter++;
            }

            // Get Latest Video
            counter = 0;
            while (channelNames[counter] != null)
            {
                string latestVideo = null;
                
                FileStream fs = new FileStream(latestVideosPath, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string line = "";
                while (sr.Peek() != -1 && (SearchString(line, channelNames[counter]) != true))
                {
                    line = sr.ReadLine();

                    if (line.Length > (channelNames[counter].Length + 1))
                    {
                        if (line.Substring(0, channelNames[counter].Length + 1) == ("*" + channelNames[counter]))
                        {
                            latestVideo = line.Substring(channelNames[counter].Length + 4,
                                line.Length - (channelNames[counter].Length + 4));
                        }
                    }
                }

                sr.Close();
                fs.Close();

                latestChannelVideos[counter] = latestVideo;

                counter++;
            }
            
            GetVideos();

            RefreshDGV();

            MessageBox.Show("Done!");
        }

        public int InString(string text, string substring)
        {
            // gives position of substring the first time it occurs in the text
            
            int position = -1;

            if (text != null && substring != null)
            {
                for (int a = 0; a <= text.Length - substring.Length; a++)
                {
                    if (text.Substring(a, substring.Length) == substring && position == -1) position = a;
                }
            }
            else
            {
                position = 0;
            }

            return position;
        }

        public bool SearchString(string text, string substring)
        {
            // searches text string for the subtring string and is true if it is found
            bool inString = false;

            if (text != null && substring != null)
            {
                if (text.Length >= substring.Length)
                {
                    for (int a = 0; a <= (text.Length - substring.Length); a++)
                    {
                        if (text.Substring(a, substring.Length) == substring) inString = true;
                    }
                }
            }

            return inString;
        }

        public string Replace(string text, string find, string replaceWith)
        {
            // replace function
            // *Works*
            int count = 0;
            string newText = text;
            while (newText.Length - find.Length - count >= 0)
            {
                if (newText.Substring(count, find.Length) == find)
                {
                    newText = newText.Substring(0, count) + replaceWith + newText.Substring(count + find.Length,
                        newText.Length - count - find.Length);
                    count += replaceWith.Length;
                }
                else count++;
            }
            return newText;
        }

        public void EliminateEntry(string title)
        {
            string[] line = new string[10000];
            int counter = 0;

            // Load Entries
            FileStream fs = new FileStream(allEntriesPath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            counter = 0;
            while (sr.Peek() != -1)
            {
                line[counter] = sr.ReadLine();
                counter++;
            }

            sr.Close();
            fs.Close();

            // Eliminate Entry
            counter = 0;
            while (line[counter] != title)
            {
                counter++;
            }
            line[counter] = null;
            line[counter + 1] = null;
            line[counter + 2] = null;
            line[counter + 3] = null;
            line[counter + 4] = null;

            // Move lines over 3
            do
            {
                line[counter] = line[counter + 5];
                line[counter + 1] = line[counter + 6];
                line[counter + 2] = line[counter + 7];
                line[counter + 3] = line[counter + 8];
                line[counter + 4] = line[counter + 9];
                counter += 5;
            } while (line[counter] != null);

            // Record Entries
            fs = new FileStream(allEntriesPath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            counter = 0;
            while (line[counter] != null)
            {
                sw.WriteLine(line[counter]);
                counter++;
            }

            sw.Close();
            fs.Close();

            RefreshDGV();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dGVNewVideos.Rows[0].Selected = false;
            dGVHPResults.Rows[0].Selected = false;
            dGVAllResults.Rows[0].Selected = false;
        }

        private void btnDeleteRow2_Click(object sender, EventArgs e)
        {
            int select_count = dGVAllResults.SelectedRows.Count;
            int index;
            DataGridViewRow row;
            string[] title = new string[select_count];

            for (int i = 0; i < select_count; i++)
            {
                index = dGVAllResults.SelectedRows[i].Index;
                row = dGVAllResults.Rows[index];
                title[i] = row.Cells[0].Value.ToString();
            }

            for (int i = 0; i < select_count; i++)
            {
                EliminateEntry(title[i]);
            }
        }

        private void btnDeleteRow1_Click(object sender, EventArgs e)
        {
            int i = dGVHPResults.SelectedRows[0].Index;
            DataGridViewRow row = dGVHPResults.Rows[i];
            string title = row.Cells[0].Value.ToString();
            EliminateEntry(title);      
        }

        private void btnLoadWebsite1_Click(object sender, EventArgs e)
        {
            int i = dGVHPResults.SelectedRows[0].Index;

            // Now I read the string data in each cell of the row.
            DataGridViewRow row = dGVHPResults.Rows[i];
            string link = row.Cells[4].Value.ToString();
            System.Diagnostics.Process.Start(link);

            if (chBDelete1.Checked)
            {
                string title = row.Cells[0].Value.ToString();
                EliminateEntry(title);
            }
        }

        private void btnLoadWebsite2_Click(object sender, EventArgs e)
        {
            int i = dGVAllResults.SelectedRows[0].Index;

            // Now I read the string data in each cell of the row.
            DataGridViewRow row = dGVAllResults.Rows[i];
            string link = row.Cells[4].Value.ToString();
            System.Diagnostics.Process.Start(link);

            if (chBDelete2.Checked)
            {
                string title = row.Cells[0].Value.ToString();
                EliminateEntry(title);
            }
        }

        /*
        public void dGVNewVideos_SelectionChanged(object sender, EventArgs e)
        {
            if (false)
            {
                // First we grab the sender of the event (the control which first generated the event).  In this
                // case it is the DataGridView.  We didn't have to cast the sender object to get a reference to
                // our DataGridView, but I wanted to show you that the generator of the event is always passed
                // so the event handler as the sender object.  If you want to treat it as a DataGridView in your
                // code, you must tell the compiler that the sender object is actually a DataGridView by casting it.

                DataGridView dgv = (DataGridView)sender;

                // Now we find the index of the row selected.  Note that I am accessing the 0th element in the
                // SelectedRows array, as this is the only row selected.  Remember I disabled multirow selections
                // when setting up the DataGridView in the Form1_Load event handler.

                int i = dgv.SelectedRows[0].Index;

                // Now I get a reference to the actual row selected by using the row index.

                DataGridViewRow row = dgv.Rows[i];

                // Now I read the string data in each cell of the row.

                DialogResult result1 = MessageBox.Show("Do you want to take this video away from the new videos record?",
            "Eliminate Video?", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    string title = row.Cells[0].Value.ToString();

                    EliminateEntry(title);
                }
            }
        }
        */

    }
}
