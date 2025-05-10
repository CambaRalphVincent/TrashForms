using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempForm
{
    public class MetalWaste : WasteItem
    {
        public MetalWaste(int itemId, int userId, string itemName, int quantity)
            : base(itemId, userId, itemName, quantity, "Metal")
        {
        }

        public override string GetRecycleTip()
        {
            return "Know What’s Recyclable: Most metals are recyclable, including old appliances, cans, pots, pans, and even some electronics. Ensure that any materials you plan to recycle are clean and free of non-metal components like plastic or rubber.";
        }
    }
}
