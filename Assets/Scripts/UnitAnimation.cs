using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    Animator animator;

    UnitMovement unitMovement;

    void Start()
    {
        unitMovement = GetComponent<UnitMovement>();
        
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (unitMovement.isMoving)
        {
            SetCurrentAnimation("walking");
        }
        else
        {
            SetCurrentAnimation("idle");
        }
    }

    void SetCurrentAnimation(string animationName)
    {
        foreach (AnimatorControllerParameter parameter in animator.parameters)
        {
            if (parameter.type == AnimatorControllerParameterType.Bool)
            {
                animator.SetBool(parameter.name, false);    
            }
        }

        animator.SetBool(animationName, true);
    }
}