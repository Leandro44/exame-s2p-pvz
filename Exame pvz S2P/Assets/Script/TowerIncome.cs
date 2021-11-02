using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerIncome : MonoBehaviour
{
    public float cooldown;
    private float cd;
    public Tower enemyscr;
    public float income;
    public Money mscr;
    private Tower tscr;

    // Start is called before the first frame update
    void Start()
    {
        cd = cooldown;
        mscr = GameObject.Find("GameLogic").GetComponent<Money>();
        tscr = gameObject.GetComponent<Tower>();
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
            cd = cooldown;
            mscr.money += income;
        }    
     }
}
