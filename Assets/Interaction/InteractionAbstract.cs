using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public abstract class InteractionAbstract : MonoBehaviour, IInteractable
{
    [SerializeField]protected ItemSO requestedItem;
    [SerializeField]protected ItemSO obtainedItem;
    public bool isUsed = false;
    protected GameObject _lightGO;
    
    virtual public void Indicate(bool indicate)
    {
        _lightGO.SetActive(indicate);     
    }
    
    virtual public void Interaction()
    {
        

    }
    virtual public void ShowTip()
    {

    }

}
