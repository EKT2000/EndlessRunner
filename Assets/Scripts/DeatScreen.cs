using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeatScreen : MonoBehaviour
{
    public GameObject Game_Over_Screen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.PlayerAlive == false)
        {
            Game_Over_Screen.SetActive(true);
        }   
    }
}
