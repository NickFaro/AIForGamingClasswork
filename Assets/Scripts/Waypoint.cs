using UnityEngine;

public class Waypoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Agent"))
        {
            // Logic for when the agent reaches the waypoint
            Debug.Log("Waypoint Reached!");
            // You can add more actions here, such as updating the score or triggering an event
        }
    }
}
