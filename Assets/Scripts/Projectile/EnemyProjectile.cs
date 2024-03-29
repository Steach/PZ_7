using Unity.VisualScripting;
using UnityEngine;

public class EnemyProjectile : Projectile
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
        Debug.Log("PlayerCollision");
        if (collision.gameObject.tag == "Player")
        {
            if (_dragon != null && _player != null)
                _player.TakeDamage(_dragon.Damage);
            GameObject.Destroy(gameObject);    
        }      
    }
}
