using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHPHandler : MonoBehaviour
{
    int monsterHealth = 1000;
    int monsterCurrentHealth;
    GameObject parentGameObject;
    // Start is called before the first frame update
    void Start()
    {
        monsterCurrentHealth = monsterHealth;
        parentGameObject = GameObject.FindGameObjectWithTag("boss1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collision entered");
        if (collision.gameObject.tag == "star")
        {
            Debug.Log("star entered");
            GameObject weaponDamage = collision.gameObject;
            ProjectileDirections weaponDam = weaponDamage.GetComponent<ProjectileDirections>();
            //Debug.Log(weaponDam.Damage());
            TakeDamage(weaponDam.Damage());
            Destroy(collision.gameObject);
            
        }

    }


    void TakeDamage(int dam)
    {
        monsterCurrentHealth = monsterCurrentHealth - dam;
        if (monsterCurrentHealth <= 0)
        {
            Destroy(parentGameObject);
            Destroy(gameObject);

        }
    }




}
