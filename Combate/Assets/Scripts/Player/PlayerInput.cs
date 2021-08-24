using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update

    private Shield _shield;

    private AnimationController _animationController;

    private Collider2D _collider2D;
    // Update is called once per frame

    private void Start()
    {
        _collider2D = GetComponent<Collider2D>();
        _shield = gameObject.GetComponentInChildren(typeof(Shield),true) as Shield;
        _animationController = gameObject.GetComponentInChildren(typeof(AnimationController),true) as AnimationController;
    }

    void Update()
    {
        if (Input.GetButtonDown("Block"))
        {
            _collider2D.enabled = false; 
           // _animationController.ShieldAnim(true);
            _shield.ShieldUp();
           
        }else if (Input.GetButtonUp("Block"))
        {
            _collider2D.enabled = true;
            _animationController.ShieldAnim(false);
            _shield.ShieldDown();
        }

    }
        
}
