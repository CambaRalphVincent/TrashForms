using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashFormsdNotFinal
{
    public class OrganicWaste : WasteItem
    {
        public OrganicWaste(int itemId, int userId, string itemName, int quantity)
            : base(itemId, userId, itemName, quantity, "Organic")
        {
        }

        public override string GetRecycleTip()
        {
            return "Organic recycling tip: Compost organic waste to enrich soil and reduce landfill contributions.";
        }
    }

}
