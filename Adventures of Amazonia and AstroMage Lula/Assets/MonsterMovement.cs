using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    GameObject player;
    Transform playerTransform;
    float distance;
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

        // transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, 2 * Time.deltaTime);
        if (player != null)
        {
            distance = gameObject.transform.position.x - playerTransform.position.x;
            
            if(playerTransform.position.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            //Debug.Log(Mathf.Abs(distance));
            if (Mathf.Abs(distance) <= 10 && Mathf.Abs(distance) >= .8 )
            {
                //Debug.Log("in range");
                transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, 2 * Time.deltaTime);
            }
        }


    }








}
