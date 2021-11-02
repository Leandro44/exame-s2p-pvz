using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool isTower;
    private Health hscr;
    private Money mscr;
    private Enemy wscr;

    private void Start()
    {
        hscr = gameObject.GetComponent<Health>();
        mscr = GameObject.Find("GameLogic").GetComponent<Money>();
        wscr = gameObject.GetComponent<Enemy>();
    }

    private void Update()
    {
        if(hscr.health<=0)
        {
            if(isTower)
            {
                Destroy(gameObject);

            }
            else 
            {
                mscr.money += wscr.worth;
                Destroy(gameObject);
            } 
        }
    }
}
