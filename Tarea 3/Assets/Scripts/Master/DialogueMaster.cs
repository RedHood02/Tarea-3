using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueMaster : MonoBehaviour
{
    private Queue<string> Dialogue;

    // Start is called before the first frame update
    void Start()
    {
        Dialogue = new Queue<string>();
    }

}
