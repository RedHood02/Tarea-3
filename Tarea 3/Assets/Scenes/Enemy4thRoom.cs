using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4thRoom : MonoBehaviour
{
    [SerializeField] float enemySpeed;
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * enemySpeed;
    }
}
