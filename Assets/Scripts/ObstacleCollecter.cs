﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollecter : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Collector") {
            gameObject.SetActive(false);
        }
    }
}
