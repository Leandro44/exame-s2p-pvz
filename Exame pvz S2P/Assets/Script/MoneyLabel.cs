using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyLabel : MonoBehaviour
{
    public Money mscr;
    public Text moneytext;

    public void Start()
    {
        mscr = GameObject.Find("GameLogic").GetComponent<Money>();
    }

    public void Update()
    {
        moneytext.text = "Money: " + mscr.money.ToString();
    }
}
