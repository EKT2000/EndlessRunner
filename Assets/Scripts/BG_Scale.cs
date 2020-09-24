using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class BG_Scale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        //ermitteln der Höhe der Spielansicht. "Camera.main.orthographicsize" ermittelt die Hälfte der Höhe, daher *2
        float height = Camera.main.orthographicSize * 2f;

        //ermitteln der Breite des Bildes
        float width = height * Screen.width/ Screen.height;

        transform.localScale = new Vector3(width, height, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
