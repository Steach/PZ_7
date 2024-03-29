using UnityEngine;

public class PlayerShoot : ProjectileShoot
{
    private void Update()
    {
        Shoot();
    }

    protected override void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(_projectilePrefab, transform.position, transform.rotation);
        }
    }
}
