using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryItem : MonoBehaviour
{
    [SerializeField] Image image;
    
    ItemSO item;

    public void Init(ItemSO itemSO)
    {
        item = itemSO;
        image.sprite = item.image;
    }

    public ItemSO GetItemSO()
    {
        return item;
    }
    
    public void SetSelected(bool isActive)
    {
        image.color = isActive ? Color.white : Color.gray;
    }
}
