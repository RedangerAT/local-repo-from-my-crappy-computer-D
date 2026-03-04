using UnityEngine;

public class ScriptCoin : MonoBehaviour
{
    [SerializeField] private int value;

    public int GetValue() // getter method value
    {
        return value;
    }
}
