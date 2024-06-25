using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameTiger : MonoBehaviour
{
    public static GameObject tiger;
    private Vector3 scale;
    private float x = 0.6f;

    void Start() 
    {
        tiger = GameObject.Find("tigerTheJumper");
        scale = new Vector3(0.003f, 0.003f, 0f);
    }
    void Update() 
    {
        if (tiger.GetComponent<BoxCollider2D>() == false && tiger.transform.localScale.y < x)
        {
            tiger.transform.Rotate(0f, 0f, -9f);
            tiger.transform.localScale += scale;
        }
        else if (tiger.GetComponent<BoxCollider2D>() == false && tiger.transform.localScale.y > x)
        {
            tiger.transform.localScale -= scale;
            tiger.transform.Rotate(0f, 0f, -9f);
            x -= 0.1f;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GameOverPoint")
        {
            Destroy(GetComponent<BoxCollider2D>());
        }
    }    
}
