using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tiger")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 20f, ForceMode2D.Impulse);
            Destroy(gameObject);
        }
    }
}
