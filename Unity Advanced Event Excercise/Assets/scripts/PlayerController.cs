using UnityEngine;
using UnityEngine.Events;
public class PlayerController : MonoBehaviour
{
    public UnityEvent OnKilled;
    public UnityEvent OnHurt;
   
    public float Scale = .01f;
    public float TurnSpeed = 100.0f;
    [SerializeField] float speed = 5;
    [SerializeField] float Rotation_Speed = 25;
    [SerializeField] Transform Cam;
    


    // Start is called before the first frame update
    void Start()
    {
        OnKilled.AddListener(OnKilledHandler);
    }

    void OnKilledHandler()
    {  
        Destroy(this);
    }
    public void Update()
    {

        Cam.LookAt(transform);


        if (Input.GetKey(KeyCode.RightArrow))


        {
            Debug.Log("Right Arrow Pressed:");
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }


        if (Input.GetKey(KeyCode.LeftArrow))


        {
            Debug.Log("Left Arrow Pressed:");
            transform.Translate(Vector3.left * Time.deltaTime * 10);

        }

        if (Input.GetKey(KeyCode.UpArrow))


        {
            Debug.Log("Up Arrow Pressed:");
            transform.Translate(Vector3.forward * Time.deltaTime * 10);

        }

        if (Input.GetKey(KeyCode.DownArrow))


        {
            Debug.Log("Down Arrow Pressed:");
            transform.Translate(Vector3.back * Time.deltaTime * 10);

        }
        // UpScale  
        if (Input.GetKey(KeyCode.P))
        {
            Debug.Log("P Pressed:");


            //scaleY.ScaleX.ScaleZ
            transform.localScale = transform.localScale + new Vector3(Scale, Scale, Scale);



        }
        //DownScale 
        else if (Input.GetKey(KeyCode.M))
        {
            Debug.Log("M Pressed:");
            //scaleY.ScaleX.ScaleZ
            transform.localScale = transform.localScale + new Vector3(-Scale, -Scale, -Scale);
        }

        // Rotate on Y Axis(SideWays)
        if (Input.GetKey(KeyCode.D))
        {

            Debug.Log("D Pressed:");

            transform.Rotate(Vector3.up * Rotation_Speed * Input.GetAxis("Horizontal") * Time.deltaTime);


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
            Debug.Log("S Pressed:");
            transform.Rotate(Vector3.forward * Rotation_Speed * Input.GetAxis("Vertical") * Time.deltaTime);
        }



    }
}
