using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopedFloor : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }




    GameObject player1;

    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player");
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {


            player.GetComponent<Movement>().SetGroundTrue();
            //player.GetComponent<Movement>().SetSlopeTrue();

        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {

            player.GetComponent<Movement>().SetGroundFalse();
            //player.GetComponent<Movement>().SetSlopeFalse();


        }
    }



}
