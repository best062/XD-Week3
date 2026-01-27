using System;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    [Header("Power")]
    public float forcePower;
    public float jumpForce;
    public Rigidbody rb;
    public Vector3 direction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(direction * forcePower * (float)ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
