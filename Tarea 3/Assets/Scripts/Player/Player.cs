using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float moveSpeed;

    [SerializeField] Animator playerAnim;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }



    void Movement()
    {
        float y = Input.GetAxisRaw("Vertical");
        float x = Input.GetAxisRaw("Horizontal");

        transform.position += moveSpeed * Time.deltaTime * y * transform.up;
        transform.position += moveSpeed * Time.deltaTime * x * transform.right;
    }
}
