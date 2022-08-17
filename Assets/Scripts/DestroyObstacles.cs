using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    private float positionPlayer;
    
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
}
