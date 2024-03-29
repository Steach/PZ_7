using UnityEngine;

public class Dragon : Person
{
    [SerializeField] private int _damage;
    public int Damage { get => _damage; }

    public override void TakeDamage(int damageValue)
    {
        Debug.Log($"I - the mughty dragon, have lost: {damageValue} hit point from a hunter shot.");
    }
}
