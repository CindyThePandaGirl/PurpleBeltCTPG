﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Default Speed")]
    //Speed for the movement
    public float speed;
  
    // Update is called once per frame
    void Update()
    {
        //transform the object to move to the left
        //according to the axis and speed
        transform.position += Vector3.left * speed * Time.deltaTime;

    }
}
