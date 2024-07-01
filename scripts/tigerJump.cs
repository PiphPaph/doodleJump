using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class tigerJump : MonoBehaviour
{
    private bool onPlatform;
    private GameObject Tiger;
    private float maxSpeed = 15f;

    void Start() 
    {
        Tiger = GameObject.Find("tigerTheJumper");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tiger")
        {
            onPlatform = true;
            
        }
    }
    private void OnCollisionExit2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "tiger")
        {
            onPlatform = false;
           
        }
    }
    
    void Update() 
    {
        if (onPlatform == true) 
        {
           Tiger.GetComponent<Rigidbody2D>().AddForce(transform.up * 15f, ForceMode2D.Impulse);
            if(Tiger.GetComponent<Rigidbody2D>().velocity.magnitude > maxSpeed) 
            {
                Tiger.GetComponent<Rigidbody2D>().velocity = Tiger.GetComponent<Rigidbody2D>().velocity.normalized * maxSpeed;
            }
        }
        
    }
}
