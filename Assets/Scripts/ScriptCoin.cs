using UnityEngine;

public class ScriptCoin : MonoBehaviour, ICollidable
{
    [SerializeField] private int value;

    public int GetValue() // getter method value
    {
        return value;
    }
    public void OnCollideWithPlayer()
    {
        Debug.Log("Collided with coin");
    }
}
