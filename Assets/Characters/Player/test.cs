using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] CharacterVisualSO[] _charactersData;
    [SerializeField] BodyPartsController _bodyPartsController;

    int _index;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetNextIndex();
            _bodyPartsController.SetCharacterVisual(_charactersData[_index]);
        }
    }

    private void GetNextIndex()
    {
        _index = ++_index < _charactersData.Length ? _index : 0;
    }
}
