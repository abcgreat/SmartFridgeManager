using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartFridgeManager
{
    class SmartFridgeManagerImpl : SmartFridgeManager
    {
        /**
         * Event Handlers - These are methods invoked by the SmartFridge hardware to send notification of items that have
         * been added and/or removed from the fridge. Every time an item is removed by the fridge user, it will emit a
         * handleItemRemoved() event to this class, every time a new item is added or a previously removed item is re-inserted,
         * the fridge will emit a handleItemAdded() event with its updated fillFactor.
         */

        readonly Dictionary<String, Item>_items = new Dictionary<String, Item>();

        /**
         * This method is called every time an item is removed from the fridge
         *
         * @param itemUUID
         */
        public void handleItemRemoved(String itemUUID)
        {
            if (itemUUID.Length > 0)
            {
                _items.Remove(itemUUID);
            }
        }

        /**
         * This method is called every time an item is stored in the fridge
         *
         * @param itemType
         * @param itemUUID
         * @param name
         * @param fillFactor
         */
        public void handleItemAdded(long itemType, String itemUUID, String name, Double fillFactor)
        {
            if (itemUUID.Length > 0)
            {
                Item item = new Item(itemType, itemUUID, name, fillFactor);

                if(_items.ContainsKey(itemUUID))
                {
                    _items[itemUUID] = item;
                }
                else
                {
                    _items.Add(itemUUID, item);
                }
            }
        }

        /**
         * Returns a list of items based on their fill factor. This method is used by the
         * fridge to display items that are running low and need to be replenished.
         *
         * i.e.
         *      getItems( 0.5 ) - will return any items that are 50% or less full, including
         *                        items that are depleted. Unless all available containers are
         *                        empty, this method should only consider the non-empty containers
         *                        when calculating the overall fillFactor for a given item.
         *
         * @return an array of arrays containing [ itemType, fillFactor ]
         */
        public Object[] getItems(Double fillFactor)
        {
            Item[] objects = _items.Values.Where(s => s.fillFactor <= fillFactor).ToArray();
            return objects;
        }

        /**
         * Returns the fill factor for a given item type to be displayed to the owner. Unless all available containers are
         * empty, this method should only consider the non-empty containers
         * when calculating the overall fillFactor for a given item.
         *
         * @param itemType
         *
         * @return a double representing the average fill factor for the item type
         */
        public Double getFillFactor(long itemType)
        {
            Double fillFactor = _items.Values.Where(s => s.itemType == itemType && s.fillFactor > 0).Select(s => s.fillFactor).Average();
            return fillFactor;
        }

        /**
         * Stop tracking a given item. This method is used by the fridge to signal that its
         * owner will no longer stock this item and thus should not be returned from #getItems()
         *
         * @param itemType
         */
        public void forgetItem(long itemType)
        {
            var itemsToRemove = _items.Values.Where(s => s.itemType == itemType).Select(s => s.itemUUID).ToList();

            int lengthOfItemsToRemove = itemsToRemove.Count;

            for (int i=0; i < lengthOfItemsToRemove; i++)
            {
                handleItemRemoved(itemsToRemove.ElementAt(i));
            }
        }
    }
}
