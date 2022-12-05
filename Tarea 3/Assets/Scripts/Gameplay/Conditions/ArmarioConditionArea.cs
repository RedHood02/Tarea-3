using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmarioConditionArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Armario"))
        {
            collision.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            collision.GetComponent<Interaction>().SetHasInteracted(true);
        }
    }
}
