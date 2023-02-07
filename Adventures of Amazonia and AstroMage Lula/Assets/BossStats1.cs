using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats1 : MonoBehaviour
{
    int monsterHealth = 100;
    int monsterCurrentHealth;



    // Start is called before the first frame update
    void Start()
    {
        monsterCurrentHealth = monsterHealth;  
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("hello");
    }

    


    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collision entered");
        if(collision.gameObject.tag == "star")
        {
            GameObject weaponDamage = collision.gameObject;
            ProjectileDirections weaponDam = weaponDamage.GetComponent<ProjectileDirections>();
            Debug.Log(weaponDam.Damage());
            TakeDamage(weaponDam.Damage());
            Destroy(collision.gameObject);
        }

    }

    


    void TakeDamage(int dam)
    {
        monsterCurrentHealth = monsterCurrentHealth - dam;
        if(monsterCurrentHealth <= 0)
        {
            Destroy(gameObject);

        }
    }




    





}
