using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerTopDown : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rb2d;
    private Animator _animator;
    private float _xDirection = 1f;//-1f is left

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    public void SetVector(Vector2 inputVector)
    {
        _rb2d.velocity = inputVector * _speed;
        _animator.SetBool("isMoving", _rb2d.velocity != Vector2.zero);
        if(inputVector.x != 0)
        {
            _xDirection = Mathf.Sign(inputVector.x);
            transform.localScale = new Vector3(_xDirection, 1, 1);
        }
    }
}
