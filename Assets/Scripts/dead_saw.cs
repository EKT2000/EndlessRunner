using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead_saw : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth.PlayerAlive = false;

        BG_Animation.animationspeed = 0;
        ObstacleMovement.speed = 0f;


    }
}
