using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO", order = 0)]
public class ItemSO : ScriptableObject, IEquatable<ItemSO> 
{
    public Sprite Image;
    public string ItemName;
    public string CollectedText;

    public bool Equals(ItemSO other)
    {
        return other.ItemName == ItemName;
    }
}
