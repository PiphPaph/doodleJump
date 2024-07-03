using UnityEngine;


public class EndScreen : MonoBehaviour
{
    void Start() 
    {
        GetComponent<Renderer>().enabled = false;
    }

    void Update() 
    {
        if (EndGameTiger.tiger.GetComponent<BoxCollider2D>() == false) 
        {
            GetComponent<Renderer>().enabled = true;
            GetComponent<AudioSource>().enabled = true;
        }
    }
}
