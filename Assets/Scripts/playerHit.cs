using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHit : MonoBehaviour
{
    public int damageToGive;
    private PlayerHp player;

    void Start()
    {
        player = FindObjectOfType<PlayerHp>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("breakable") && other.GetComponent<SpriteRenderer>().color == Color.white)
        {
            other.GetComponent<pot>().Smash();
            player.HurtPlayer(1);
        }

        if (other.CompareTag("Finish"))
        {
            other.GetComponent<pot>().Correct();
        } 
    }
}
