using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float velocidade;
    public float dano;
    public Vector3 posInicial;
    public GameObject particula;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        if(Vector3.Distance(transform.position,posInicial) > 15)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Enemy")
        {
            col.GetComponent<Health>().health -= dano;
            //particula
            Destroy(gameObject);
        }
    }
}
