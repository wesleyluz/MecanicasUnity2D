using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Projectil : MonoBehaviour
{
    private Rigidbody2D rb;
    public Collider2D enemyBox;// Acerta o inimigo
    public Collider2D PlayBox;// Acerta o player
    public Vector2 direction = new Vector2(-10,0);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = direction;
        Destroy(this.gameObject,30f);
    }

    void DoDamage()
    {
        print("atacou");
        Destruir();
    }

    public void Reflect()
    {
        PlayBox.enabled = false;
        enemyBox.enabled = true;
        direction = new Vector2(10, 0);
        Destroy(this.gameObject, 15f);
    }
    public void Destruir()
    {
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.tag);
        switch (other.tag)
        {
            case "Player":
                DoDamage();
                break;
            case "Shield":
                other.gameObject.SendMessage("Parry");
                break;
            default:
                break;
        }
    }

    
}
