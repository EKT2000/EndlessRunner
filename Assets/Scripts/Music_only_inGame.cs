﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_only_inGame : MonoBehaviour
{
    public AudioSource BG_Audio;

    // Start is called before the first frame update
    void Start()
    {
        BG_Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.PlayerAlive == false)
        {
            BG_Audio.enabled = false;
        }
        
    }
}
