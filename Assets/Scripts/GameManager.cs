using UnityEngine;

public class GameManager : MonoBehaviour
{
    //[SerializeField] private GameObject _playerGO;
    [SerializeField] private GameObject _gameOverText;

    [SerializeField] private Player _player;

    private bool _gameOver = false;
    public bool GameOver { get { return _gameOver; } }

    private void Start()
    {
        //_player = GetComponent<Player>();
        _gameOverText.SetActive(_gameOver);

    }

    private void Update()
    {
        GetPlayerHP();
    }

    private void GetPlayerHP()
    {
        if (_player != null && _player.Health <= 0)
        {
            Debug.Log($"GameManager: {_player.Health}");
            _gameOver = true;
            EnableGameOverText();
        }
    }

    private void EnableGameOverText() => _gameOverText.SetActive(_gameOver);
}
