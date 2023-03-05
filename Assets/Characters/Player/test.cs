using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] CharacterVisualSO[] charactersData;
    [SerializeField] BodyPartsController bodyPartsController;
    int index;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetNextIndex();
            bodyPartsController.SetCharacterVisual(charactersData[index]);
        }
    }

    private void GetNextIndex()
    {
        index = ++index < charactersData.Length ? index : 0;
        
    }
}
