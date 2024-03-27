using UnityEngine;

public abstract class Person : MonoBehaviour
{
    private string _name = "Arthur";
    private int _health = 100;

    public string Name { get; }
    public int Health
    {
        get 
        {
            return _health;
        } 
        set 
        {
            if (value < 0)
            {
                Debug.Log($"Health can`t be lower than 0.");
                value = 0;
                _health = value;
            }
            else if (value > 100)
            {
                Debug.Log($"Health can`t be greater than 100.");
                value = 100;
                _health = value;
            }
        }
    }

    protected virtual void ShowStat()
    {
        Debug.Log($"Name: {_name}\nHealth: {_health}");
    }

    public abstract void TakeDamage(int damage);
}
