using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerManager : MonoBehaviour
{
    
    PlayerController pc;

    public void Start()
    {
        pc = FindObjectOfType<PlayerController>();
    }

   public void AddPower(bool powerToAdd)
    {
        pc = FindObjectOfType<PlayerController>();     
        pc.double_jump = powerToAdd;
    }
}
