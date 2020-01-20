using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickup : MonoBehaviour
{
    public int value;
    private GoldManager gameManager;
    

    private void Start()
    {
        gameManager = FindObjectOfType<GoldManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameManager.AddGold(value);
            
            Destroy(gameObject);
        }
    }


}
