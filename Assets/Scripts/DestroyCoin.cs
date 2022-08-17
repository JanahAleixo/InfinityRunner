using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    private float positionPlayer;
    private int maxGas = 10;
    
    
    void Start()
    {
    
    }


    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            positionPlayer = GameObject.FindGameObjectWithTag("Player").transform.position.x;
                if(transform.position.x < positionPlayer-20f)
                {
                     Destroy(this.gameObject);
                }
        }
    }
    
    void OnTriggerEnter2D(Collider2D colisorCoin) 
    {    
        if(colisorCoin.gameObject.tag == ("Player"))
        {
            if(GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().gasoline < maxGas)
            {
                 GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().gasoline++;
            }
    
            Destroy(this.gameObject);
        } 
    }
}
