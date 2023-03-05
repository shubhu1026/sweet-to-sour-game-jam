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
        throw new System.NotImplementedException();
    }

    public void ShowTip()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
