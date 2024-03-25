using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Windows.Documents;
using YoutubeSearch;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Reflection;

namespace SemanticBUApp 
{
    public partial class Form2 : Form 
    {

        public string term { get; set; }
        
        public int rowIndex { get; set; }
        public object YoutubeVideoBindingSource { get; private set; }
        List<YoutubeVideo> videoList = new List<YoutubeVideo>();
        public bool buFile;
        public static Form2 form2Instance;
        public List<string> urls = null;

        //functions
        public async Task Run(string term)
        {
            YoutubeVideo video;
            List<YoutubeVideo> videos = new List<YoutubeVideo>();

            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyDBinOzp38TMw7Sl3ZvA4NRwiWv7r6pcK0",
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = term; // Replace with your search term.
                searchListRequest.MaxResults = 10;

                // Call the search.list method to retrieve results matching the specified query term.
                var searchListResponse = await searchListRequest.ExecuteAsync();

                videos = new List<YoutubeVideo>();
                List<string> channels = new List<string>();
                List<string> playlists = new List<string>();
                Form2 f2;
                // Add each result to the appropriate list, and then display the lists of
                // matching videos, channels, and playlists.
                
                foreach (var searchResult in searchListResponse.Items)
                {
                    video = new YoutubeVideo();
                    switch (searchResult.Id.Kind)
                    {
                        case "youtube#video":
                            try
                            {
                                video.title = searchResult.Snippet.Title;
                            }
                            catch (Exception)
                            {
                                video.title = null;
                            }
                            try
                            {
                                video.url = ("https://youtube.com/watch?v=" + searchResult.Id.VideoId);
                            }
                            catch (Exception)
                            {
                                video.url = null;
                            }
                            try
                            {
                                byte[] imageBytes = new WebClient().DownloadData("https://img.youtube.com/vi/" + searchResult.Id.VideoId + "/3.jpg");
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    video.thumbnail = Image.FromStream(ms);
                                }
                            }
                            catch (Exception)
                            {
                                video.thumbnail = null;
                            }
                            break;
                    }
                    videos.Add(video);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred! \n Please check Your internet connection!");
            }
            videoList = videos;
        }

        public Form2(string searchTerm, int rowIndex)
        {
            InitializeComponent(); 
            form2Instance=this;
            term= searchTerm;
            this.rowIndex = rowIndex;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewRowEventArgs e)
        {
            //string url = dataGridView1.Rows[e.].Cells["url"].Value.ToString();
            //Process.Start(url);
            //urls = new List<string>();
            //if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["cbApprove"].Value) == true)
            //{
            //    urls.Add(dataGridView1.Rows[e.RowIndex].Cells["url"].Value.ToString());
            //}


        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            urls = new List<string>();
            cb_backupFile.CheckState = CheckState.Checked;
            textBox1.Text=term;
            try
            {
                await Run(term);
            }
            catch (AggregateException ex)
            {
                foreach (var eg in ex.InnerExceptions)
                {
                    MessageBox.Show("Error: " + eg.Message);
                }
            }
            youtubeVideoBindingSource.DataSource = videoList;


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await Run(textBox1.Text);
            }
            catch (AggregateException ex)
            {
                foreach (var eg in ex.InnerExceptions)
                {
                    MessageBox.Show("Error: " + eg.Message);
                }
            }
            youtubeVideoBindingSource.DataSource = videoList;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e, int rIndex)
        {
            if (Convert.ToBoolean(dataGridView1.Rows[rIndex].Cells["cbApprove"].Value) == false)
            {
                cb_backupFile.CheckState=CheckState.Unchecked;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Form1.form1Instance.approveBackup= cb_backupFile.Checked;
            urls = new List<string>();
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["cbApprove"].Value) == true)
                {
                    string url = dataGridView1.Rows[i].Cells["url"].Value.ToString();
                    urls.Add(url);

                }
            }
            this.Close();
            
        }
        private string ConvertTextUrlToLink(string url)
        {
            string regex = @"((www\.|(http|https|ftp|news|file)+\:\/\/)[_.a-z0-9-]+\.
            [a-z0-9\/_:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)])";
            Regex r = new Regex(regex, RegexOptions.IgnoreCase);
            return r.Replace(url, "a href=\"$1\" title=\"Click here to open in a new window or tab\"target =\"_blank\">$1</a>").Replace("href=\"www", "href=\"http://www");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string url = dataGridView1.Rows[e.ColumnIndex].Cells["url"].Value.ToString();
                Process.Start(url);
            }
            
            if (e.ColumnIndex == 0)
            { 
                checkBox1_CheckedChanged(null, null, e.RowIndex);
               
                
            }

        }
    }
}
