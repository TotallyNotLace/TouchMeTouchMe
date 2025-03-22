using UnityEngine;

public class PlayerTouchController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootRay();
    }

    void ShootRay()
    {
        // Get the camera's transform
        Transform cameraTransform = Camera.main.transform;

        // Ray starting point and direction
        Vector3 rayOrigin = cameraTransform.position;
        Vector3 rayDirection = cameraTransform.forward;

        // Length of the ray
        float rayLength = 6.66f;

        // Draw the debug ray (visible in the Scene view)
        Debug.DrawRay(rayOrigin, rayDirection * rayLength, Color.green);

        // Perform the raycast
        if (Physics.Raycast(rayOrigin, rayDirection, out RaycastHit hit, rayLength))
        {
            Debug.Log("Hit: " + hit.collider.name);
            //hit.collider.gameObject.GetComponent<>
        }
        else
        {
            Debug.Log("No hit detected within 6.66 units.");
        }
    }
}
