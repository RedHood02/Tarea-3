using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUp : ButtonMaster
{
    protected ButtonUp(Animator anim) : base(anim)
    {
    }

    public void MouseEnter()
    {

        anim.Play("MovingUp");
    }

    public void MouseExit()
    {

        anim.Play("NoMovement");
    }
}
