using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShootRaycast : MonoBehaviour
{
    [SerializeField] Transform shootPoint;
    [SerializeField] GameObject shootPointPrefabs;
    [SerializeField] GameObject hitPointPrefabs;
    
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
        Debug.DrawRay(shootPoint.position, transform.forward * 30f, Color.purple);

        RaycastHit hit;
        // If Hit obj.
        if (Physics.Raycast(shootPoint.position, transform.forward, out hit, 100f))
        {
            Debug.DrawRay(shootPoint.position, transform.forward * hit.distance, Color.softBlue);
            Debug.Log("Ray hits: " + hit.collider.name);

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(shootPointPrefabs, shootPoint.position, Quaternion.identity);
                Instantiate(hitPointPrefabs, hit.point, Quaternion.identity);

                if (hit.collider.name == "Enemy")
                {
                    HP Enemy = hit.collider.GetComponent<HP>();
                    if (Enemy != null)
                    {
                        Enemy.TakeDamage();
                    }
                }

                if (hit.collider.name == "obstacle")
                {
                    RotateEnemy obstacle = hit.collider.GetComponent<RotateEnemy>();
                    if (obstacle != null)
                    {
                        obstacle.Spining();
                    }
                }
            }
        }
    }
}

