using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Shotgun : MonoBehaviour
{
    [SerializeField] GameObject interactionSparkle;
    [SerializeField] GameObject door, enemy;

    private void Start()
    {
        EnemySpawn();
    }


    private void Update()
    {
        PlayerAction();
    }

    void EnemySpawn()
    {
        door.SetActive(false);
        enemy.SetActive(true);
    }

    void PlayerAction()
    {
        if(interactionSparkle.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            interactionSparkle.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactionSparkle.SetActive(false);
    }
}
