using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DarkPortal : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string setLevel = "level2";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Teleport do " + setLevel);
            SceneManager.LoadScene(setLevel);
            var newLevelNumber = PlayerPrefs.GetInt("_unlockedLevels") + 1;
            PlayerPrefs.SetInt("_unlockedLevels", newLevelNumber);
        }
    }
        
    
}
