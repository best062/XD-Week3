using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Prompt : บอกวิธีการเขียนมา เหมือนผมเป็นนักเรียน ถามตอบ เพราะผมอยากเขียนเป็น + รูปโจทย์
    [SerializeField] Transform shootPoint;
    [SerializeField] Color CurrentColor = Color.purple;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        Debug.DrawRay(shootPoint.position, transform.forward * 30f, CurrentColor);
        Debug.DrawRay(shootPoint.position, transform.right * 30f, CurrentColor);
        Debug.DrawRay(shootPoint.position, transform.up * 30f, CurrentColor);
        RaycastHit hit;
        
        // If Hit obj.
        if (Physics.Raycast(shootPoint.position, transform.forward, out hit, 100f))
        {
            CurrentColor = Color.softBlue;
            Debug.DrawRay(shootPoint.position, transform.forward * 30f, CurrentColor);
            Debug.DrawRay(shootPoint.position, transform.right * 30f, CurrentColor);
            Debug.DrawRay(shootPoint.position, transform.up * 30f, CurrentColor);
            Debug.Log("Ray hits: " + hit.collider.name);
            if (hit.collider.CompareTag("Star"))
            {
                Renderer starColor = hit.collider.GetComponent<Renderer>();
                if (starColor != null)
                {
                    starColor.material.color = Color.sandyBrown;
                }
                Rigidbody starRb = hit.collider.GetComponent<Rigidbody>();
                if (starRb != null)
                {
                    starRb.useGravity = true;
                }
            }
        }
    }
}
