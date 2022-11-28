using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StoryObjectInteraction : MonoBehaviour, IInteracteable
{
    [SerializeField] protected Animator nightstandAnim;
    [SerializeField] protected Animator dialogueBoxAnim;
    [SerializeField] protected bool withinRange;
    [SerializeField] protected bool pressedE;

    public void DespawnStoryBox()
    {
        nightstandAnim.Play("DialogueBoxDespawn");
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !pressedE)
        {
            withinRange = true;
            nightstandAnim.SetBool("withinRange", true);
        }
        else
        {
            withinRange = false;
            nightstandAnim.SetBool("withinRange", false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        withinRange = false;
        nightstandAnim.SetBool("withinRange", false);
    }
}
