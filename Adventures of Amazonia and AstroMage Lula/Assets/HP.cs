using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HP : MonoBehaviour
{

    PlayerStats stats;
    [SerializeField] TMP_Text hp;
    [SerializeField] TMP_Text mana;

    // Start is called before the first frame update
    void Start()
    {
        stats = FindObjectOfType<PlayerStats>();
        //Debug.Log(stats);

    }

    // Update is called once per frame
    void Update()
    {
        hp.text = stats.PlayerLife().ToString() + " HP";
        mana.text = stats.PlayerMana().ToString() + " MP";

    }
}
