using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallu : MonoBehaviour
{
    [SerializeField] float speed;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(3, 7);
        gameObject.GetComponent<Animator>().Play("Run");
    }
    private void Update()
    {
        transform.position += speed * Time.deltaTime * transform.right;
    }
}
