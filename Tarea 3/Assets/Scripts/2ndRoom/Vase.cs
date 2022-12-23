using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vase : MonoBehaviour
{

    [SerializeField] GameObject interactionSparkle;

    [SerializeField] int vaseInteractions;
    [SerializeField] bool hasVase;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        VaseController();
    }


    void VaseController()
    {
        if(interactionSparkle.activeInHierarchy && Input.GetKeyDown(KeyCode.E) && !hasVase)
        {
            GetComponentInParent<SpriteRenderer>().enabled = false;
            hasVase = true;
        }
        else if(interactionSparkle.activeInHierarchy && Input.GetKeyDown(KeyCode.E) && hasVase)
        {
            GetComponentInParent<SpriteRenderer>().enabled = true;
            hasVase = false;
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
        interactionSparkle.SetActive(false);
    }
    public bool GetHasVase()
    {
        return this.hasVase;
    }
}
