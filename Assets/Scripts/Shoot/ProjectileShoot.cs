using UnityEngine;

public abstract class ProjectileShoot : MonoBehaviour
{
    [SerializeField] protected GameObject _projectilePrefab;

    protected abstract void Shoot();
}
