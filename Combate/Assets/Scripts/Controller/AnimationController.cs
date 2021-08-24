using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;


    public void ShieldAnim(bool state)
    {
        animator.SetBool("Shield",state);
    }

    public void ParryAnim()
    {
        animator.SetBool("Parry",true);
    }
    

    public void EndScene(String animation)
    {
        animator.SetBool(animation,false);
        //animator.SetBool("Shield",true);
    }
}
