using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GUIShowtip : MonoBehaviour
{
    public static GUIShowtip instance;
    
    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
            return;
        }
        Destroy(gameObject);
    }

    public void ShowTip(Vector3 position)
    {

    }
}
