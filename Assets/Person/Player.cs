using UnityEngine;

public class Player : Person
{
    [SerializeField] private Person dragon;
    [SerializeField] private int damage;
    private float _experience;

    public float Experience { get { return _experience; } set { _experience = value; } }

    private void Start()
    {
        Experience = 100;
        ShowStat();
        dragon.TakeDamage(damage);
    }

    protected override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Experience: {_experience}");
    }

    public override void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"My name {Name}: After hitting with force: {damageValue}, I have: {Health} health.");
    }
}
