using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryItem : MonoBehaviour
{
    [SerializeField] Image _image;
    
    ItemSO _item;

    public void Init(ItemSO itemSO)
    {
        _item = itemSO;
        _image.sprite = _item.Image;
    }

    public ItemSO GetItemSO()
    {
        return _item;
    }

    public void SetSelected(bool isActive)
    {
        _image.color = isActive ? Color.white : Color.gray;
    }
}
