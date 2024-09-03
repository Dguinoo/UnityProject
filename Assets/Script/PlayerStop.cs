using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStop : MonoBehaviour
{
    private Controller playerController;
    public int changeSpeed;

    private void Start()
    {
        // Find the player object and get the Controller component
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerController = player.GetComponent<Controller>();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            if (playerController != null)
            {
                playerController.SpeedToZero(changeSpeed);
            }


        }
    }
}
