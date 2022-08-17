using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private Rigidbody2D rig;
    public GameObject player;
    public int gasoline = 10;
    private float timer = 0f;
    public GameObject popupActive;
    public GameObject sliderActive;
    public GameObject menu;
    public GameObject menuDois;
    public GameObject slider;
  

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
      rig.velocity = new Vector2(speed, rig.velocity.y);
      timer += Time.deltaTime;

      if((Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")) && gasoline > 0)
      {
          rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

      }  

      if(timer > 2.5f)
      {
        gasoline--;
        timer = 0f;

      }
    }

    void OnCollisionEnter2D(Collision2D colisor) 
    {    
        if(colisor.gameObject.layer == 8 && gasoline > 0)
        {
            Destroy(player);
            popupActive.GetComponent<ButtonController>().MostrarPopUp(menu);
            sliderActive.GetComponent<ButtonController>().DesligarPopUp(slider);
        }
        else if(colisor.gameObject.layer == 8 && gasoline == 0)
         {
            Destroy(player);
            popupActive.GetComponent<ButtonController>().MostrarPopUp(menuDois);
            sliderActive.GetComponent<ButtonController>().DesligarPopUp(slider);
        }
    }

    

}