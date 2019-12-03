using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sprint : MonoBehaviour
{
    PlayerController pc;
    private float stamina, maxStamina;
    private float walkSpeed, runSpeed;
    private bool isRunning = false;
    private Rect staminaRect;
    private Texture2D staminaTexture;


    private void Start()
    {
        pc = gameObject.GetComponent<PlayerController>();
        stamina = maxStamina = 1;
        walkSpeed = pc.moveSpeed;
        runSpeed = walkSpeed * 2;

        staminaRect = new Rect(Screen.width/20, Screen.height*9/10, Screen.width/5, Screen.height/50);
        staminaTexture = new Texture2D(1, 1);
        staminaTexture.SetPixel(0, 0, Color.green);
        staminaTexture.Apply();
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && pc.Grounded())
        {
            SetRunning(true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            SetRunning(false);
        }

        if (isRunning)
        {
            stamina -= Time.deltaTime;
            if (stamina < 0)
            {
                stamina = 0;
                SetRunning(false);
            }
        }
        else if (stamina < maxStamina)
        {
            stamina += Time.deltaTime;
        }
    }

    private void SetRunning(bool isRunning)
    {
        this.isRunning = isRunning;
        pc.moveSpeed = isRunning ? runSpeed : walkSpeed;
    }

    private void OnGUI()
    {
        float ratio = stamina / maxStamina;
        float rectWidth = ratio * Screen.width / 5;
        staminaRect.width = rectWidth;
        GUI.DrawTexture(staminaRect, staminaTexture);


        GUIStyle staminaLabel = new GUIStyle("Label");
        staminaLabel.fontSize = 24;
        staminaLabel.normal.textColor = Color.black;

        GUI.Label(new Rect(Screen.width/20, Screen.height*9/10-35, 100, 50), "Stamina", staminaLabel);
    }
}