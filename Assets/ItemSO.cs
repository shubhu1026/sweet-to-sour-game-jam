using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO", order = 0)]
public class ItemSO : ScriptableObject, IEquatable<ItemSO> 
{
    public Sprite image;
    public string itemName;
    public string collectedText;

    public bool Equals(ItemSO other)
    {
        return other.itemName == itemName;
    }
}
