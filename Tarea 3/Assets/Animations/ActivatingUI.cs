using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivatingUI : MonoBehaviour
{
    [SerializeField] Button buttonUp;

    private void Start()
    {
        StartCoroutine(ActivateButtons());
    }
    IEnumerator ActivateButtons()
    {
        yield return new WaitForSeconds(5f);
        buttonUp.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    

}
