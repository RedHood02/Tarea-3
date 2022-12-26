using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseScale : MonoBehaviour
{

    [SerializeField] Button button;

    private void OnMouseOver()
    {
        button.gameObject.transform.localScale = new Vector2(1.25f, 1.25f);
    }

    private void OnMouseExit()
    {
        button.gameObject.transform.localScale = new Vector2(1f, 1f);
    }
}
