using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateRainThunder : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("RainBackground").SetActive(false);
        GameObject.Find("Thunder").SetActive(false);
    }
}
