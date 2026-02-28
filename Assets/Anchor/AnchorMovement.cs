using UnityEditor;
using UnityEngine;

public class AnchorMovement : MonoBehaviour
{
    public float vertSpeed;
    public float horizSpeed;

    float xInput;
    float yInput;

    public Rigidbody2D body;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        MoveWithInput();
    }
    void GetInput()
    {
        //xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }
    void MoveWithInput()
    {

        //movement variant B -> check x and y and only change velocity if key pressed = constant movement
        //requires speed to be set to 5, linear damping to 10
        /*if (Mathf.Abs(xInput) > 0)
        {
            body.linearVelocity = new Vector2(xInput * horizSpeed, body.linearVelocity.y);
        }*/
        if (Mathf.Abs(yInput) > 0 )
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, yInput * vertSpeed);
        }
    }
}
