using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNormalPlatform : MonoBehaviour
{
    public GameObject normalPlatformPrefab;
    public int maxNormalPlatform = 5;
    public double timeSpawn = 2;
    private double timer;

    private float minimX = -2f;
    private float maximX = 5f;

    void Start()
    {
        timer = timeSpawn;
        GenerateChunk(-2f, 5f); 
    }
    void GenerateChunk(float minX, float maxX)
    {
        var posY = GameObject.FindGameObjectWithTag("tiger").transform.position;
        Vector2 spawnPosition = new Vector2(0f, posY.y + 10);

        for (int i = 0; i < maxNormalPlatform; i++)
        {
            spawnPosition.x = Random.Range(minimX, maximX);
            GameObject destroyPlatform = Instantiate(normalPlatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
            Destroy(destroyPlatform, 7f);
        }
    }


    void Update()
    {
        timer -= Time.deltaTime;
         if (timer <= 0) 
         {
             timer = timeSpawn;
             if (transform.childCount < maxNormalPlatform)
             {
                GenerateChunk(minimX, maximX);
             }
         }
            
    }
}
