using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GUIShowtip : MonoBehaviour
{
    public static GUIShowtip Instance;
    
    private void Awake() 
    {
        if(Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }
    
    public void ShowTip(Vector3 position)
    {

    }
}
