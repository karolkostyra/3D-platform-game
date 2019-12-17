using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_animation : MonoBehaviour
{
    [SerializeField] private float delayTime;
    private Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        StartCoroutine(PlayAnimation());
    }

    IEnumerator PlayAnimation()
    {
        while (true)
        {
            anim.Play();
            yield return new WaitForSeconds(delayTime);
        }
    }
}
