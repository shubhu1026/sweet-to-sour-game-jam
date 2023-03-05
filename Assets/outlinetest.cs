using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlinetest : MonoBehaviour, IInteractable
{
    [SerializeField] Material defaultMat;
    [SerializeField] Material outlineMat;
    Coroutine returnMat;
    public void Indicate(bool indicate)
    {
        GetComponent<SpriteRenderer>().material = indicate ? outlineMat : defaultMat;        
    }
    public void Interaction()
    {
        Debug.Log("interacting with " + name);
    }

    public void ShowTip()
    {
        throw new System.NotImplementedException();
    }

}
