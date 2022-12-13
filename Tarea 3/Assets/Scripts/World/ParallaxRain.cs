using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxRain : MonoBehaviour
{
    [SerializeField] RawImage _img;
    [SerializeField] float x, y;



    private void FixedUpdate()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(x, y) * Time.deltaTime, _img.uvRect.size);
    }
}