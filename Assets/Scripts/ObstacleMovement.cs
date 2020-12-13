using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public static float speed = -5f;
    public Rigidbody2D ObstacleRB;
    
    // Start is called before the first frame update
    void Start()
    {
        ObstacleRB = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        ObstacleRB.velocity = new Vector2(speed, 0);
        speed = speed-0.0004f;
            if (PlayerHealth.PlayerAlive == false)
        {
            speed = -5f;
        }
    }  
}
