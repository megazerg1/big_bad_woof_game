using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        health = 5;

        if (PlayerPrefs.HasKey("Health"))
        {
            health = PlayerPrefs.GetInt("Health");
        }

        UpdateHUD();
    }

    public void IncreaseHealth(int amount)
    {
        health += amount;
        UpdateHUD();
    }

    public void Damage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            health = 0;
            StartCoroutine(Die());
            //smierc
        }
        UpdateHUD();
    }
    public void UpdateHUD()
    {
/*        GameObject.Find("Canvas HUD").GetComponent<HUDManager>().SetPlayersHealth(health);*/
        GameObject canvas = GameObject.Find("Canvas - HUD");
        HUDManager hudManager = canvas.GetComponent<HUDManager>();
        hudManager.SetPlayersHealth(health);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Finish"))
            animator.SetTrigger("die");
    }
    public IEnumerator Die()
    {
        animator.SetTrigger("die");
        yield return new WaitForSeconds(4);
        PlayerPrefs.SetInt("Health", 5);
        SceneManager.LoadScene("GameOver");
    }

}