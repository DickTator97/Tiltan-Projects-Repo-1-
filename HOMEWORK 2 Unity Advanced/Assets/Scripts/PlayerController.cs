using UnityEngine;
using UnityEngine.Events;
public class PlayerController : MonoBehaviour
{
   
    public float Scale = .01f;
    public float TurnSpeed = 110.0f;
    
    [SerializeField] float MoveSpeed = 10;
    [SerializeField] float Rotation_Speed = 20;
    [SerializeField] Transform Cam;
    

    // add 2 events 
    // use events with invoke
    // put events in inspector
    //Bonus: Add "Add Listener to Events Instead"

   

   
    public void Update()
    {

        Cam.LookAt(transform);

        //Move Right
        
        if (Input.GetKey(KeyCode.D))


        {
            Debug.Log("D Key Pressed:");
            transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);

        }

        //Move Left
        if (Input.GetKey(KeyCode.A))


        {
            Debug.Log("A Key Pressed:");
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);

        }

        //Move Forward
        if (Input.GetKey(KeyCode.W))


        {
            Debug.Log("W Key Pressed:");
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);

        }

        //Move BackWard
        if (Input.GetKey(KeyCode.S))


        {
            Debug.Log("S Key Pressed:");
            transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed);

        }
      
     
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A Pressed:");
            transform.Rotate(Vector3.up * Rotation_Speed * Input.GetAxis("Horizontal") * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.W))
        {

            Debug.Log("W Pressed:");

            transform.Rotate(Vector3.forward * Rotation_Speed * Input.GetAxis("Vertical") * Time.deltaTime);


        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S Key Pressed:");
            transform.Rotate(Vector3.forward * Rotation_Speed * Input.GetAxis("Vertical") * Time.deltaTime);
        }

    }
}
