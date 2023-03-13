using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    [SerializeField] GameObject skull;

    [SerializeField] Transform spawnPoint1;
    [SerializeField] Transform spawnPoint2;
    [SerializeField] Transform spawnPoint3;
    GameObject player;

    int i = 0;
    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnSkull(Transform spawnP)
    {
    
        GameObject skull1 = Instantiate(skull, spawnP.position, Quaternion.identity) as GameObject;
        yield return new WaitForSecondsRealtime(Random.Range(5f,10f));

        StartCoroutine(SpawnSkull(spawnP));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(SpawnSkull(spawnPoint1));
            StartCoroutine(SpawnSkull(spawnPoint2));
            StartCoroutine(SpawnSkull(spawnPoint3));

        }


    }


}
