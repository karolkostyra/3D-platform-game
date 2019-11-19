using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject lowestGroundPoint;

    private Vector3 playerSpawnPosition;
    private Quaternion playerSpawnRotation;


    private void Start()
    {
        playerSpawnPosition = player.transform.position;
        playerSpawnRotation = player.transform.rotation;
    }

    private void Update()
    {
        FallDetection();
    }

    private void FallDetection()
    {
        if(player.transform.position.y < lowestGroundPoint.transform.position.y-2)
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        player.transform.position = playerSpawnPosition;
        player.transform.rotation = playerSpawnRotation;
    }
}
