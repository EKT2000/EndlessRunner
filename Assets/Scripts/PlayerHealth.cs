using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static bool PlayerAlive;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerAlive = true;
        Jump.jump_forward = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
