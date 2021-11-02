using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float vel;
    public bool canmove;
    public float worth;
    public Money mscr;
    public Health hscr;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(canmove)
        { 
            transform.Translate(Vector3.left * Time.deltaTime * vel);
        }
    }
}
