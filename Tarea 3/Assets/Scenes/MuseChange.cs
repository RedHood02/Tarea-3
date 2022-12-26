using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuseChange : MonoBehaviour
{
    [SerializeField] Image spriteRendere;
    [SerializeField] Sprite oldSprite, newSprite;


    public void ReplaceSprite()
    {
        spriteRendere.sprite = newSprite;
    }

    public void ReplaceSpriteExit()
    {
        spriteRendere.sprite = oldSprite;
    }
}
