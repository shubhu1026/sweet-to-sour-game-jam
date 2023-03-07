using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    List<InventoryItem> inventoryItems;
    [SerializeField] GameObject itemInventoryPrefab;
    [SerializeField] ItemSO hand;
    int index;
    private void Awake() {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        inventoryItems = new();
        for (int i = transform.childCount - 1; i >= 0 ; i--)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        AddItem(hand);
        inventoryItems[0].SetSelected(true);
    }
    public void AddItem(ItemSO itemInventory)
    {
        var v = Instantiate(itemInventoryPrefab, transform);
        InventoryItem item = v.GetComponent<InventoryItem>();
        item.Init(itemInventory);
        inventoryItems.Add(item);
    }
    public bool RemoveInventory(ItemSO itemInventory)
    {
        
        foreach (InventoryItem inventoryItem in inventoryItems)
        {
            if(inventoryItem.GetItemSO().itemName == itemInventory.itemName)
            {
                if(itemInventory.itemName == "hand") return true;
                inventoryItems.Remove(inventoryItem);
                Destroy(inventoryItem.gameObject);
                index = 0;
                inventoryItems[index].SetSelected(true);
                return true;

            }
        }
        
        return false;
    }
    public void NextItem()
    {        
        index = ++index < inventoryItems.Count ? index : 0;
        foreach (var item in inventoryItems)
        {
            item.SetSelected(false);
        }
        inventoryItems[index].SetSelected(true);
    }
    
    public ItemSO GetSelectedItem()
    {
        return inventoryItems[index].GetItemSO();
    }
}
