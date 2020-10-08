using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controler : MonoBehaviour
{
    [SerializeField]
    private CharacterController player;

    public Vector3 direction = Vector3.zero;

    public float walkingSpeed;
    public float jumpForce;

    public float gravity = 9.81f;
    public float gravityForce;

    public bool isGrounded = false;

    public Camera mycamera;

    public float mouseXSensibility = 1.0f;
    public float mouseYSensibility = 1.0f;

    public bool invertY = false;

    public float topAngleY = 45.0f;
    public float botAngleY = 45.0f;

    private Rigidbody rigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float mouse_X = Input.GetAxis("Mouse X") * mouseXSensibility * Time.fixedDeltaTime;
        float mouse_y = Input.GetAxis("Mouse Y") * mouseYSensibility * Time.fixedDeltaTime;

        mouse_y = Mathf.Clamp(mouse_y, botAngleY, topAngleY);

        mouse_y = invertY ? mouse_y * -1 : mouse_y * 1;

    }
}
