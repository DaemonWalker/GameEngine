using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Map
{
    public class Scenario
    {
        public virtual int Size { get; }
        public ScenarioObject[,] Map { get; set; }

        private ImageManager imageManager;
        public Scenario(MapModel map, PlayerModel player, ImageManager imageManager)
        {
            this.imageManager = imageManager;
            Size = map.Size;
            Map = new ScenarioObject[Size, Size];
            foreach (var unit in map.Map)
            {
                if (unit.ScenarioObjectType != ScenarioObjectType.Player)
                {
                    Map[unit.PosY, unit.PosX] = new ScenarioObject()
                    {
                        PosX = unit.PosX,
                        PosY = unit.PosY,
                        Model = Activator.CreateInstance(unit.UnitType) as ModelBase,
                        ScenarioObjectType = unit.ScenarioObjectType
                    };
                }
                else
                {
                    Map[unit.PosY, unit.PosX] = new ScenarioObject()
                    {
                        PosX = unit.PosX,
                        PosY = unit.PosY,
                        Model = player,
                        ScenarioObjectType = unit.ScenarioObjectType
                    };
                }
            }
        }
        public Image CreateImage(int pixelCount)
        {
            pixelCount = (pixelCount / Size) * Size;
            var image = new Bitmap(pixelCount, pixelCount, PixelFormat.Format64bppPArgb);
            var cellSize = pixelCount / Size;
            using (Graphics g = Graphics.FromImage(image))
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(100, 128, 128, 128)), new Rectangle(0, 0, pixelCount, pixelCount));
                foreach (var cell in Map)
                {
                    if (cell != null)
                    {
                        var x = cell.PosX * cellSize;
                        var y = cell.PosY * cellSize;

                        g.DrawImage(imageManager.GetImage(cell.Model.GetType()), new Rectangle(x, y, cellSize, cellSize));
                    }
                }

            }
            return image;
        }
    }
}
