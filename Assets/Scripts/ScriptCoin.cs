using UnityEngine;

public class ScriptCoin : MonoBehaviour, ICollidable
{
    [SerializeField] private int value;


    public void OnCollideWithPlayer(ScriptPlayerCollision playerCollision)
    {
        Debug.Log("Collided with coin");
        ScriptCoinCounter coinCounter;
        if (playerCollision.TryGetComponent(out coinCounter))
        {
            coinCounter.IncreaseCoinCount(value);
            Debug.Log(coinCounter.GetCoinCount());
            Destroy(gameObject);
        }
      
    }
}
