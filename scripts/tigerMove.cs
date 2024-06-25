using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tigerMove : MonoBehaviour
{
    private float xMove;
    private Rigidbody2D rb;
    [SerializeField] private float speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        xMove = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xMove, rb.velocity.y);
    }
}
