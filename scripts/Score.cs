using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platformUp")
        {
            score++;
        }
    }
}
