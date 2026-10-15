using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public Transform FirePoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shooting!");
            Shoot();
        }
    }

    void Shoot()
    {
        if (ProjectilePrefab == null)
        {
            Debug.LogError("Projectile Prefab is missing!");
            return;
        }

        if (FirePoint == null)
        {
            Debug.LogError("Fire Point is missing!");
            return;
        }

        GameObject projectile = Instantiate(
            ProjectilePrefab,
            FirePoint.position,
            FirePoint.rotation
        );

        Debug.Log("Projectile created: " + projectile.name);
    }
}