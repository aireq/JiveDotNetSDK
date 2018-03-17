using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Net.Pokeshot.JiveSdk.Models;

namespace Net.Pokeshot.JiveSdk.Clients
{
    public class ImagesClient : JiveClient
    {
        public ImagesClient(string communityUrl, NetworkCredential credentials) : base(communityUrl, credentials)
        {
        }

        private string imagesUrl
        { get { return JiveCommunityUrl + "/api/core/v3/images"; } }

        public Net.Pokeshot.JiveSdk.Models.Image CreateImage(System.IO.Stream imageData)
        {
            throw new NotImplementedException();
        }

        public IList<Image> GetContentImages(int contentId)
        {
            throw new NotImplementedException();
        }

        public System.IO.Stream GetCustomStatusLevelImage(string statusName)
        {
            throw new NotImplementedException();
        }

        public System.IO.Stream GetDefaultStatusLevelImage(string statusName)
        {
            throw new NotImplementedException();
        }

        public System.IO.Stream GetImage(int imageId)
        {
            throw new NotImplementedException();
        }
    }
}