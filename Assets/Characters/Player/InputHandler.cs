using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private CharacterControllerTopDown characterController;
    [SerializeField] private InteractionHandler interactionHandler;

    void Update()
    {
        characterController.SetVector(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(interactionHandler == null) return;
            interactionHandler.Use();
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Inventory.instance.NextItem();
        }
    }
}
