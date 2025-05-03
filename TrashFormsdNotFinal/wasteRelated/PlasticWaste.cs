using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashFormsdNotFinal
{
    public class PlasticWaste : WasteItem
    {
        public PlasticWaste(int itemId, int userId, string itemName, int quantity)
            : base(itemId, userId, itemName, quantity, "Plastic")
        {
        }

        public override string GetRecycleTip()
        {
            return "Plastic recycling tip: Rinse plastic containers before recycling and avoid recycling items with food residue.";
        }
    }

}
