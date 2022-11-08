using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    Animator animator;


    void Start()
    {

        animator = GetComponent<Animator>();

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LightControl("TriggerOn");

        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LightControl("TriggerOff");

        }

    }

    void LightControl(string directions)
    {
        animator.SetTrigger(directions);

    }

}
