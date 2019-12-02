using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] Transform target;

    [SerializeField] Vector3 offset;

    [SerializeField] float rotateSpeed;

    [SerializeField] Transform pivot;

    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;

        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        // move the pivot instead of target
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(vertical, 0, 0);

        float desiredYAngles = target.eulerAngles.y;
        float desiredXAngles = pivot.eulerAngles.x;

        Quaternion rotation = Quaternion.Euler(desiredXAngles, desiredYAngles, 0);
        transform.position = target.position - (rotation * offset);


        if (transform.position.y < target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y - .5f, transform.position.z);
        }
        
        transform.LookAt(target);
    }
}
