using UnityEngine;

public class PlayerTouchController : MonoBehaviour
{
    [Header("Random Force Modifiers")]
    [SerializeField] private float randomForceMinimum;
    [SerializeField] private float randomForceMaximum;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootRay();
        }
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
            TouchableObject touchable = hit.collider.gameObject.GetComponent<TouchableObject>();
            if (touchable != null) 
            {
                touchable.TouchTheObject(GenerateRandomForce(), GenerateRandomDirection());
            }
        }
        else
        {
            Debug.Log("No hit detected within 6.66 units.");
        }
    }

    private Vector3 GenerateRandomDirection()
    {
        // Generate random values for x, y, and z components
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        float z = Random.Range(-1f, 1f);

        // Create a new Vector3 with the random components
        Vector3 randomDirection = new Vector3(x, y, z);

        // Normalize to make it a unit vector (pure direction)
        return randomDirection.normalized;
    }

    private float GenerateRandomForce()
    {
        return Random.Range(randomForceMinimum, randomForceMaximum);
    }

}
