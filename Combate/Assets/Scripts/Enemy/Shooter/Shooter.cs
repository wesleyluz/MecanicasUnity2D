using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private Projectil projectil;
    public Projectil projectilPrefab;
    private float time = 0;
    public float projectilDelay;
    public bool canshoot;
        
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canshoot)
        {
            if (time < Time.time)
            {
                projectil = Instantiate(projectilPrefab,transform.position,transform.rotation) as Projectil;
                time = Time.time + projectilDelay;
            }
        }
    }
}
