using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float cooldown;
    private float cd;
    public bool hasenemy;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        cd = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (cd > 0)
        {
            cd -= Time.deltaTime;
        }
        else
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.right, out hit, 15))
            {
                if (hit.transform.tag == "Enemy")
                {
                    if (cd <= 0)
                    {
                        cd = cooldown;
                        Instantiate(projectile, transform.position, Quaternion.identity);
                    }
                    hasenemy = true;
                }
                else if (hit.transform.tag == "Tower")
                {
                    Tower scr = hit.transform.gameObject.GetComponent<Tower>();
                    if (scr.hasenemy)
                    {
                        hasenemy = true;
                    }
                    else
                    {
                        hasenemy = false;
                    }
                }
                else
                {
                    hasenemy = false;
                }
            }
            else
            {
                hasenemy = false;
            }
            if(hasenemy)
            {
                if (cd <= 0)
                {
                    cd = cooldown;
                    Instantiate(projectile, transform.position, Quaternion.identity);
                }
            }
            
        }
    }
}
