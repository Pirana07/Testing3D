
using UnityEngine;

public class Movment : MonoBehaviour
{
   public Rigidbody rb;
   public float forwardForce = 2000f;
   public float gverdze = 500f;
    
    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
       
        if(Input.GetKey("d"))
        {
            rb.AddForce(gverdze * Time.deltaTime, 0, 0);
        }
        
        if(Input.GetKey("a"))
        {
            rb.AddForce(-gverdze * Time.deltaTime, 0, 0);
        }
    }
}
