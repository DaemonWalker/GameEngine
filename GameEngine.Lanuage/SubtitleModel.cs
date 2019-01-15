using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Lanuage
{
    public class SubtitleModel
    {
        public string TitleCode { get; set; }
        public Dictionary<string, string> SubtitleDict = new Dictionary<string, string>();
    }
}
