using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    IInteractable _interaction;
    //indication of selected object

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            _interaction = interactable;
            interactable.Indicate(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            _interaction = interactable;
            interactable.Indicate(false);
            _interaction = null;
        }
    }

    public void Use(){
        if(_interaction == null) return;
        var v = _interaction.Interaction();
    } 

    public IInteractable GetInteract()
    {
        return _interaction;
    }
}
