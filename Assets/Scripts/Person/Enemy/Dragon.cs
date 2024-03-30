using UnityEngine;

public class Dragon : Person
{
    [SerializeField] private int _damage;
    public int Damage { get => _damage; }

    private void Start()
    {
        Health = 100;
        _sliderHP.maxValue = Health;
    }

    private void Update()
    {
        HP();
        Death();
    }

    public override void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"I - the mughty dragon, have lost: {damageValue} hit point from a hunter shot.");
    }

    public override void Death()
    {
        if (Health <= 0)
        {
            Debug.Log("Dragon is dead!");
            gameObject.SetActive(false);
        }
    }
}
