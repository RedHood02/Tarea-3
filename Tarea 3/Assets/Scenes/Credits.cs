using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(MainMenuReturn());
    }

    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * 10;
    }

    IEnumerator MainMenuReturn()
    {
        yield return new WaitForSeconds(20f);
        SceneManager.LoadScene("MainMenu");
    }
}
