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

            collidable.OnCollideWithPlayer(this);
        }


       
    }
}
