using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomSpawning : MonoBehaviour
{
    [SerializeField] float minX, minY, maxX, maxY;
    [SerializeField] Vector2 pos;
    [SerializeField] GameObject enemyToSpawn;
    [SerializeField] GameObject actualEnemy;
    [SerializeField] GameObject clockMidnight;
    [SerializeField] GameObject sacrificeTable;

    [SerializeField] int spawnTicks;


    //Spawn System will be changed once mechancis are added

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private void Update()
    {
        if(spawnTicks == 6)
        { 
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        
        clockMidnight.SetActive(true);
        yield return new WaitForSeconds(5f);
        actualEnemy.GetComponent<EnemyMovement>().SetCanMove(true);
        Destroy(gameObject);
        sacrificeTable.SetActive(false);
        yield break;
    }


    IEnumerator Spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(10,20));
            pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            if(pos.x < 0)
            {
                StartCoroutine(LeftScreenSpawner());
            }
            else
            {
                StartCoroutine(RightScreenSpawner());
            }
        }
    }

    IEnumerator LeftScreenSpawner()
    {
        
        Instantiate(enemyToSpawn, pos, Quaternion.identity);
        GameObject gm = GameObject.Find("ladroncara(Clone)");
        SpriteRenderer render = gm.GetComponent<SpriteRenderer>();
        render.flipX = true;
        yield return new WaitForSeconds(0.2f);
        if(gm.activeInHierarchy)
        {
            Destroy(gm);
            spawnTicks++;
        }
    }

    IEnumerator RightScreenSpawner()
    {
        
        Instantiate(enemyToSpawn, pos, Quaternion.identity);
        GameObject gm = GameObject.Find("ladroncara(Clone)");
        yield return new WaitForSeconds(0.2f);
        if (gm.activeInHierarchy)
        {
            Destroy(gm);
            spawnTicks++;
        }
    }
}
