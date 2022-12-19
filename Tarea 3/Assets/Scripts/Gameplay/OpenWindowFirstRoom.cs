using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindowFirstRoom : MonoBehaviour, IInteracteable
{
    [SerializeField] GameObject symbolGameObject;
    [SerializeField] GameObject interactionSparkle;

    [SerializeField] bool hasInteracted;

    [SerializeField] Animator anim;

    private void Update()
    {
        PlayerAction();
    }

    public void PlayerAction()
    {
        if(interactionSparkle.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(OpenWindow());
        }

    }

    IEnumerator OpenWindow()
    {
        anim.Play("Window");
        yield return new WaitForSeconds(0.52f);
        symbolGameObject.SetActive(true);
        SetHasInteracted(true);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasInteracted)
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
