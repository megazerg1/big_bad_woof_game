using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage;
    public int playerdamage;
    public int enemyhealth;
    public float knockbackForce = 800;
    public GameObject bloodEffect;
    private Animator animator;
    public float delay = 0f;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

        void Update()
    {

        if (enemyhealth <= 0)
        {
            animator.SetTrigger("slimedeath");
            Destroy(gameObject, 2f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 vector = new Vector2(0, knockbackForce);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(vector);

            collision.gameObject.GetComponent<PlayerHealth>().Damage(damage);
        }
    }
    public void TakeDamage(int damage)
    {
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        enemyhealth -= playerdamage;

    }
}