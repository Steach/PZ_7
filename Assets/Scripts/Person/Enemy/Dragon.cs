using UnityEngine;

public class Dragon : Person
{
    [SerializeField] private int damage;

    public override void TakeDamage(int damageValue)
    {
        Debug.Log($"I - the mughty dragon, have lost: {damageValue} hit point from a hunter shot.");
    }
}
