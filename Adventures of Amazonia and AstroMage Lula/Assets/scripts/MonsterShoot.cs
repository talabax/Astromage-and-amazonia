using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterShoot : MonoBehaviour
{
    GameObject player;
    Transform playerTransform;
    float distance;
    bool isLoaded = true;

    [SerializeField] GameObject projectile;
    [SerializeField] GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Boot>() == false)
        {
            ShootPlayer();
        }
    }


    void ShootPlayer()
    {

        // transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, 2 * Time.deltaTime);
        if (player != null)
        {
            distance = gameObject.transform.position.x - playerTransform.position.x;

            if (playerTransform.position.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (Mathf.Abs(distance) <= 10)
            {
                FireProjectile();
            }
        }

       

    }

    public void FireProjectile()
    {
      
            GameObject bootShot = Instantiate(projectile, spawnPoint.transform.position, Quaternion.identity);
            //Debug.Log("fire");
            Destroy(bootShot, 2.5f);
        

    }


    


}
