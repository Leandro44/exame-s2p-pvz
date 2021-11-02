using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerButton : MonoBehaviour
{
    public int index;
    public SetTower setscr;
    public Button botao;

    private void Start()
    {
        botao.onClick = new Button.ButtonClickedEvent();
        botao.onClick.AddListener(() => OnClick());
        setscr = GameObject.Find("Main Camera").GetComponent<SetTower>();
    }


    public void OnClick()
    {
        setscr.selected = index;
    }

}
