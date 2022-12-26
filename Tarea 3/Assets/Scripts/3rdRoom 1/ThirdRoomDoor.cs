using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdRoomDoor : MonoBehaviour
{
    [SerializeField] GameObject door, wall1, wall2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Destroy(wall1);
            Destroy(wall2);
            door.SetActive(true);
            Destroy(gameObject);
        }
    }
}
