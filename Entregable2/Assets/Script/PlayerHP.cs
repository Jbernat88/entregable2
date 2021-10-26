using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private bool isGameOver;
    private int playerHP = 150;
    public int damage = 60;

    private void Start()
    {
        playerHP = playerHP - damage;
    }

    void Update()
    {

        if (playerHP <= 0)
        {
            isGameOver = false;
            Debug.Log("Te has quedado sin vida... GAME OVER");
        }
        else if (playerHP < 30)
        {
            Debug.Log("¡¡¡Tienes poca vida!!!");
        }
        else if (playerHP >= 30)
        {
            Debug.Log("Vas bien de vida: tienes " + playerHP + " puntos de vida");
        }

        if (isGameOver = true)
        {
            Debug.Log("GAME OVER");
        }
    }
}

