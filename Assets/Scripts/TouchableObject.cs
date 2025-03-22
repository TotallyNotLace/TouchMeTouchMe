using System;
using UnityEngine;

public class TouchableObject : MonoBehaviour
{

    [SerializeField] private bool hasBeenTouched = false;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Collider coll;

    private Vector3 startPosition;
    private Quaternion startRotation;

    void Awake()
    {
        if(rb == null | coll == null)
        {
            Debug.Log($"{gameObject.name} at location " +
            $"{transform.position.x},{transform.position.y},{transform.position.z} " +
            "is missing some componets. Please check it out." );
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        startRotation = transform.rotation;
        startPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position.y < GlobalRefs.deadZone)
        {
            transform.position = startPosition;
            transform.rotation = startRotation;

            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    public void TouchTheObject(float force, Vector3 direction)
    {
        hasBeenTouched = true;
        rb.AddForce(direction.normalized * force, ForceMode.Impulse);

        rb.AddTorque(direction.normalized * force, ForceMode.Impulse);
    }

    public bool IsObjectTouched()
    {
        return hasBeenTouched;
    }
}
