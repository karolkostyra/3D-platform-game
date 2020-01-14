using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DarkPortal : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string setLevel = "level2";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("Teleport do " + setLevel);
                SceneManager.LoadScene(setLevel);
            }
        }
        
    
}
