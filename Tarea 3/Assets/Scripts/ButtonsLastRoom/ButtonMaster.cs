using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMaster : MonoBehaviour
{
    [SerializeField] protected Animator anim;

    protected ButtonMaster(Animator anim)
    {
        anim = this.anim;
    }
        

}
