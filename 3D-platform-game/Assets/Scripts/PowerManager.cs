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

   public void AddPower(bool powerToAdd, int jump_value)
    {
        pc = FindObjectOfType<PlayerController>();     
        pc.double_jump = powerToAdd;
        pc.jump_jump = jump_value;
    }
}
