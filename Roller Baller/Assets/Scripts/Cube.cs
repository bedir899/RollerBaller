﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -5f) {
            gameObject.SetActive(false);
        }
    }
}
