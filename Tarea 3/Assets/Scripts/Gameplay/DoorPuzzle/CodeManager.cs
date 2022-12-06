using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeManager : MonoBehaviour
{
    [SerializeField] AudioSource buttonSFX;
    [SerializeField] int code = 1324;
    [SerializeField] int playerInput;



    private void Update()
    {
        Solved();
    }
     
    public void One()
    {
        buttonSFX.Play();
    }

    public void Two()
    {
        buttonSFX.Play();
    }

    public void Three()
    {
        buttonSFX.Play();
    }

    public void Four()
    {
        buttonSFX.Play();
    }

   
    void Solved()
    {
        if (playerInput == code)
        {
            buttonSFX.Play();
            Destroy(gameObject);
        }
    }
    

}
