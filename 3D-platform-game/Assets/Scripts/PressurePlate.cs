using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private Animator animController;
    [SerializeField] private GameObject[] objectsToDeactivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animController.SetBool("playAnim", true);
            SpikeDeactivation();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animController.SetBool("playAnim", false);
        }
    }

    private void SpikeDeactivation()
    {
        foreach(GameObject obj in objectsToDeactivate)
        {
            Animator animSpikeController = obj.GetComponent<Animator>();
            animSpikeController.SetBool("playAnim", true);
            /*
             * if (animSpikeController.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                obj.SetActive(false);
            }
            */
        }
    }
}
