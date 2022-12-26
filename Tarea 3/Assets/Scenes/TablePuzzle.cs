using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TablePuzzle : MonoBehaviour
{
    [SerializeField] GameObject interactionSparkle;
    [SerializeField] Canvas canvas, minigame;
    [SerializeField] TMP_Text text;
    [SerializeField] string firstInteraction;


    private void Update()
    {
        if(interactionSparkle.activeInHierarchy)
        {
            PlayerAction();
        }
    }

    void PlayerAction()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            text.text = firstInteraction;
            canvas.gameObject.SetActive(true);
        }
    }


    public void StartMinigame()
    {
        canvas.gameObject.SetActive(false);
        minigame.gameObject.SetActive(true);
        GameObject.Find("PlayerStuff").GetComponent<PlayerController>().SetIsInMinigame(true);
    }

    public void CloseMinigame()
    {
        minigame.gameObject.SetActive(false);
        GameObject.Find("PlayerStuff").GetComponent<PlayerController>().SetIsInMinigame(false);
    }

    public void WinMinigame()
    {
        Destroy(GameObject.Find("PlayerStuff"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            interactionSparkle.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactionSparkle.SetActive(false);
        canvas.gameObject.SetActive(false);
    }
}
