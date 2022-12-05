using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interaction : MonoBehaviour, IInteracteable
{
    [SerializeField] bool hasInteracted;
    [SerializeField] GameObject interactionSparkle;
    [SerializeField] Canvas canvas;
    [SerializeField] TMP_Text text;
    [SerializeField] string firstInteraction, alreadyInteracted;

    private void Update()
    {
        SparkleControl();
        PlayerAction();
    }


    public void PlayerAction()
    {
        if (canvas.gameObject.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
        { 
            DialogueControl();
        }
    }

    void DialogueControl()
    {
        if(hasInteracted == true)
        {
            text.text = alreadyInteracted;
        }
    }

    void SparkleControl()
    {
        if (interactionSparkle.activeInHierarchy)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                text.text = firstInteraction;
                canvas.gameObject.SetActive(true);
            }
        }
        else
        {
            canvas.gameObject.SetActive(false);
        }
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

    public void SetHasInteracted(bool newHasInteracted)
    {
        this.hasInteracted = newHasInteracted;
    }
}
