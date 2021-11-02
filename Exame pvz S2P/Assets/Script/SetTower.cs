using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTower : MonoBehaviour
{
    public GameObject tiles;
    public GameObject[] towers;
    public int selected;
    public float[] prices;
    private Money mscr;

    // Start is called before the first frame update
    void Start()
    {
        mscr = GameObject.Find("GameLogic").GetComponent<Money>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 20))
        {
            if(hit.transform.tag == "Tile")
            {
                tiles = hit.transform.gameObject;
            }
            else
            {
                tiles = null;
            }
        }
        if(Input.GetMouseButtonDown(0) && tiles != null)
        {
            TileTaken tscr = tiles.GetComponent<TileTaken>();
            if(!tscr.isTaken && mscr.money >= prices[selected])
            {
                mscr.money -= prices[selected];
                Vector3 pos = new Vector3(tiles.transform.position.x,0.95f,tiles.transform.position.z);
                tscr.Tower = (GameObject)Instantiate(towers[selected], pos, Quaternion.identity);
                tscr.isTaken = true;
            }
        }
    }
}
