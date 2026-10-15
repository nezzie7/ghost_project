using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 15f;
    public float Lifetime = 3f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.linearVelocity = transform.forward * Speed;
        Destroy(gameObject, Lifetime);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Projectile hit: " + collision.gameObject.name);
        Destroy(gameObject);
    }
}