using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    public float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    [Header("Axis Limitation")]
    public Vector2 xLimit; // limitation of the camera not to go beyond certain points
    public Vector2 yLimit;

    // Update is called once per frame
    void Update()
    {
        // Calculate the target position with offset
        Vector3 targetPosition = target.position + offset;

        // Clamp the target position to stay within the specified limits
        targetPosition = new Vector3(
            Mathf.Clamp(targetPosition.x, xLimit.x, xLimit.y),
            Mathf.Clamp(targetPosition.y, yLimit.x, yLimit.y),
            targetPosition.z // Keep the z-axis unchanged, as it's already set with the offset
        );

        // Smoothly move the camera towards the clamped target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

    }
    public void CameraFollowZero(float movement)
    {
        smoothTime = movement;
    }







}
