using UnityEngine;

public class ParalaxBackground : MonoBehaviour
{
    private float lenghtX, lenghtY, startposX, startposY;
    public GameObject cam;
    public float parallax;
    void Start() 
    {
        startposX = transform.position.x;
        startposY = transform.position.y + 12;
        lenghtX = GetComponent<SpriteRenderer>().bounds.size.x;
        lenghtY = GetComponent<SpriteRenderer>().bounds.size.y;
    }
    void Update() 
    {
        float distX = (cam.transform.position.x * parallax);
        float distY = (cam.transform.position.y * parallax);
        transform.position = new Vector2(startposX + distX, startposY + distY);
    }
}
