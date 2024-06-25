using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpOnLeftSide : MonoBehaviour
{
    private float posY;
    void Update() 
    {
        posY = this.transform.position.y;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RightWall")
        {
            transform.position = new Vector2(-3f, posY);
            Debug.Log("Left");
        }
        else if (collision.gameObject.tag == "LeftWall") 
        {
            transform.position = new Vector2(3f, posY);
            Debug.Log("right");
        }
    }
}
