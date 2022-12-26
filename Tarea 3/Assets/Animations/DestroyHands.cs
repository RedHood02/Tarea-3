using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHands : MonoBehaviour
{
    [SerializeField] GameObject handWithKnife;
    [SerializeField] GameObject handWithout;


    private void Start()
    {
        StartCoroutine(Hand1());
        StartCoroutine(Hand2());
    }   


    IEnumerator Hand1()
    {
        yield return new WaitForSeconds(10f);
        Destroy(handWithKnife);
    }

    IEnumerator Hand2()
    {
        yield return new WaitForSeconds(11.66f);
        Destroy(handWithout);
    }
}
