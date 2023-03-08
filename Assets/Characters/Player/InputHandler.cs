using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private CharacterControllerTopDown _characterController;
    [SerializeField] private InteractionHandler _interactionHandler;

    void Update()
    {
        _characterController.SetVector(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        if(Input.GetKeyDown(KeyCode.F))
        {
            if(_interactionHandler == null) return;
            _interactionHandler.Use();
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Inventory.Instance.NextItem();
        }
    }
}
