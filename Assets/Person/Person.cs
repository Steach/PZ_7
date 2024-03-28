using UnityEngine;

public abstract class Person : MonoBehaviour
{
    private string _name = "Arthur";
    private int _health = 100;

    public string Name { get; }
    public int Health
    {
        get => _health;
        set 
        {
            switch (value)
            {
                case < 0:
                    Debug.Log($"Health can`t be lower than 0.");
                    _health = 0; 
                    break;
                case > 100:
                    Debug.Log($"Health can`t be greater than 100.");
                    _health = 100;
                    break;
                default:
                    _health = value; 
                    break;
            }
        }
    }

    protected virtual void ShowStat()
    {
        Debug.Log($"Name: {_name}\nHealth: {_health}");
    }

    public abstract void TakeDamage(int damage);
}
