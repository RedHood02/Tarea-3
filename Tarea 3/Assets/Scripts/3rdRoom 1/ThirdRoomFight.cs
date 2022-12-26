using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdRoomFight : MonoBehaviour
{
    [SerializeField] GameObject interactionSparke;
    [SerializeField] Canvas minigameCanvas, dialogeCanvas;


    private void Update()
    {
        if(interactionSparke.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            PlayerAction();
        }
    }

    void PlayerAction()
    {
        if(interactionSparke.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            dialogeCanvas.gameObject.SetActive(true);
        }
    }

    public void StartMinigame()
    {
        interactionSparke.SetActive(false);
        minigameCanvas.gameObject.SetActive(true);
        GameObject.Find("PlayerStuff").GetComponent<PlayerController>().SetIsInMinigame(true);
    }

    public void StopMinigame()
    {
        minigameCanvas.gameObject.SetActive(false);
        GameObject.Find("PlayerStuff").GetComponent<PlayerController>().SetIsInMinigame(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            interactionSparke.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactionSparke.SetActive(false);
        GameObject.Find("PlayerStuff").GetComponent<PlayerController>().SetIsInMinigame(false);
    }


}
