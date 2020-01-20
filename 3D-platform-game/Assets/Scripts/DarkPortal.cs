using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DarkPortal : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] string setLevel = "level2";
    private GoldManager gameManager;

    public Text more_gold;



    private void Start()
    {
        gameManager = FindObjectOfType<GoldManager>();
    }

    void hide_text()
    {
        more_gold.gameObject.SetActive(false);
    }

 

    private void OnTriggerEnter(Collider other)
    {
        if (gameManager.currentGold >= 2)
        {
            
            if (other.gameObject.tag == "Player")
            {         
                Debug.Log("Teleport do " + setLevel);
                
                SceneManager.LoadScene(setLevel);
                var newLevelNumber = PlayerPrefs.GetInt("_unlockedLevels") + 1;
                PlayerPrefs.SetInt("_unlockedLevels", newLevelNumber);
            }
        }
        else
        {
            var boxCollider = gameObject.AddComponent<BoxCollider>();
            boxCollider.isTrigger = false;

            more_gold.text = "Zbierz wiecej złota!!";
            more_gold.gameObject.SetActive(true);

            Invoke("hide_text", 3.0f);
            


        }
        
    }

        
    
}
