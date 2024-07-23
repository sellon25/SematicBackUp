﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace SemanticBUApp
{
    class CloudBackupFile
    {
        string targetDirFile { get; set; }
        string fileName { get; set; }
        static UserCredential credential;
        static DriveService service;
        public CloudBackupFile(string userName, string uploadFile)
        {
            this.targetDirFile = uploadFile;
            Authorize(userName);
        }
        private void Authorize(string userName)
        {
            try
            {
                string[] scopes = new string[] { DriveService.Scope.Drive, DriveService.Scope.DriveFile };
                var clientId = "978652625500-5q946rqlh9v1c7am2klco5bl21p4vttk.apps.googleusercontent.com";
                var clientSecret = "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";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets()
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret
                }, scopes, userName, CancellationToken.None, new FileDataStore("MyAppsToken")).Result;
                service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "MyAppName"
                });
                service.HttpClient.Timeout = TimeSpan.FromMinutes(100);

            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred! \n Please check Your internet connection!");
            }
            string parents = targetDirFile;
            string name = Path.GetFileName(targetDirFile);

            string fileName = targetDirFile;
            var respocne = uploadFile(service, fileName, "");

        }

        public Google.Apis.Drive.v3.Data.File uploadFile(DriveService _service, string _uploadFile, string _parent, string _descrp = "Uploaded with .NET!")
        {
            if (System.IO.File.Exists(_uploadFile))
            {
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                body.Name = System.IO.Path.GetFileName(_uploadFile);
                body.Description = _descrp;
                body.MimeType = GetMimeType(_uploadFile);
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);

                try
                {
                    FilesResource.CreateMediaUpload request = _service.Files.Create(body, stream, GetMimeType(_uploadFile));
                    request.SupportsTeamDrives = true;
                    request.Upload();
                    MessageBox.Show(Path.GetFileName(targetDirFile) + "\nBacked up to your cloud. ");
                    return request.ResponseBody;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error Occured");
                    return null/* TODO Change to default(_) if this is not a reference type */;
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.", "404");
                return null/* TODO Change to default(_) if this is not a reference type */;
            }
        }

        private static string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }



    }
}
