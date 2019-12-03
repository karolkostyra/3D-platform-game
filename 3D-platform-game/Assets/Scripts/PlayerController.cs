using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] float distToGrounded;


    private Rigidbody theRB;
    private Vector3 moveDirection;
    [SerializeField] LayerMask ground;


    private void Start()
    {         
        theRB = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        Move();
        Jump();

        if (Input.GetKeyDown("r"))
        {
            RestartCurrentLevel();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackToMenu();
        }
    }

    private void Move()
    {

        float yStore = theRB.velocity.y;

        //theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
        theRB.velocity = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        theRB.velocity = theRB.velocity.normalized * moveSpeed;

        theRB.velocity = new Vector3(theRB.velocity.x, yStore, theRB.velocity.z);


    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && Grounded())
        {
            theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
        }
    }

    private bool Grounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distToGrounded, ground);
    }

    private void RestartCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
