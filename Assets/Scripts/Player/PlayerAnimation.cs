﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator _anim;
    private Animator _swordAnimation;


    void Start()
    {
        _anim = GetComponentInChildren<Animator>();
        _swordAnimation = transform.GetChild(1).GetComponent<Animator>();
    }

    // Update is called once per frame
    public void  Move(float move)
    {
        _anim.SetFloat("Move", Mathf.Abs(move));
    }
    public void Jump(bool IsJump)
    {
        _anim.SetBool("Jumping",IsJump);

    }

    public void Attack()
    {
        _anim.SetTrigger("Attack");
        _swordAnimation.SetTrigger("SwordAnimation");
    }
    public void FlameAttack()
    {
        _anim.SetBool("Fire", true);
        _anim.Play("Flame_Sword");
        _swordAnimation.SetTrigger("SwordAnimation");
    }

    public void Death()
    {
        _anim.SetTrigger("Death");
    }
    public void Hit()
    {
        _anim.SetTrigger("Hit");
    }
}
