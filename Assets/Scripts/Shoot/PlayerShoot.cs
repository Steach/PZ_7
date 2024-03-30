using UnityEngine;

public class PlayerShoot : ProjectileShoot
{
    [SerializeField] private GameObject _gameManagerGO;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = _gameManagerGO.GetComponent<GameManager>();
    }

    private void Update()
    {
        if(!GetGameOver())
            Shoot();
    }

    protected override void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(_projectilePrefab, transform.position, transform.rotation);
        }
    }

    private bool GetGameOver()
    {
        return _gameManager.GameOver;
    }
}
