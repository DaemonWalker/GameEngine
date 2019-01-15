using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameModel
{
    public class ModelBase
    {
        public ModelBase()
        {
            this.ImagePath = this.GetType().Name.ToString() + ".png";
        }
        public string ImagePath;

        public ModelBase DeepCopy()
        {
            object model;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                model = bf.Deserialize(ms);
                ms.Close();
            }
            return (ModelBase)model;
        }
    }
}
