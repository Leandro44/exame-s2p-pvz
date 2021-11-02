using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShield : MonoBehaviour
{
    public Enemy speedmult;
    public Health hscr;
    private float speed;
    private float health;

    // Start is called before the first frame update
    void Start()
    {
        speedmult = gameObject.GetComponent<Enemy>();
        hscr = gameObject.GetComponent<Health>();

        health = hscr.health;
        speed = speedmult.vel;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 50)
        {
            speed = speed * 2;
        }
    }
}
