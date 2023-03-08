using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    List<InventoryItem> _inventoryItems;
    [SerializeField] GameObject _itemInventoryPrefab;
    [SerializeField] ItemSO _hand;
    int _index;

    private void Awake() 
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        _inventoryItems = new();

        for (int i = transform.childCount - 1; i >= 0 ; i--)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        AddItemToInventory(_hand);
        _inventoryItems[0].SetSelected(true);
    }

    public void AddItemToInventory(ItemSO item)
    {
        var v = Instantiate(_itemInventoryPrefab, transform);
        InventoryItem inventoryItem = v.GetComponent<InventoryItem>();
        inventoryItem.Init(item);
        _inventoryItems.Add(inventoryItem);
    }

    public bool RemoveItemFromInventory(ItemSO item)
    {   
        foreach (InventoryItem inventoryItem in _inventoryItems)
        {
            if(inventoryItem.GetItemSO().ItemName == item.ItemName)
            {
                if(item.ItemName == "hand") return true;
                _inventoryItems.Remove(inventoryItem);
                Destroy(inventoryItem.gameObject);
                _index = 0;
                _inventoryItems[_index].SetSelected(true);
                return true;
            }
        }
        return false;
    }

    public void NextItem()
    {        
        _index = ++_index < _inventoryItems.Count ? _index : 0;

        foreach (var item in _inventoryItems)
        {
            item.SetSelected(false);
        }
        _inventoryItems[_index].SetSelected(true);
    }
    
    public ItemSO GetSelectedItem()
    {
        return _inventoryItems[_index].GetItemSO();
    }
}
