using Unity.VisualScripting;
using UnityEngine;

public class RotateEnemy : MonoBehaviour
{
    [SerializeField] float Torque;

    private Rigidbody rb;
    
    public void Spining()
    {
        Vector3 RandomRotation = Random.insideUnitSphere;
        rb.AddTorque(RandomRotation * Torque , ForceMode.VelocityChange);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
