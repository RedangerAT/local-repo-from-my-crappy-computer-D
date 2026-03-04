using UnityEngine;

public class ScriptObstacle : MonoBehaviour
{
    [SerializeField] private int coinPenalty;

    public int GetCoinPenalty()
    {
        return coinPenalty;
    }
}
