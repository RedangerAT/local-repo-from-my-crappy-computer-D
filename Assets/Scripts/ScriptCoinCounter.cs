using UnityEngine;
using TMPro;

public class ScriptCoinCounter : MonoBehaviour
{
    [SerializeField] private int CoinCount;
    [SerializeField] private TextMeshProUGUI coinCountText;

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
        RefreshCoinCountText();


    }
    public void DecreaseCoinCount(int amount) // kind of like a setter
    {
        CoinCount -= amount;
        RefreshCoinCountText();
    }
    
    private void RefreshCoinCountText()
    {
        coinCountText.text = "Coins collected:" + CoinCount;
    }
}
