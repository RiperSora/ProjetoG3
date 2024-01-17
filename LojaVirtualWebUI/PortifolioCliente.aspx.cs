using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LojaVirtualWebUI
{
    public partial class PortifolioCliente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListFoldersAndFiles();
            }
        }

        protected void ListFoldersAndFiles()
        {
            var clientSecrets = new ClientSecrets
            {
                ClientId = "889764991114-akoqhf58qju42p4mplqt1srepc1jph8p.apps.googleusercontent.com",
                ClientSecret = "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"
            };

            string credPath = Server.MapPath("~/App_Data/.credentials");
            string tokenPath = Path.Combine(credPath, "drive-dotnet-quickstart.json");

            UserCredential credential;

            using (var stream = new FileStream(Server.MapPath("~/Credential/credentials.json"), FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { DriveService.Scope.Drive },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(tokenPath, true)).Result;
            }

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "AcessoDrive",
            });

            var request = service.Files.List();
            request.Q = "mimeType = 'application/vnd.google-apps.folder'";
            var result = request.Execute();

            if (result != null && result.Files != null)
            {
                foreach (var folder in result.Files)
                {
                    var filesRequest = service.Files.List();
                    filesRequest.Q = $"'{folder.Id}' in parents";
                    var filesResult = filesRequest.Execute();
                    if (filesResult != null && filesResult.Files != null)
                    {
                        foreach (var file in filesResult.Files)
                        {
                            string fileUrl = $"https://drive.google.com/uc?id={file.Id}";
                            string imageTag = $"<img src='{fileUrl}' alt='{file.Name}' /><br/>";
                            Response.Write($"Folder: {folder.Name}, File: {imageTag}");
                        }
                    }
                }
            }
        }


    }
}