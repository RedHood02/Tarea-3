using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Thunder : MonoBehaviour
{
    [SerializeField] Light2D thunderLight;

    [SerializeField] AudioSource thunderSFX;
    [SerializeField] AudioClip thunder1;
    [SerializeField] AudioClip thunder2;
    [SerializeField] AudioClip thunder3;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        StartCoroutine(ThunderController());
    }


    IEnumerator ThunderController()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(2f, 4f));
            int value = Random.Range(0, 5);
            Debug.Log(value);
            if(value == 1)
            {
                int value2 = Random.Range(1, 3);
                Debug.Log(value2);
                if(value2 == 1)
                {
                    StartCoroutine(Thunder1());
                }
                else if(value2 == 2)
                {
                    StartCoroutine(Thunder2());
                }
                else if(value2 == 3)
                {
                    StartCoroutine(Thunder3());
                }

            }
            else
            {
                yield return null;
            }
        }
    }


    IEnumerator Thunder1()
    {
        thunderSFX.PlayOneShot(thunder1); //Distant
        thunderLight.intensity = 0.75f;
        yield return new WaitForSeconds(2f);
        thunderLight.intensity = 0f;
        yield break;
    }

    IEnumerator Thunder2()
    {
        thunderSFX.PlayOneShot(thunder2); //Very Distant
        thunderLight.intensity = 0.55f;
        yield return new WaitForSeconds(2f);
        thunderLight.intensity = 0f;
        yield break;
    }

    IEnumerator Thunder3()
    {
        thunderSFX.PlayOneShot(thunder3); //Close
        thunderLight.intensity = 1f;
        yield return new WaitForSeconds(3f);
        thunderLight.intensity = 0f;
        yield break;
    }


}
