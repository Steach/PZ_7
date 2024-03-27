using UnityEngine;

public class Person : MonoBehaviour
{
    private string _name;
    private int _health;

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
}
