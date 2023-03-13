using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullMove : MonoBehaviour
{
    GameObject player;
    Transform playerTransform;
    Vector3 distance;
    // Start is called before the first frame update

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
    }


    void MoveToPlayer()
    {
      


        if (player != null)
        {
            distance = gameObject.transform.position - playerTransform.position;
            

            if (playerTransform.position.x < gameObject.transform.position.x)
            {
               // Debug.Log("to the left");

                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (playerTransform.position.x > gameObject.transform.position.x)
            {
               // Debug.Log("to the right");

                transform.localScale = new Vector3(1, 1, 1);
            }

            //Debug.Log(Mathf.Abs(distance));
            if (Mathf.Abs(distance.magnitude) <= 20 && Mathf.Abs(distance.magnitude) >= .8)
            {
                //Debug.Log("in range");
                transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, 2 * Time.deltaTime);
            }
        }



    }








}
