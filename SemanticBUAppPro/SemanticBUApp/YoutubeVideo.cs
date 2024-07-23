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
    class YoutubeVideo        
    {
        public Image thumbnail { get; set; }
        public string title { get; set; }
        public string url { get; set; }

    }
}