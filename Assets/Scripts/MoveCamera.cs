using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform trajeto;
    public float positionY;
    void Start()
    {
     trajeto = GameObject.FindGameObjectWithTag("Player").transform;
       
    }
    // Update is called once per frame
    void Update()
    {
       if(GameObject.FindGameObjectWithTag("Player") == null)
       {
            transform.position = new Vector3(0, positionY, -1f);
       }
       
       else if(this.gameObject.tag == "BG")
       {

            transform.position = new Vector3(trajeto.position.x, positionY, 12f);
       }

       else
       {
            transform.position = new Vector3(trajeto.position.x, positionY, -1f);
       }
    }
}
