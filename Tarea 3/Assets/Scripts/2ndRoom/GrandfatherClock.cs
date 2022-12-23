using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrandfatherClock : MonoBehaviour, IInteracteable
{
    [SerializeField] bool hasVase, hasInteracted;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] GameObject destroyedTop;


    [SerializeField] GameObject vase;

    [SerializeField] GameObject interactionSparkle;

    [SerializeField] Canvas canvas;
    [SerializeField] TMP_Text text;
    [SerializeField] string firstInteraction, alreadyInteracted;    

    private void Start()
    {
        vase = GameObject.Find("planta");
    }

    private void Update()
    {
        hasVase = vase.GetComponent<Vase>().GetHasVase();
        if(interactionSparkle.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            PlayerAction();
        }
    }

    public void PlayerAction()
    {
        if(interactionSparkle.activeInHierarchy && !hasVase && !hasInteracted)
        {
            text.text = firstInteraction; 
            canvas.gameObject.SetActive(true);
        }
        if(interactionSparkle.activeInHierarchy && hasVase && !hasInteracted)
        {
            audioSource.PlayOneShot(audioClip);
            destroyedTop.SetActive(true);
            hasInteracted = true;
            GameObject.Find("mesa_sacrificio").GetComponent<TableSacrifice>().SetGlassShard(true);
        }
        if(interactionSparkle.activeInHierarchy && hasInteracted && !hasVase)
        {
            text.text = alreadyInteracted;
            canvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactionSparkle.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canvas.gameObject.SetActive(false);
        interactionSparkle.SetActive(false);
    }
}
