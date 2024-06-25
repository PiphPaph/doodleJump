using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftWall : MonoBehaviour
{
    private GameObject wallLeft;
    private float posXLeft;
    private GameObject tiger;
    private float tigerPosY;
    void Start()
    {
        wallLeft = GameObject.Find("redportal");
        posXLeft = wallLeft.transform.position.x;
        tiger = GameObject.Find("tigerTheJumper");
        tigerPosY = tiger.transform.position.y;
    }
    void Update()
    {
        tigerPosY = tiger.transform.position.y;
        transform.position = new Vector2(posXLeft, tigerPosY);
    }
}
