using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlinetest : MonoBehaviour, IInteractable
{
    [SerializeField] Material defaultMat;
    [SerializeField] Material outlineMat;
    [SerializeField] ItemSO requestedItem;
    [SerializeField] ItemSO obtainedItem;
    Coroutine returnMat;
    public bool usable = false;
    
    public void Indicate(bool indicate)
    {
        GetComponent<SpriteRenderer>().material = indicate ? outlineMat : defaultMat;        
    }
    
    public ItemSO Interaction()
    {
        ItemSO usedItem = Inventory.instance.GetSelectedItem();
        ItemSO returnedItem = null;
        //wrong item selected
        if(requestedItem != Inventory.instance.GetSelectedItem()){
            Debug.Log("WRONG item was used / say something like: what i sould do, genius?");
            return returnedItem;
        }
        Inventory.instance.RemoveInventory(usedItem);
        //there is an item to collect
        if(obtainedItem != null)
        {
            
            Debug.Log("obtain " + obtainedItem.itemName);
            returnedItem = obtainedItem;
            obtainedItem = null;
            Inventory.instance.AddItem(returnedItem);
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
