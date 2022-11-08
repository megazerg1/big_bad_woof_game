using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public AudioClip CoinPickup;
    public int score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().clip = CoinPickup;
            GetComponent<AudioSource>().Play();
            collision.gameObject.GetComponent<PlayerScore>().Collect(score);
        }
    }
}

