using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TableSacrifice : MonoBehaviour, IInteracteable
{
    [SerializeField] GameObject interactionSparkle;

    [SerializeField] Button button;

    [SerializeField] float playerXPos, playerYPos;

    [SerializeField] bool hasInteracted;
    [SerializeField] bool hasGlassShard;

    [SerializeField] Canvas canvas;
    [SerializeField] TMP_Text text;
    [SerializeField] string firstInteraction, alreadyInteracted;

    //Everything here it's temporary    
    private void Update()
    {
        if(interactionSparkle.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            PlayerAction();
        }
    }

    public void PlayerAction()
    {
        if (!hasInteracted)
        {
            text.text = firstInteraction;
            canvas.gameObject.SetActive(true);
            if(hasGlassShard)
            {
                button.gameObject.SetActive(true);
            }
        }
        else
        {
            text.text = alreadyInteracted;
            canvas.gameObject.SetActive(true);
        }
    }

    public void BloodSacrifice()
    {
        PlayerPrefs.SetFloat("playerXPos", GameObject.Find("PlayerStuff").transform.position.x);
        PlayerPrefs.SetFloat("playerYPos", GameObject.Find("PlayerStuff").transform.position.y);
        GameObject.Find("PlayerStuff").transform.SetPositionAndRotation(new Vector3(100, 100), Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

    public void SetGlassShard(bool newStatus)
    {
        hasGlassShard = newStatus;
    }
}
