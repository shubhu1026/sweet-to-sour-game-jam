using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : InteractionAbstract
{
    [SerializeField] private string _lockedString;
    protected override void LockedAction()
    {
        GUIInGame.Instance.ShowText(_lockedString);
    }
    protected override void UnlockedAction()
    {
        Debug.Log("move to other scene");
    }

}
