using UnityEngine;

public class Player : Person
{
    [SerializeField] private int _damage;

    public int Damage { get => _damage; }

    private float _experience;

    public float Experience { get { return _experience; } set { _experience = value; } }

    private void Start()
    {
        Experience = 100;
        ShowStat();
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
