using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraScript : MonoBehaviour
{
    [SerializeField] private float cameraSensitivity = 5f;

    [SerializeField] private float yMin = 5f;
    [SerializeField] private float yMax = 5f;

    [SerializeField] private Transform player;

    private Transform cameraTransform;

    private float yRotation;

    void Start()
    {
        cameraTransform = this.transform;
    }

    void Update()
    {
        CheckForMouseMovement();
    }

    private void CheckForMouseMovement()
    {
        player.Rotate(Vector3.up * Input.GetAxis("Mouse X") * cameraSensitivity);
        yRotation += Input.GetAxis("Mouse Y") * cameraSensitivity;
        yRotation = Mathf.Clamp(yRotation, yMin, yMax);
        cameraTransform.localEulerAngles = Vector3.left * yRotation;
    }
}
