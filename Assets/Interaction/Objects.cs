using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : InteractionAbstract
{
    [SerializeField] private string _lockedString;
    [SerializeField] private string _unlockedString;
    protected override void LockedAction()
    {
        GUIInGame.Instance.ShowText(_lockedString);
    }
    protected override void UnlockedAction()
    {
        string textToShow = _unlockedString + "\n you collected " + obtainedItem.name;
        GUIInGame.Instance.ShowText(textToShow);
    }
}
