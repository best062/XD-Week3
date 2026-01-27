using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform Shooter;
    public float shootForce;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }

    void shoot()
    {
        GameObject Bullet = Instantiate(this.bullet, Shooter.position, transform.rotation);

        Rigidbody rigidbody = Bullet.GetComponent<Rigidbody>();
        rigidbody.AddForce(Shooter.forward * shootForce * (float)ForceMode.Impulse);
    }
}
