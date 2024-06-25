using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tigerJump : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tiger")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 15f, ForceMode2D.Impulse);
        }
    }
}
