using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace GameEngine.Map
{
    public class GmsModel
    {
        public List<MapModel> Map = new List<MapModel>();
        public static void SaveMap(GmsModel gms)
        {
            File.WriteAllText(@"C:\_TempFoloder\1.data", JsonConvert.SerializeObject(gms));
        }
    }
}
