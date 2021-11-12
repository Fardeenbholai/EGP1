using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotationCamera = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;//input voor de x as.
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;//input voor de y as.

        xRotationCamera -= mouseY;//rotatie van de camera
        xRotationCamera = Mathf.Clamp(xRotationCamera, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotationCamera, 0f, 0f);//locatiebepaling
        playerBody.Rotate(Vector3.up * mouseX);//positieverhogen van de player.
    }
}