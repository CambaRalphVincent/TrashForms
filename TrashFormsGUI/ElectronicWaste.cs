using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashFormsGUI
{
    public class ElectronicWaste : WasteItem
    {
        public ElectronicWaste(int itemId, int userId, string itemName, int quantity)
            : base(itemId, userId, itemName, quantity, "Electronic")
        {
        }

        public override string GetRecycleTip()
        {
            return "Before recycling any electronic device, it’s crucial to securely erase all personal data. Simply deleting files may not be sufficient, as data can often be recovered.";
        }
    }

}
