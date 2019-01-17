using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Map
{
    public class ImageManager
    {
        private static List<string> supportList = new List<string>() { ".bmp", ".jpg", ".png" };
        private Dictionary<string, Image> img = new Dictionary<string, Image>();
        public ImageManager(IEnumerable<string> paths)
        {
            foreach (var path in paths)
            {
                var dir = new DirectoryInfo(path);
                foreach (var file in dir.GetFiles())
                {
                    if (supportList.Contains(Path.GetExtension(file.Name).ToLower()) &&
                        img.ContainsKey(Path.GetFileNameWithoutExtension(file.Name).ToLower()) == false)
                    {
                        img.Add(Path.GetFileNameWithoutExtension(file.Name).ToLower(), Image.FromFile(file.FullName));
                    }
                }
            }
        }

        public Image GetImage(Type t)
        {
            if (img.ContainsKey(t.Name.ToLower()))
            {
                return img[t.Name.ToLower()];
            }
            else
            {
                return null;
            }
        }
    }
}
