using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPoint : MonoBehaviour
{
    private GameObject tiger;
    private float tigerPosY;
    private GameObject gameOverPoint;
    private float gameOverPointXPos;
    private float currentTigerPosY;


        void Start() 
    {
        gameOverPoint = GameObject.Find("GameOverPoint");
        gameOverPointXPos = gameOverPoint.transform.position.x;
        tiger = GameObject.Find("tigerTheJumper");
        tigerPosY = tiger.transform.position.y;
        currentTigerPosY = tigerPosY;
    }
    void Update() 
    {
        tigerPosY = tiger.transform.position.y;
        if (tigerPosY >= currentTigerPosY) 
        {
            currentTigerPosY = tigerPosY;
            transform.position = new Vector2(gameOverPointXPos, tigerPosY - 30f);
        }
    }
}
