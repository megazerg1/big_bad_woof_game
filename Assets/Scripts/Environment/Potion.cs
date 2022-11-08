using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Potion : MonoBehaviour
{
    public int healthAmount;
    private Animator animator;
    public float delay = 0f;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().IncreaseHealth(healthAmount);
            animator.SetTrigger("drink");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
        }
    }
}