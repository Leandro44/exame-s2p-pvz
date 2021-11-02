using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private Enemy movescr;
    public float damage;
    public float cooldown;
    private float cd;

    // Start is called before the first frame update
    void Start()
    {
        cd = cooldown;
        movescr = gameObject.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cd>0)
        {
            cd -= Time.deltaTime;
        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.left, out hit, 0.6f))
        {
            if (hit.transform.tag == "Tower")
            {
                if (cd <= 0)
                {
                    Health hscr = hit.transform.gameObject.GetComponent<Health>();
                    hscr.health -= damage;
                    cd = cooldown;
                }
                movescr.canmove = false;
            }
            else if(hit.transform.tag == "House")
            {
                GameObject.Find("GameLogic").GetComponent<LoseGame>().lost = true;
            }
            movescr.canmove = false;
        }
        else if(movescr.canmove == false)
        {
            movescr.canmove = true;
        }

    }
}
