﻿using GameEngine.GameModel;
using GameEngine.Mod.Standard.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Mod.Standard
{
    public class BusinessMan : NpcModel
    {
        private List<ItemModel> items = new List<ItemModel>();
        public BusinessMan()
        {
            this.Name = "基础商人";
            items.Add(new Shield());
        }
    }
}
