using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] protected float _moveSpeed;

    protected GameObject _playerGO;
    protected Player _player;

    protected GameObject _dragonGO;
    protected Dragon _dragon;

    protected void Move() => transform.Translate(Vector3.forward * _moveSpeed);
    protected void FindPlayerAndDragon()
    {
        _playerGO = GameObject.Find("Player");
        if (_playerGO != null)
            _player = _playerGO.GetComponent<Player>();

        _dragonGO = GameObject.Find("Dragon");
        if (_dragonGO != null)
            _dragon = _dragonGO.GetComponent<Dragon>();
    }
}
