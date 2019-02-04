# SmartFridge

SmartFridge is a windows console app to display status of items in a fridge.
The solution contains 4 files:
  - SmartFridgeManager.cs
  - SmartFridgeManagerImpl.cs
  - Item.cs
  - Program.cs

# SmartFridgeManager.cs
This file is an interface of the solution and have following methods:
  - void handleItemRemoved(String itemUUID)
  - void handleItemAdded(long itemType, String itemUUID, String name, Double fillFactor)
  - Object[] getItems(Double fillFactor)
  - Double getFillFactor(long itemType)
  - void forgetItem(long itemType)
    
# SmartFridgeManagerImpl.cs
This file contains implementation of the interface: SmartFridgeManager.cs:
  - void handleItemRemoved(String itemUUID)
  - void handleItemAdded(long itemType, String itemUUID, String name, Double fillFactor)
  - Object[] getItems(Double fillFactor)
  - Double getFillFactor(long itemType)
  - void forgetItem(long itemType)

# Item.cs
This file contains following members and a constructor  to initialize values:
  - long itemType
  - String itemUUID
  - String name
  - Double fillFactor

# Program.cs
This file contains a test/simulation to demonstrate the interface of SmartFridgeManager

# How to use the methods
> Event Handlers - These are methods invoked by the SmartFridge hardware to send notification of items that have been added and/or removed from the fridge. Every time an item is removed by the fridge user, it will emit a handleItemRemoved() event to this class, every time a new item is added or a previously removed item is re-inserted, the fridge will emit a handleItemAdded() event with its updated fillFactor.
#### void handleItemRemoved(String itemUUID)
> This method is called every time an item is removed from the fridge        
#### void handleItemAdded(long itemType, String itemUUID, String name, Double fillFactor)
> This method is called every time an item is stored in the fridge
#### Object[] getItems(Double fillFactor)
> Returns a list of items based on their fill factor. This method is used by the fridge to display items that are running low and need to be replenished.
        example:
            getItems( 0.5 )
            ``will return any items that are 50% or less full, including
                                 items that are depleted. Unless all available containers are
                                empty, this method should only consider the non-empty containers
                                when calculating the overall fillFactor for a given item.``  
    return an array of arrays containing [ itemType, fillFactor ]
#### Double getFillFactor(long itemType)
> Returns the fill factor for a given item type to be displayed to the owner. Unless all available containers are empty, this method should only consider the non-empty containers when calculating the overall fillFactor for a given item.
    return a double representing the average fill factor for the item type
#### void forgetItem(long itemType)
> Stop tracking a given item. This method is used by the fridge to signal that its owner will no longer stock this item and thus should not be returned from #getItems()

# Program.cs contains simulation
This simulates a user stocks a fridge and consume items for a day for breakfast, lunch, and dinner and then restock.
This has rooms to improve to simulate better."# SmartFridgeManager" 
"# SmartFridgeManager" 
