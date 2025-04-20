// ARPhysicsInteraction.cs
using UnityEngine;
public class ARPhysicsInteraction : MonoBehaviour
{
    [SerializeField] private float forceMultiplier = 10f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    Vector3 forceDirection = (hit.point - Camera.main.transform.position).normalized;
                    rb.AddForce(forceDirection * forceMultiplier, ForceMode.Impulse);
                }
            }
        }
    }
}