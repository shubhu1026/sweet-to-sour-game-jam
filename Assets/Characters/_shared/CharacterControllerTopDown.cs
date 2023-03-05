using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IInteractable
{

    public void ShowTip();
    public void Interaction();
    public void Indicate(bool indicate);
}
public class CharacterControllerTopDown : MonoBehaviour
{
    
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;
    private Animator animator;
    private float xDirection = 1f;//-1f is left
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    public void SetVector(Vector2 inputVector)
    {
        rb2d.velocity = inputVector * speed;
        animator.SetBool("isMoving", rb2d.velocity != Vector2.zero);
        if(inputVector.x != 0)
        {
            xDirection = Mathf.Sign(inputVector.x);
            transform.localScale = new Vector3(xDirection, 1, 1);
        }
    }
    
}
