using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public int numOut;
    public GameObject[] Enemies;
    public float inipause;
    public float cooldown;
    private float cd;

    // Start is called before the first frame update
    void Start()
    {
        cd = cooldown*inipause;
    }

    // Update is called once per frame
    void Update()
    {
        if(cd > 0)
        {
            cd -= Time.deltaTime;
        }
        else
        {
            cd = cooldown;
            Vector3 pos = new Vector3(4.5f, 1f, Random.Range(-2, 3));
            int index = Random.Range(0, Enemies.Length);
            Instantiate(Enemies[index], pos, Quaternion.identity);
            numOut++;
        }
    }

    public void resetcd()
    {
        cd = cooldown;
    }
}
