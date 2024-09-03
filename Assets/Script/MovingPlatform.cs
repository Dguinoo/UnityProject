using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform posA, posB; // Start and end points
    public float speed;          // Speed of platform movement
    private Vector3 targetPos;   // Current target position for the platform

    // Start is called before the first frame update
    void Start()
    {
        targetPos = posB.position; // Initialize target to position B
    }

    // Update is called once per frame
    void Update()
    {
        // Check distance to posA, switch target to posB if close
        if (Vector2.Distance(transform.position, posA.position) < 0.5f) 
        {
            targetPos = posB.position;
        }

        // Check distance to posB, switch target to posA if close
        if (Vector2.Distance(transform.position, posB.position) < 0.5f)
        {
            targetPos = posA.position;
        }

        // Move the platform towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // When player collides with platform, make the player a child of the platform or the player will stay on the platform when the platform moves.
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player parented to platform");
            collision.transform.parent = this.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // When player exits platform, remove parent-child relationship
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }

    private void OnDrawGizmos()
    {
        // Visualize the platform's path in the editor
        if (posA != null && posB != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, posA.position);
            Gizmos.DrawLine(transform.position, posB.position);
        }
    }
}
