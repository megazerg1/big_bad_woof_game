using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score;

    void Start()
    {
        score = 0;

        if (PlayerPrefs.HasKey("Score"))
        {
            score = PlayerPrefs.GetInt("Score");
        }

        UpdateHUD();
    }


        public void Collect(int collect)
    {
        score += collect;

        if(score <= 0)
        {
            score = 0;

            //smierc
        }
        UpdateHUD();
    }



    public void UpdateHUD()
    {
        /*        GameObject.Find("Canvas HUD").GetComponent<HUDManager>().SetPlayersHealth(health);*/
        GameObject canvas = GameObject.Find("Canvas - HUD");
        HUDManager hudManager = canvas.GetComponent<HUDManager>();
        hudManager.SetPlayersScore(score);
    }

}