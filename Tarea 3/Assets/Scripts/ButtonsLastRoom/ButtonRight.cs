using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRight : ButtonMaster
{
    protected ButtonRight(Animator anim) : base(anim)
    {
    }

    public void MouseEnter()
    {

        anim.Play("MovingRight");
    }

    public void MouseExit()
    {

        anim.Play("NoMovement");
    }
}
