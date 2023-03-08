using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlinetest : MonoBehaviour, IInteractable
{
    [SerializeField] Material _defaultMat;
    [SerializeField] Material _outlineMat;
    [SerializeField] ItemSO _requestedItem;
    [SerializeField] ItemSO _obtainedItem;

    Coroutine _returnMat;
    public bool Usable = false;
    
    public void Indicate(bool indicate)
    {
        GetComponent<SpriteRenderer>().material = indicate ? _outlineMat : _defaultMat;        
    }
    
    public ItemSO Interaction()
    {
        ItemSO usedItem = Inventory.Instance.GetSelectedItem();
        ItemSO returnedItem = null;

        //wrong item selected
        if(_requestedItem != Inventory.Instance.GetSelectedItem()){
            Debug.Log("WRONG item was used / say something like: what i sould do, genius?");
            return returnedItem;
        }
        Inventory.Instance.RemoveItemFromInventory(usedItem);

        //there is an item to collect
        if(_obtainedItem != null)
        {
            Debug.Log("obtain " + _obtainedItem.ItemName);
            returnedItem = _obtainedItem;
            _obtainedItem = null;
            Inventory.Instance.AddItemToInventory(returnedItem);
            return returnedItem;
        }
        Debug.Log("end of interaction");
        return returnedItem;
    }

    public void ShowTip()
    {
        throw new System.NotImplementedException();
    }
}
