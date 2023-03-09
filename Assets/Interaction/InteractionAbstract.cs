using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public abstract class InteractionAbstract : MonoBehaviour, IInteractable
{
    [SerializeField]protected ItemSO requestedItem;
    [SerializeField]protected ItemSO obtainedItem;
    private bool _wasUsed = false;
    [SerializeField] private GameObject _lightGO;
    
    private void Awake()
    {
        //lets object,who have got nothing to offer look like used -> secondary string will be used
        if(obtainedItem == null) _wasUsed = true;
        //disable interaction light
        _lightGO.SetActive(false);
    }
    public void Indicate(bool indicate)
    {
        _lightGO.SetActive(indicate);     
    }
    public void Interaction()
    {
        //get player selected item
        ItemSO selectedItem = Inventory.Instance.GetSelectedItem();
        
        //wrong item
        if(!selectedItem.Equals(requestedItem))
        {
            LockedAction();
        }
        //right item
        else
        {
            Inventory.Instance.RemoveInventory(requestedItem);
            //object was used or no object to collect
            if(_wasUsed || obtainedItem == null)
            {
                UnlockedAction();
            }
            else
            {
                //collect item                
                Inventory.Instance.AddItem(obtainedItem);
                _wasUsed = true;
                UnlockedAction();
            }

        }

    }
    protected virtual void LockedAction()
    {

    }
    protected virtual void UnlockedAction()
    {

    }
    virtual public void ShowTip()
    {

    }

}
