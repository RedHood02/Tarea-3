using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class NecronomiconPickUp : MonoBehaviour
{
    [SerializeField] bool hasInteracted;
    [SerializeField] GameObject interactionSparkle;
    [SerializeField] Canvas canvas;
    [SerializeField] TMP_Text text;
    [SerializeField] string firstInteraction, alreadyInteracted;
    [SerializeField] Button button;
    [SerializeField] SpriteRenderer sprite;

    private void Update()
    {
        SparkleControl();
    }



    void SparkleControl()
    {
        if (interactionSparkle.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.E))
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

    public void TakeBook()
    {
        GameObject.Find("Door (3)").GetComponent<SecondRoomDoorPostCinematic>().SetHasKey(true);
        sprite.enabled = false;
        text.text = alreadyInteracted;
        interactionSparkle.GetComponent<SpriteRenderer>().enabled = false;
        button.gameObject.SetActive(false);
        hasInteracted = true;
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
        if(hasInteracted == true)
        {
            Destroy(gameObject);
        }
    }

    public void SetHasInteracted(bool newHasInteracted)
    {
        this.hasInteracted = newHasInteracted;
    }
}
