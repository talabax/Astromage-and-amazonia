using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    int i = 0;
    GameObject player;
    // Start is called before the first frame update
    void Awake()
    {

        player = gameObject.transform.parent.gameObject; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            
            
          
               player.GetComponent<Movement>().SetGroundTrue();
            
            
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            
            player.GetComponent<Movement>().SetGroundFalse();

        }
    }











}
