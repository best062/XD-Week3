using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] int damage = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        health -= damage;
        Debug.Log($"{name} took {damage} damage!");

        if (health <= 0)
        {
            Destroy(this.gameObject, 1f);
            Debug.Log($"{name} death!");
        }
    }
}
