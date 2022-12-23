using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyMovement : MonoBehaviour
{

    [SerializeField] bool canMove;

    [SerializeField] float enemySpeed;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(3, 7);
    }

    private void Update()
    {
        if(canMove)
        {
            Logic();
        }
    }

    void Logic()
    {
        Vector2 pos = transform.position;
        Vector2 playerPos = GameObject.Find("PlayerStuff").transform.position;
        Vector2.MoveTowards(pos, playerPos, enemySpeed * Time.deltaTime);

        float distance = Vector2.Distance(pos, playerPos);
        if(distance <= 0.5f)
        {
            PlayerDeath();
        }


    }

    void PlayerDeath()
    {
        SceneManager.LoadScene("PlayerDeathFaceStealer");
    }

    public void SetCanMove(bool newState)
    {
        canMove = newState;
    }
}
