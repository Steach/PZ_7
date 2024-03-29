using UnityEngine;

public class PlayerProjectile : Projectile
{
    private void Awake()
    {
        FindPlayerAndDragon();
    }
    private void Update()
    {
        Move();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (_dragon != null && _player != null)
                _dragon.TakeDamage(_player.Damage);
            GameObject.Destroy(gameObject);
        }
    }
}
