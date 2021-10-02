﻿// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndController : MonoBehaviour
{

    public Transform teleportTo;

    // Start is called before the first frame update
    // verification of whether the player fell out of the world
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // check if the bottom of the level collides with the player
        if (collision.transform.name.Equals("Hero"))
        {
            Vector3 position = teleportTo.GetComponent<Transform>().position;
            Player.player.Teleport(position.x, position.y, position.z);
            Player.player.HeroDamage(5);
        }
    }
}
