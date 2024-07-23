using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SemanticBUApp
{
    public class FetchFileData
    {
        public List<string> audios = new List<string>();
        public List<string> documents = new List<string>();
        public List<string> videos = new List<string>();
        public List<string> images = new List<string>();
        public List<string> other = new List<string>();

        public long SizeOfAudios { get; set; }
        public long SizeOfDocuments { get; set; }
        public long SizeOfVideos { get; set; }
        public long SizeOfImages { get; set; }
        public long SizeOfOther {get; set;}
        private string path;
        public FetchFileData(string path)
        { 
            this.path = path;
            audios = new List<string>();
            documents = new List<string>();
            other = new List<string>();
            images = new List<string>();
            videos = new List<string>();
            CatogerizedLists();
            SizeOfAudios = calcSize(audios); 
            SizeOfDocuments = calcSize(documents);
            SizeOfImages = calcSize(images);
            SizeOfVideos = calcSize(videos);
            SizeOfOther = calcSize(other);

           
        }
        public  IEnumerable<string> EnumerateDirectories(string parentDirectory, string searchPattern, SearchOption searchOpt)
        {
            try
            {
                var directories = Enumerable.Empty<string>();
                if (searchOpt == SearchOption.AllDirectories)
                {
                    directories = Directory.EnumerateDirectories(parentDirectory)
                        .SelectMany(x => EnumerateDirectories(x, searchPattern, searchOpt));
                }
                return directories.Concat(Directory.EnumerateDirectories(parentDirectory, searchPattern));
            }
            catch (UnauthorizedAccessException ex)
            {
                return Enumerable.Empty<string>();
            }
        }

        public IEnumerable<string> GetAccessibleFiles(string path, string searchPattern, SearchOption searchOpt)
        {
            try
            {
                var dirFiles = Enumerable.Empty<string>();
                if (searchOpt == SearchOption.AllDirectories)
                {
                    dirFiles = Directory.EnumerateDirectories(path)
                                        .SelectMany(x => GetAccessibleFiles(x, searchPattern, searchOpt));
                }
                return dirFiles.Concat(Directory.EnumerateFiles(path, searchPattern));
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<string>();
            }
        }

        public List<string> GetRequiredFiles()
        {
            List<string> paths = new List<string>();
            List<string> files = new List<string>();
            List<string> appropriateFiles = new List<string>();
            string[] formats =
            {
                ".txt", ".pdf", ".doxc",".xls", ".doc",".doc",                                                            //documents
                ".png", ".jpeg", ".jpg",".svg",".eps",".tif",".tiff",".psd", ".bmp", ".gif",                             //images
                ".mp3", ".wav",".3ga",".m4a",".m4b",",wma",".m4p",                                                       //audios
                "mp4", ".avi", ".mpeg", ".mpg", ".mov", ".webm", ".3pg", "wmv", ".mkv", ".flv", ".vob", ".gifv", ".m4v"  //videos

            };
            
            files = GetAccessibleFiles(path, "*", SearchOption.AllDirectories).ToList();

            foreach (string file in files)
            {
                bool valid = false;
                for (int i = 0; i < formats.Length; i++)
                {
                    if (Path.GetExtension(file) == formats[i])
                        valid = true;

                }

                if (valid)
                {

                    appropriateFiles.Add(file);
                }
            }
                return appropriateFiles;
        }

        private void CatogerizedLists()
        {
            List<string> appropriateFiles = GetAccessibleFiles(path, "*", SearchOption.AllDirectories).ToList();

            string[] audioFormats = { ".mp3", ".wav", ".3ga", ".m4a", ".m4b", ",wma", ".m4p", };           
            string[] vidFormats = { "mp4", ".avi", ".mpeg", ".mpg", ".mov", ".webm", ".3pg", "wmv", ".mkv", ".flv", ".vob", ".gifv", ".m4v" };
            string[] docFormats = { ".txt", ".pdf", ".doxc", ".xls", ".doc", ".doc" };
            string[] imageFormats = { ".png", ".jpeg", ".jpg", ".svg", ".eps", ".raw", ".tif", ".tiff", ".psd", ".bmp", ".gif" };



            foreach (string file in appropriateFiles)
            {
                bool isAudio = false;
                bool isVideo = false;
                bool isDoc = false;
                bool isPic = false;
                for (int i = 0; i < audioFormats.Length; i++)
                {
                    if (Path.GetExtension(file) == audioFormats[i])
                    {
                        isAudio = true;
                        isVideo = false;
                        isDoc = false;
                        isPic = false;
                        audios.Add(file);
                        continue;
                    }
                    
                }
                for (int i = 0; i < vidFormats.Length; i++)
                {
                    if (Path.GetExtension(file) == vidFormats[i])
                    {
                        isAudio = false;
                        isVideo = true;
                        isDoc = false;
                        isPic = false;
                        videos.Add(file);
                        continue;

                    }

                }
                for (int i = 0; i < imageFormats.Length; i++)
                {
                    if (Path.GetExtension(file) == imageFormats[i])
                    {
                        isAudio = false;
                        isVideo = false;
                        isDoc = false;
                        isPic = true;
                        images.Add(file);
                        continue;

                    }

                }
                for (int i = 0; i < docFormats.Length; i++)
                {
                    if (Path.GetExtension(file) == docFormats[i])
                    {
                        isAudio = false;
                        isVideo = false;
                        isDoc = true;
                        isPic = false;
                        documents.Add(file);
                        continue;

                    }

                }
                if ((isAudio && isDoc && isVideo && isPic) == true)
                {
                    other.Add(file);
                }

            }
        }

        private long calcSize(List<string> fileType)
        {
            long totalSize = 0;

            foreach (string file in fileType)
            {
                FileInfo fl = new FileInfo(file);
                totalSize += fl.Length / 100000;

            }

            return totalSize;
        }


    }
}
