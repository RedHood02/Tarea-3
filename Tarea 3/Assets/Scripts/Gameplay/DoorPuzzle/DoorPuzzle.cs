using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorPuzzle : MonoBehaviour
{
    [SerializeField] bool playerInMinigame;


    [SerializeField] PlayerController p;
    [SerializeField] CodeManager c;

    [SerializeField] GameObject interactionSparkle;

    [SerializeField] Canvas canvasMinigame;
    [SerializeField] Canvas canvasText;

    [SerializeField] TMP_Text text;
    [SerializeField] string firstInteraction;

    [SerializeField] AudioSource SFX;
    [SerializeField] AudioClip lockedSFX;
    [SerializeField] AudioClip unlockedSFX;

    private void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        c = gameObject.GetComponent<CodeManager>();
    }


    private void Update()
    {
        SparkleControl();
        PlayerChecker();
    }


    void SparkleControl()
    {
        if (interactionSparkle.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.E) && !playerInMinigame)
            {
                text.text = firstInteraction;
                SFX.PlayOneShot(lockedSFX);
                canvasText.gameObject.SetActive(true);
            }
        }
        else
        {
            canvasText.gameObject.SetActive(false);
        }
    }


    public void MinigameControl()
    {
        if(canvasText.gameObject.activeInHierarchy)
        {
            playerInMinigame = true;
            canvasText.gameObject.SetActive(false);
            canvasMinigame.gameObject.SetActive(true);
        }
    }


    public void CloseMinigame()
    {
        canvasMinigame.gameObject.SetActive(false);
        playerInMinigame = false;
        c.SetClicks(0);
        c.SetPlayerInput(0);
    }

    private void OnDestroy()
    {
        p.SetIsInMinigame(playerInMinigame = false);
    }

    void PlayerChecker()
    {
        p.SetIsInMinigame(playerInMinigame);
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
    }
}
