using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] GameObject lowestGroundPoint;


    private void Update()
    {
        FallDetection();
    }

    private void FallDetection()
    {
        if(gameObject.transform.position.y < lowestGroundPoint.transform.position.y)
        {
            Destroy(gameObject, 2);
        }
    }
}
