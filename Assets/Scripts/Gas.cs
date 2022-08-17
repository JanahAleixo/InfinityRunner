using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gas : MonoBehaviour
{   
    public Slider gas;
    private GameObject player;
    
    void Start()
    {
        gas = GetComponent<Slider>(); 
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
       if(player != null)
       {
            gas.value = player.GetComponent<Player>().gasoline;
       }
    }
}
