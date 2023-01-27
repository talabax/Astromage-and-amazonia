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
       // animator.Play("blink");
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    animator.Play("blink");
        //    animator.Play("blink",-1,0);

        //}
    }


    public void DamageWarning()
    {
        animator.Play("blink");
        animator.Play("blink", -1, 0);


    }




}
