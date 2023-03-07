using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    
    IInteractable interaction;
    //indication of selected object
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            interaction = interactable;
            interactable.Indicate(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            interaction = interactable;
            interactable.Indicate(false);
            interaction = null;
        }
    }
    public void Use(){
        if(interaction == null) return;
        var v = interaction.Interaction();
        
    } 
    public IInteractable GetInteract()
    {
        return interaction;
    }
}
