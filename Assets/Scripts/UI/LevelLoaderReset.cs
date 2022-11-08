using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderReset : MonoBehaviour
{
    public string sceneNameToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            int health = GameObject.Find("Player").GetComponent<PlayerHealth>().health;
            PlayerPrefs.SetInt("Health", 5);
            int score = GameObject.Find("Player").GetComponent<PlayerScore>().score;
            PlayerPrefs.SetInt("Score", 0);
            SceneManager.LoadScene(sceneNameToLoad);
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
