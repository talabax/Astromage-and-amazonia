using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffects : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void DamageWarning()
    {
        animator.Play("blink");
        animator.Play("blink", -1, 0);


    }




}
