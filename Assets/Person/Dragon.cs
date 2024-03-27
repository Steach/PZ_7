using UnityEngine;

public class Dragon : Person
{
    [SerializeField] private Person player;
    [SerializeField] private int damage;

    private void Start()
    {
        player.TakeDamage(damage);
    }
    public override void TakeDamage(int damageValue)
    {
        Debug.Log($"I - the mughty dragon, have lost: {damageValue} hit point from a hunter shot.");
    }
}
