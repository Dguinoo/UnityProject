using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGoal : MonoBehaviour
{
    private CameraFollow cameraFollow;
    private Controller playerController; // Add this line to store reference to the player's Controller
    [SerializeField] GameObject goal;
    [SerializeField] GameObject obstacle;

    private void Start()
    {
        // Get the CameraFollow component from the Camera
        cameraFollow = Camera.main.GetComponent<CameraFollow>();

        // Find the player object and get the Controller component
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerController = player.GetComponent<Controller>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // When player collides with platform, call CameraFollowZero to set smoothTime to 0, change the limit of Y axis x 
        if (collision.CompareTag("Player") && this.CompareTag("FakeFinishLine"))
        {
            cameraFollow.CameraFollowZero(0f);

            // Call SpeedToZero on the playerController instance
            if (playerController != null)
            {
                playerController.SpeedToZero(0);
            }

           goal.SetActive(true);

           obstacle.SetActive(false);

        }
    }
}
