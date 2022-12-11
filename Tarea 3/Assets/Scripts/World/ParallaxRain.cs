using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxRain : MonoBehaviour
{
    [SerializeField] Vector2 startPos;
    [SerializeField] Vector2 curentPos;
    [SerializeField] float moveSpeed;
    [SerializeField] float y;

    private void Start()
    {
        startPos = GameObject.Find("lluvia-Sheet (1)").transform.position;
    }

    private void FixedUpdate()
    {
        curentPos = transform.position;
        transform.position += transform.up * moveSpeed * Time.deltaTime;

        if (curentPos.y <= y)
        {
            transform.position = startPos;
        }
    }   
}