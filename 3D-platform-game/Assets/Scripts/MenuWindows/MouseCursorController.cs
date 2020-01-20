using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorController : MonoBehaviour
{
    public void Hide()
    {
        Cursor.visible = false;
    }

    public void Show()
    {
        Cursor.visible = true;
    }

    public void Lock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Unlock()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
