using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyMovement : MonoBehaviour
{

    [SerializeField] bool canMove;
    [SerializeField] Animator anim;
    [SerializeField] AudioSource monsterRoar;
    [SerializeField] AudioClip roar;

    [SerializeField] float enemySpeed;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(3, 7);
    }

    private void FixedUpdate()
    {
        Logic();
    }

    void Logic()
    {
        Vector2 pos = transform.position;
        Vector2 playerPos = GameObject.Find("PlayerStuff").transform.position;
        if(canMove)
        {
            if(!monsterRoar.isPlaying)
            {
                monsterRoar.PlayOneShot(roar, 0.25f);
            }
            transform.position = Vector2.MoveTowards(pos, playerPos, enemySpeed * Time.deltaTime);
            anim.Play("Run");
        }


        float distance = Vector2.Distance(pos, playerPos);
        if(distance <= 0.5f)
        {
            PlayerDeath();
        }
        Debug.Log(pos);
        Debug.Log(playerPos);
        Debug.Log(distance);
    }

    void PlayerDeath()
    {
        GameObject.Find("PlayerStuff").GetComponent<PlayerController>().Death();
        SceneManager.LoadScene("PlayerDeath");
    }

    public void SetCanMove(bool newState)
    {
        canMove = newState;
    }
}
