using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxGameOver : MonoBehaviour
{
    public AudioSource GameOverAudio;

    // Start is called before the first frame update
    void Start()
    {
        GameOverAudio = GetComponent<AudioSource>();
        GameOverAudio.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.PlayerAlive == false)
        {
            
            GameOverAudio.enabled = true;
        }
    }
}
