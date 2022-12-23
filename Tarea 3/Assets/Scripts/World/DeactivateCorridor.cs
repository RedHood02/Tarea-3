using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class DeactivateCorridor : MonoBehaviour
{
    [SerializeField] GameObject wall1, wall2, door;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip doorSlam;
    [SerializeField] AudioClip auioLock;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Entered");
            wall1.SetActive(false);
            wall2.SetActive(false);
            door.SetActive(true);
            StartCoroutine(Sound());    
        }

    }

    IEnumerator Sound()
    {
        audioSource.PlayOneShot(doorSlam);
        yield return new WaitForSeconds(1.7f);
        audioSource.PlayOneShot(auioLock);
        yield return new WaitForSeconds(5.4f);
        Destroy(gameObject);
    }
}
