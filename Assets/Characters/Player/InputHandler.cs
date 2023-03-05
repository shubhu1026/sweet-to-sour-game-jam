using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private CharacterControllerTopDown characterController;

    void Update()
    {
        characterController.SetVector(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

    }
}
