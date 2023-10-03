using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Transform FPCamera;

    [SerializeField]
    private float toggleAngle = 30f;

    [SerializeField]
    private float speed = 30f;

    [SerializeField]
    private bool moveForward = false;

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (FPCamera.eulerAngles.x >= toggleAngle && FPCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward= false;
        }

        if (moveForward)
        {
            Vector3 v_forward = FPCamera.TransformDirection(Vector3.forward);
            characterController.SimpleMove(v_forward * speed);
        }
    }
}
