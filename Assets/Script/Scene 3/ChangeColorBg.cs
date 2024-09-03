using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorBg : MonoBehaviour
{
    // Define the new background color using RGBA values
    private Color newBackgroundColor = new Color(243f / 255f, 103f / 255f, 79f / 255f);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Get the main camera
            Camera mainCamera = Camera.main;

            if (mainCamera != null)
            {
                // Change the background color
                mainCamera.backgroundColor = newBackgroundColor;
            }
            else
            {
                Debug.LogWarning("Main Camera not found.");
            }
        }
    }
}
