﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collInfo)
    {
        var obj = collInfo.collider;
        string obstaclesTag = "Obstacles";
        if (obj.tag == obstaclesTag) movement.enabled = false;
    }
}
