using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private Collider2D _collider2D;
    public bool canParry = false,madeIt;
    public bool activeAnim;
    private int test =0;
    private AnimationController _animationController;
    public TimeManager timeManager;

    // Start is called before the first frame update
    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
        _animationController = gameObject.GetComponentInParent(typeof(AnimationController),true) as AnimationController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShieldUp()
    {
        _animationController.ShieldAnim(true);
        _collider2D.enabled = true;
        StartCoroutine("Parrytime");

    }

    public void ShieldDown()
    {
        _collider2D.enabled = false;
        //_animationController.ShieldAnim(false);
    }

    public void Parry()
    {
        switch (canParry)
        {
            case true:
                //se for projétil reflete
                madeIt = true;
                // se for attack inimigo bullet time
                break;
            case false:
                //redução de dano tomado;
                madeIt = false;
                print("errou o tempo");
                break;
            default:
                break;
                
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
     
        if (other.CompareTag("Projectil"))
        {
            switch (madeIt)
            {
                case true:
                    _animationController.ShieldAnim(false);
                    _animationController.ParryAnim();
                    other.gameObject.GetComponentInParent<Projectil>().Reflect();
                    //timeManager.DoSlowMotion();
                    //_animationController.ShieldAnim(true);
                    //activeAnim = false;
                    break;
                case false:
                    //Infligir dano reduzido
                    other.gameObject.GetComponentInParent<Projectil>().Destruir();
                    break;
                default:
                    break;
            }
            
        }
    }

    public IEnumerator Parrytime()
    {
        canParry = true;
        yield return new WaitForSeconds(0.15f);
        canParry = false;
    }
}
