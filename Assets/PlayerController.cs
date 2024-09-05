using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [Header("Player Characteristics")]
    Rigidbody2D RB2D;
    [SerializeField] private float speed;
    private float horizontal;
    private void Awake()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        RB2D.velocity = new Vector2(horizontal * speed, RB2D.velocity.y);
    }
}
