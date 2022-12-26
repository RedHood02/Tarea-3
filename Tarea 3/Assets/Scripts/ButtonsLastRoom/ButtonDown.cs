using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDown : ButtonMaster
{
    protected ButtonDown(Animator anim) : base(anim)
    {
    }

    public void MouseEnter()
    {

        anim.Play("Moving");
    }

    public void MouseExit()
    {

        anim.Play("NoMovement");
    }
}
