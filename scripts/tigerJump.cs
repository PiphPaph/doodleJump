using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class tigerJump : MonoBehaviour
{
    private bool onPlatform;
    private GameObject Tiger;

    void Start() 
    {
        Tiger = GameObject.Find("tigerTheJumper");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tiger")
        {
            onPlatform = true;
            Debug.Log(onPlatform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "tiger")
        {
            onPlatform = false;
            Debug.Log(onPlatform);
        }
    }
    
    void Update() 
    {
        if (onPlatform == true) 
        {
           Tiger.GetComponent<Rigidbody2D>().AddForce(transform.up * 15f, ForceMode2D.Impulse);
        }
        
    }
}
