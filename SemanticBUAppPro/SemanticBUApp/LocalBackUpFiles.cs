using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using Google.Apis;
using Google.Apis.Services;
using Google.Apis.Download;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Storage.v1;
using Google.Apis.Drive.v2;
using System.Collections.Specialized;

namespace SemanticBUApp
{
    internal class LocalBackUpFiles
    {
        //takes a list of file names as their full path file names' 
        //and a target local directory where files will be saved.
        public void LocalBacKUpFilesTo(List<string> filesToBackUp,string zipFilePathName,string targetPath) 
        {

            Directory.CreateDirectory(targetPath);
                        
            foreach(string file in filesToBackUp)
            { 
                
                try
                {
                    if (File.Exists(file))
                    {
                        File.Copy(file, targetPath + "\\" + Path.GetFileName(file),true);
                    }
                }
                catch (Exception)
                {
                   
                }
            }
            ZipFile.CreateFromDirectory(targetPath, zipFilePathName, CompressionLevel.Fastest,true);
            DeleteDir(targetPath);
                
        }
        private void DeleteDir(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDir(dir);
            }

            Directory.Delete(target_dir, false);
        } 
    }
}
