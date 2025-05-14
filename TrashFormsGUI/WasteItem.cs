using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashFormsGUI
{
    public abstract class WasteItem
    {
        private int itemId;
        private int userId;
        private string itemName;
        private int quantity;
        private string wasteType;

        // Constructor
        public WasteItem(int itemId, int userId, string itemName, int quantity, string wasteType)
        {
            this.itemId = itemId;
            this.userId = userId;
            this.itemName = itemName;
            this.quantity = quantity;
            this.wasteType = wasteType;
        }

        // Properties (Getters and Setters)
        public int ItemId
        {
            get => itemId;
            set => itemId = value;
        }

        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        public string ItemName
        {
            get => itemName;
            set => itemName = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public string WasteType
        {
            get => wasteType;
            set => wasteType = value;
        }

        // Abstract method for recycling tips
        public abstract string GetRecycleTip();
    }

}
