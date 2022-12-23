using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostCinemaReturn : MonoBehaviour
{
    [SerializeField] float playerXPos, playerYPos;

    private void Start()
    {
        PlayerPrefs.GetFloat("playerXPos", playerXPos);
        PlayerPrefs.GetFloat("playerYPos", playerYPos);

        GameObject.Find("PlayerStuff").transform.SetPositionAndRotation(new Vector3(playerXPos, playerYPos), Quaternion.identity);
    }
}
