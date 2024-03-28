using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveToEnemy : MonoBehaviour
{
    
    [SerializeField] private float _moveSpeed;
    
    private GameObject _playerGO;
    private Player _player;

    private GameObject _dragonGO;
    private Dragon _dragon;

    private void Awake()
    {
        FindPlayerAndDragon();
    }
    private void Update()
    {
        Move();
    }

    private void Move() => transform.Translate(Vector3.forward * _moveSpeed);

    private void FindPlayerAndDragon()
    {
        _playerGO = GameObject.Find("Player");
        if (_playerGO != null)
            _player = _playerGO.GetComponent<Player>();

        _dragonGO = GameObject.Find("Dragon");
        if (_dragonGO != null)
                _dragon = _dragonGO.GetComponent<Dragon>();
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
