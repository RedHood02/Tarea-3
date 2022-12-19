using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoom : MonoBehaviour
{
    [SerializeField] SpriteRenderer wall1, wall2, wall3;
    [SerializeField] GameObject shelf;
    [SerializeField] GameObject windowManager;
    [SerializeField] GameObject hospitalBed;
    [SerializeField] GameObject hospitalPlant;

    [SerializeField] GameObject trigger;

    [SerializeField] GameObject rainBackground;
    [SerializeField] GameObject Thunder;


    [SerializeField] AudioSource hallucinationSource;
    [SerializeField] AudioClip heartMonitor1;
    [SerializeField] GameObject enemySprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && rainBackground == null)
        {
            rainBackground = GameObject.Find("RainBackground");
            StartCoroutine(Hallucination());
        }
    }


    IEnumerator Hallucination()
    {
        wall1.color = new Color32(4, 116, 237, 255);
        wall2.color = new Color32(4, 116, 237, 255);
        wall3.color = new Color32(4, 116, 237, 255);
        rainBackground.SetActive(false);
        windowManager.SetActive(false);
        shelf.SetActive(false);
        Thunder.SetActive(false);
        hospitalBed.SetActive(true);
        hospitalPlant.SetActive(true);
        hallucinationSource.clip = heartMonitor1;
        hallucinationSource.Play();
        yield return new WaitForSeconds(10f);
        hallucinationSource.Stop();
        enemySprite.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        enemySprite.SetActive(false);
        hospitalPlant.SetActive(false);
        hospitalBed.SetActive(false);
        wall1.color = new Color32(223, 113, 38, 255);
        wall2.color = new Color32(223, 113, 38, 255);
        wall3.color = new Color32(223, 113, 38, 255);
        rainBackground.SetActive(true);
        Thunder.SetActive(true);
        shelf.SetActive(true);
        windowManager.SetActive(true);
        Destroy(gameObject);
    }
}
