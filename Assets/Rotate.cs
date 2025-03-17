using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 angularV, torque;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.angularVelocity = Vector3.zero;
        }
            
    }
}