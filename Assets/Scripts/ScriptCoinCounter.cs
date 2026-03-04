using UnityEngine;

public class ScriptCoinCounter : MonoBehaviour
{
    [SerializeField] private int CoinCount;

    private void Awake()
    {
        CoinCount = 0;
    }
    //getter method
    public int GetCoinCount()
    {
        return CoinCount;
    }
  // Setter method
    public void IncreaseCoinCount(int amount) // kind of like a setter
    {
        CoinCount += amount;
    }
    public void DecreaseCoinCount(int amount) // kind of like a setter
    {
        CoinCount -= amount;
    }
}
