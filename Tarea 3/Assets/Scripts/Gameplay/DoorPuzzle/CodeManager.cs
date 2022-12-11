using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeManager : MonoBehaviour
{
    [SerializeField] AudioSource buttonSFX;

    [SerializeField] AudioClip buttonPress;
    [SerializeField] AudioClip failedCode;
    [SerializeField] AudioClip solutionSFX;

    [SerializeField] int clicks;
    [SerializeField] int solution = 30;
    [SerializeField] int playerInput;

    [SerializeField] GameObject nextLevelSector;

    private void Update()
    {
        if(clicks == 4)
        {
            Solved();
        }
    }
     
    public void One()
    {
        playerInput += 1;
        clicks++;
        buttonSFX.PlayOneShot(buttonPress);
    }

    public void Two()
    {
        playerInput *= 2;
        clicks++;
        buttonSFX.PlayOneShot(buttonPress);
    }

    public void Three()
    {
        playerInput *= 3;
        clicks++;
        buttonSFX.PlayOneShot(buttonPress);
    }

    public void Four()
    {
        playerInput += 4;
        clicks++;
        buttonSFX.PlayOneShot(buttonPress);
    }


    void Solved()
    {
        if (playerInput == solution)
        {
            StartCoroutine(Unlocked());
        }
        else
        {
            buttonSFX.PlayOneShot(failedCode);
            playerInput = 0;
            clicks = 0;
        }
    }

    IEnumerator Unlocked()
    {
        buttonSFX.PlayOneShot(solutionSFX);
        yield return new WaitForSeconds(2.6f);
        nextLevelSector.SetActive(true);
        Destroy(gameObject);
    }
    

    public void SetPlayerInput(int newNumber)
    {
        playerInput = newNumber;
    }

    public void SetClicks(int newClicks)
    {
        clicks = newClicks;
    }

}
