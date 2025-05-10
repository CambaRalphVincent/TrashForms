using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempForm
{
    public class GlassWaste : WasteItem
    {
        public GlassWaste(int itemId, int userId, string itemName, int quantity)
            : base(itemId, userId, itemName, quantity, "Glass")
        {
        }

        public override string GetRecycleTip()
        {
            return "Clean Containers: Rinse out any food or beverage residues from glass containers. While they don’t need to be spotless, removing contaminants helps maintain the quality of recycled glass.";
        }
    }

}
