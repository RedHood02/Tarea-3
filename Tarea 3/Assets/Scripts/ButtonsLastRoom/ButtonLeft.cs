using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeft : ButtonMaster
{
    protected ButtonLeft(Animator anim) : base(anim)
    {
    }

    public void MouseEnter()
    {

        anim.Play("MovingLeft");
    }

    public void MouseExit()
    {

        anim.Play("NoMovement");
    }
}
