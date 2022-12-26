using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] Vector2 playerPos;
    [SerializeField] Vector2 newPos;
    [SerializeField] Animator playerAnim;
    [SerializeField] bool isInMinigame;
    private void Start()
    {
        playerPos = gameObject.transform.position;
    }

    private void Update()
    {
        if(!isInMinigame)
        {
            Movement();
        }
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

        transform.position += playerSpeed * Time.deltaTime * new Vector3(x, y).normalized;
        
    }

    public void Death()
    {
        Destroy(gameObject);
    }
    void GetVelocity()
    {
        newPos = gameObject.transform.position;
        float distance = playerPos.magnitude - newPos.magnitude;
        playerPos = gameObject.transform.position;
        playerAnim.SetFloat("velocity", distance);
    }


    public void SetIsInMinigame(bool newState)
    {
        isInMinigame = newState;
    }

}
