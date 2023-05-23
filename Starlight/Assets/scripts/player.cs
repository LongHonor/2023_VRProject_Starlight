using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float yVelocity;
    public float gravity;

    public Transform cameraTransform;
    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        gravity = -20f;
        yVelocity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    private void playerMove()
    {
        float _moveDirX = Input.GetAxisRaw("Horizontal");
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(_moveDirX, 0, _moveDirZ);

        moveDirection = cameraTransform.TransformDirection(moveDirection);

        moveDirection *= speed;

        yVelocity += (gravity * Time.deltaTime);

        moveDirection.y = yVelocity;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
