using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] Vector2 playerPos;
    [SerializeField] Vector2 newPos;
    [SerializeField] Animator playerAnim;

    private void Start()
    {
        playerPos = gameObject.transform.position;
    }

    private void Update()
    {
        Movement();
        GetVelocity();
    }

    void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        playerAnim.SetFloat("x", x);
        playerAnim.SetFloat("y", y);

        if(x != 0 || y != 0)
        {
            playerAnim.SetFloat("lastX", x);
            playerAnim.SetFloat("lastY", y);
        }

        transform.position += new Vector3(x, y).normalized * playerSpeed * Time.deltaTime;
        
    }


    void GetVelocity()
    {
        newPos = gameObject.transform.position;
        float distance = playerPos.magnitude - newPos.magnitude;
        playerPos = gameObject.transform.position;
        playerAnim.SetFloat("velocity", distance);
    }
}
