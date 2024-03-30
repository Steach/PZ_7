using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _turnSpeed;

    [SerializeField] private GameObject _gameManagerGO;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = _gameManagerGO.GetComponent<GameManager>();
    }

    void Update()
    {
        if (!GetGameOver())
            Move();
    }

    private void Move()
    {
        CheckMoveSpeed();
        
        float currentX = transform.position.x;
        float currentY = transform.position.y;
        float currentZ = transform.position.z;


        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * _moveSpeed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * _moveSpeed);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * _moveSpeed);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * _moveSpeed);
        if (Input.GetKey(KeyCode.Q))
        {
            Quaternion rotation = transform.rotation;
            rotation *= Quaternion.Euler(0, -_turnSpeed, 0);
            transform.rotation = rotation;
        }
        if (Input.GetKey(KeyCode.E))
        {
            Quaternion rotation = transform.rotation;
            rotation *= Quaternion.Euler(0, _turnSpeed, 0);
            transform.rotation = rotation;
        }
    }

    private void CheckMoveSpeed()
    {
        switch (_moveSpeed)
        {
            case < 0:
                _moveSpeed = 0.1f;
                break;
            case > 1:
                _moveSpeed = 1.0f;
                break;
        }
    }

    private bool GetGameOver()
    {
        return _gameManager.GameOver;
    }
}
