using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ThirdRpoomCorroutine : MonoBehaviour
{
    [SerializeField] Animator window1, window2;
    [SerializeField] GameObject audioStatic, maleWhisper, heartBeat;
    [SerializeField] Canvas canvas;
    [SerializeField] int windowClosed;
    [SerializeField] float timeToRestart = 20f;
    private void Start()
    {
        //StartCoroutine(Timer());
    }
    
    private void Update()
    {
        Debug.Log(windowClosed);
        if (windowClosed == 2)
        {
            heartBeat.SetActive(false);
            audioStatic.SetActive(false);
            maleWhisper.SetActive(false);
            StopCoroutine(Death());
            Debug.Log("Restarted");
        }   
    }

    /*
    IEnumerator Timer()
    {
       while(true)
        {
            timeToRestart -= Time.deltaTime;
            Debug.Log(timeToRestart);
            if (timeToRestart <= 0)
            {
                windowClosed = 0;
                StartCoroutine(Death());
                timeToRestart = 20f;
            }
        }
    }
        */
        public IEnumerator Death()
    {
        window1.Play("OpenCurtain");
        window2.Play("OpenCurtain");
        yield return new WaitForSeconds(3f);
        heartBeat.SetActive(true);
        yield return new WaitForSeconds(3f);
        maleWhisper.SetActive(true);
        yield return new WaitForSeconds(2f);
        audioStatic.SetActive(true);
        yield return new WaitForSeconds(Random.Range(2f, 6f));
        canvas.gameObject.SetActive(false);
        Destroy(GameObject.Find("PlayerStuiff"));
        SceneManager.LoadScene("PlayerDeath");

    }

    public IEnumerator Restart()
    {
        heartBeat.SetActive(false);
        audioStatic.SetActive(false);
        maleWhisper.SetActive(false);
        yield return null;
    }

    public void SetWindowsClosed(int newState)
    {
        windowClosed += newState;
    }    
}
