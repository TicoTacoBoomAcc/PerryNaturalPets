using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(CharacterController))]
public class FPSController : MonoBehaviour
{
    public GameObject PlayerCON;
    public float walkSpeed = 6f;
    public float runSpeed = 12f;
    public float jumpPower = 7f;
    public float gravity = 10f;
    public float slide = 3f;

    Vector3 moveDirection = Vector3.zero;

    public bool canMove = true;

    public bool hasResetground = false;


    CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        #region Handles Movment
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        // Press Left Shift to run
        bool isSliding = Input.GetKey(KeyCode.LeftControl);
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runSpeed * Input.GetAxis("Vertical") : isSliding ? slide * Input.GetAxis("Vertical") : walkSpeed * Input.GetAxis("Vertical")) : 0;
        float curSpeedY = canMove ? (isRunning ? runSpeed * Input.GetAxis("Horizontal") : isSliding ? slide * Input.GetAxis("Horizontal") : walkSpeed * Input.GetAxis("Horizontal")) : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (isSliding)
        {
            transform.localScale = new Vector3(1, 0.5f, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        #endregion

        #region Handles Jumping
        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
            Debug.Log("Am I Jumping?");
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }
        moveDirection.y -= gravity * Time.deltaTime;

        #endregion

        #region Handles Rotation
        characterController.Move(moveDirection * Time.deltaTime);

        #endregion
    }
}