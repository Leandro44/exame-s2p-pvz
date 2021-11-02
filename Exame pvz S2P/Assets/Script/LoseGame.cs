using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    public bool lost;
    private Money mscr;
    private float initmoney;
    private WaveManager wavescr;

    // Start is called before the first frame update
    void Start()
    {
        mscr = gameObject.GetComponent<Money>();
        wavescr = gameObject.GetComponent<WaveManager>();
        initmoney = mscr.money;
    }

    // Update is called once per frame
    void Update()
    {
        if(lost)
        {
            lost = false;
            wavescr.numOut = 0;
            wavescr.resetcd();
            GameObject[] Towers = GameObject.FindGameObjectsWithTag("Tower");
            GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
            for(int i=0; i<Towers.Length;i++)
            {
                Destroy(Towers[i]);
            }
            for(int j=0; j<Enemies.Length;j++)
            {
                Destroy(Enemies[j]);
            }
            GameObject[] Tiles = GameObject.FindGameObjectsWithTag("Tile");
            for(int n=0; n<=Tiles.Length; n++)
            {
                TileTaken tscr = Tiles[n].GetComponent<TileTaken>();
                tscr.isTaken = false;
            }
            GameObject[] Projs = GameObject.FindGameObjectsWithTag("Projectile");
            for(int k=0; k<Projs.Length;k++)
            {
                Destroy(Projs[k]);
            }

            mscr.money = initmoney;
        }
    }
}
