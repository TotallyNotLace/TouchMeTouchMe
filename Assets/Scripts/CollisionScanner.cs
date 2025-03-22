using UnityEngine;

public class CollisionScanner : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"{gameObject.name} just collidered with {collision.gameObject.name}");
    }
}
