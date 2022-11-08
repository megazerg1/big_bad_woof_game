using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectBehaviour : MonoBehaviour
{

    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();    }
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))

        animator.SetTrigger("Collect");
        Destroy(animator.gameObject, 0.5f);

    }
}