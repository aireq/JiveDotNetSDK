using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Net.Pokeshot.JiveSdk.Models;
using System.Web;
using Newtonsoft.Json.Linq;

namespace Net.Pokeshot.JiveSdk.Clients
{
    public class ImagesClient : JiveClient
    {
        public ImagesClient(string communityUrl, NetworkCredential credentials) : base(communityUrl, credentials)
        {
        }

        private string imagesUrl
        { get { return JiveCommunityUrl + "/api/core/v3/images"; } }

        public Net.Pokeshot.JiveSdk.Models.Image CreateImage(byte[] imageData)
        {
            string result;

            try
            {
                result = this.PostBinary(imagesUrl, imageData, "imagefile.jpg");
            }
            catch (HttpException e)
            {
                switch (e.GetHttpCode())
                {
                    case 400:
                        throw new HttpException(e.WebEventCode, "Any of the input fields are malformed", e);
                    case 403:
                        throw new HttpException(e.WebEventCode, "You are not allowed to access the specified content", e);
                    case 409:
                        throw new HttpException(e.WebEventCode, "New entity would conflict with system restrictions (such as two contents of the same type with the same name", e);
                    default:
                        throw;
                }
            }

            JObject Json = JObject.Parse(result);
            return Json.ToObject<Models.Image>();
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