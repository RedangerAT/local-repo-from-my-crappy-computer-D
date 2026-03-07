using UnityEngine;

public class ScriptRotate : MonoBehaviour
{
   [SerializeField] private float rotateSpeed;
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }
}
