using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Vector2 _movment;

    private Rigidbody2D _rb;
    /*public static GameObject player;*/

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        /*player = GetComponent<GameObject>();*/
    }

    private void Update()
    {
        _movment.Set(InputManager.Movment.x, InputManager.Movment.y);

        _rb.velocity = _movment * _moveSpeed;
    }
}
