using UnityEngine;

public class ScriptPlayerCollision : MonoBehaviour
{
    private ScriptCoinCounter coinCounter;

    private void Awake()
    {
        coinCounter = GetComponent<ScriptCoinCounter>();
    }
    private void OnTriggerEnter(Collider other)
    {

        ICollidable collidable;
        if (other.TryGetComponent(out collidable))
        {

            collidable.OnCollideWithPlayer();
        }


        /* ScriptCoin coin = other.GetComponent<ScriptCoin>();
         ScriptObstacle obstacle = other.GetComponent<ScriptObstacle>();
          if (coin != null) // then 'other' has a coin component, so it is a coin 
         ScriptCoin coin = null;


        if (other.TryGetComponent (out coin))
         {

             coinCounter.IncreaseCoinCount(coin.GetValue());
             Debug.Log(coinCounter.GetCoinCount());
         }

         ScriptObstacle obstacle = null;
       if (other.TryGetComponent (out obstacle)) // then 'other' has a obstacle component, so it is a obstacle 
         {

             coinCounter.DecreaseCoinCount(obstacle.GetCoinPenalty());
             Debug.Log(coinCounter.GetCoinCount());
         }
       */
    }
}
