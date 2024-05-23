using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotationAngle = 90f; // Angle to rotate the camera
    public float rotationSpeed = 2f; // Speed of the rotation

    private Quaternion targetRotation;

    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            RotateCamera(-rotationAngle); // Rotate anti-clockwise
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            RotateCamera(rotationAngle); // Rotate clockwise
        }

        // Smoothly rotate the camera to the target rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }

    void RotateCamera(float angle)
    {
        targetRotation *= Quaternion.Euler(0, angle, 0);
        Debug.Log("Camera rotation after rotation: " + targetRotation.eulerAngles);
        
        float cameraAngle = targetRotation.eulerAngles.y;

        if (cameraAngle == 0)
        {
            Debug.Log("Zone1");
        }
        else if (cameraAngle == 90)
        {
            Debug.Log("Zone2");
        }
        else if (cameraAngle == 180)
        {
            Debug.Log("Zone3");
        }
        else if (cameraAngle == 270)
        {
            Debug.Log("Zone4");
        }
        else
        {
            Debug.Log("Unknown Zone");
        }
        

    }
}
