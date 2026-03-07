using UnityEngine;

public class ScriptObstacle : MonoBehaviour, ICollidable
{
    [SerializeField] private int coinPenalty;


   

    public void OnCollideWithPlayer(ScriptPlayerCollision playerCollision)
    {
        Debug.Log("Collided with coin");
        ScriptCoinCounter coinCounter;

        if (playerCollision.TryGetComponent(out coinCounter))
        {
            coinCounter.DecreaseCoinCount(coinPenalty);
            Debug.Log(coinCounter.GetCoinCount());
        }
       
    }
}
