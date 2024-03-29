using UnityEngine;

public class EnemyShoot : ProjectileShoot
{
    private GameObject _target;
    private Vector3 _targetPosition;
    private float _timer = 5;
    private bool _shooting = false;

    private void Start()
    {
        GetTargetPosition();
    }

    private void Update()
    {
        DistanceToTarget();
    }

    protected override void Shoot() => Instantiate(_projectilePrefab, transform.position, transform.rotation);

    private void GetTargetPosition()
    {
        _target = GameObject.Find("Player");
        _targetPosition = _target.transform.position;
    }

    private void DistanceToTarget()
    {
        if (_targetPosition != null)
        {
            float distance = _targetPosition.magnitude;
            Timer(distance);
            if (_shooting)
                Shoot();
        }
    }

    private void Timer(float distance)
    {
        if (_timer >= 5 && distance <= 10)
        {
            _shooting = true;
            _timer -= Time.deltaTime;
        }      
        else if (_timer < 5 && _timer >= 0)
        {
            _shooting = false;
            _timer -= Time.deltaTime;
        }
        else if (_timer <= 0)
            _timer = 5;
    }
}
