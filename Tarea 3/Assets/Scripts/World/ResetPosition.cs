using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject p = GameObject.Find("PlayerStuff");
        p.transform.SetPositionAndRotation(new Vector3(-66.6f, 1.1f, 0f), Quaternion.identity);
    }
}
