﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Text playersHealth;

    public void SetPlayersHealth(int health)
    {
        playersHealth.text = $"Health: {health}";
    }

    public Text playersScore;

    public void SetPlayersScore(int score)
    {
        playersScore.text = $"Score: {score}";
    }

}
