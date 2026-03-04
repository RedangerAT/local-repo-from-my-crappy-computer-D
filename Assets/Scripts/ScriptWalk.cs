using UnityEngine;

public class ScriptWalk : MonoBehaviour
{

    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float forwardSpeed;
    private float XLimit;
    private float NegativeXLimit;




    private void Start()
    {
        XLimit = 6.5f;
     
    }

    // Update is called once per frame
    void Update()
    {
  
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if ( transform.position.x > -XLimit)
            {
                transform.Translate(Vector3.left * forwardSpeed * Time.deltaTime);
            }
         
        }
         if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
         {
            if (transform.position.x < XLimit)
            {
                transform.Translate(Vector3.right * forwardSpeed * Time.deltaTime);
            }
           

         }
        
         
            transform.Translate(Vector3.forward * horizontalSpeed * Time.deltaTime);

         
        /* use this when your gonna make long comments like thissss
         
         
       
        you can write srtuff inbetween too







        hiiiiiiiii*/
        // YOOOOOOOOOOOOOO IM COMMUNICATING THRU GITHUB!!!!!
    }
  
}
