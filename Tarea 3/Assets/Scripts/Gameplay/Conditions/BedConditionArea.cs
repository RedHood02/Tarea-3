using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedConditionArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bed"))
        {
            collision.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            collision.GetComponent<Interaction>().SetHasInteracted(true);
        }
    }
}
