using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string sceneNameToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            int health = GameObject.Find("Player").GetComponent<PlayerHealth>().health;
            PlayerPrefs.SetInt("Health", health);
            int score = GameObject.Find("Player").GetComponent<PlayerScore>().score;
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
