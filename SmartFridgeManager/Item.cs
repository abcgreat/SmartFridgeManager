using System;

namespace SmartFridgeManager
{
    public class Item
    {
        public long itemType;
        public String itemUUID;
        public String name;
        public Double fillFactor;

        public Item(long itemType, String itemUUID, String name, Double fillFactor)
        {
            this.itemType = itemType;
            this.itemUUID = itemUUID;
            this.name = name;
            this.fillFactor = fillFactor;
        }
    }
}
