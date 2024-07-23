using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Drawing;
using System.Windows.Documents;
using YoutubeSearch;
using System.Net;

namespace SemanticBUApp
{
    class YoutubeSearher 
    {
        public Image thumbnail { get; set; }
        public string title { get; set; }
        public string url { get; set; }


        //public List<YoutubeSearher> Search(string term)
        //{
        //    VideoSearch results = new VideoSearch();
        //    List<YoutubeSearher> videoList = new List<YoutubeSearher>();
            
        //    foreach (var result in results.SearchQuery("csharp", 1))
        //    {
        //        YoutubeSearher vid = new YoutubeSearher();
        //        vid.title = result.Title;
        //        vid.url = result.Url;
        //        byte[] imageBytes = new WebClient().DownloadData(result.Thumbnail);
        //        using (MemoryStream ms = new MemoryStream(imageBytes))
        //        {
        //            vid.thumbnail = Image.FromStream(ms);
        //        }
        //        videoList.Add(vid);
        //    }
        //  return videoList;
        //}
    }
}