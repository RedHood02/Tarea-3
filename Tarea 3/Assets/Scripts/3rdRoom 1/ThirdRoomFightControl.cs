using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdRoomFightControl : MonoBehaviour
{
    [SerializeField] GameObject interactionSparke;
    [SerializeField] Animator animator;
    [SerializeField] int windowClosed;

    private void Update()
    {
        if (interactionSparke.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            PlayerAction();
        }

    }

    void PlayerAction()
    {
        if(interactionSparke.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("CorroutineManager").GetComponent<ThirdRpoomCorroutine>().SetWindowsClosed(1);
            animator.Play("CurtainClosing");
        }
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
    }
}
