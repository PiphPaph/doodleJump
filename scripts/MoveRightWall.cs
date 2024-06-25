using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightWall : MonoBehaviour
{
    private GameObject wallRight;
    private float posXRight;
    private GameObject tiger;
    private float tigerPosY;
    void Start()
    {
        wallRight = GameObject.Find("blueportal");
        posXRight = wallRight.transform.position.x;
        tiger = GameObject.Find("tigerTheJumper");
        tigerPosY = tiger.transform.position.y;
    }
    void Update()
    {
        tigerPosY = tiger.transform.position.y;
        transform.position = new Vector2(posXRight, tigerPosY);
    }
}
