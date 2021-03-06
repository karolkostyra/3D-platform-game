﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private Vector3 playerSpawnPosition;
    private Quaternion playerSpawnRotation;
    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        playerSpawnPosition = player.transform.position;
        playerSpawnRotation = player.transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Death zone: " + other.tag);
        
        switch (other.tag)
        {
            case "Player":
                player.GetComponent<PlayerController>().Die();
                //RespawnPlayer(other.gameObject);
                break;
            case "MovableObject":
                DestroyThisObject(other.gameObject);
                break;
        }
    }

    private void DestroyThisObject(GameObject obj)
    {
        Destroy(obj, 2);
    }

    public void RespawnPlayer(GameObject obj)
    {
        obj.transform.position = playerSpawnPosition;
        obj.transform.rotation = playerSpawnRotation;
    }
}
