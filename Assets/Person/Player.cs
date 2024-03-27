using UnityEngine;

public class Player : Person
{
    private float _experience;

    public float Experience { get; }

    protected override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Experience: {_experience}");
    }
}
