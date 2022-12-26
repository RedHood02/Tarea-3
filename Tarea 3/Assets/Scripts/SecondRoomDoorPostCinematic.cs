using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRoomDoorPostCinematic : MonoBehaviour
{
    [SerializeField] GameObject door, wall1, wall2, sparkle;
    [SerializeField] bool hasKey;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && sparkle.activeInHierarchy)
        {
            PlayerAction();
        }
    }


    void PlayerAction()
    {
        if(sparkle.activeInHierarchy && hasKey)
        {
            wall1.SetActive(true);
            wall2.SetActive(true);
            door.SetActive(false);
            Destroy(sparkle);
        }
        else
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        { 
            sparkle.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sparkle.SetActive(false);
    }

    public void SetHasKey(bool newState)
    {
        hasKey = newState;
    }
}
