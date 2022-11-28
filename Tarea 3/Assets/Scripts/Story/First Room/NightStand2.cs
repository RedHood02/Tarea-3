using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NightStand2 : StoryObjectInteraction, IInteracteable
{
    /*[SerializeField]*/ TMP_Text text; 
    private void Update()
    {
        Interact();
    }

    public void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E) && withinRange)
        {
            dialogueBoxAnim.Play("TextBoxSpawn");
            BoxTextChanger();
            nightstandAnim.SetBool("withinRange", false);
        }

        if (!withinRange)
        {
            dialogueBoxAnim.Play("TextBoxDespawn");
            nightstandAnim.SetBool("withinRange", false);
        }
    }

    void BoxTextChanger()
    {
        text = (TMP_Text)FindObjectOfType(typeof(TMP_Text));
        text.text = "Nightstand 2";
    }

}
