using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPickup : MonoBehaviour
{
    public int value;
    private PowerManager gameManager;
    public bool jump = true;
    

    private void Start()
    {
        gameManager = FindObjectOfType<PowerManager>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameManager.AddPower(jump);
            Destroy(gameObject);
        }
    }


}
