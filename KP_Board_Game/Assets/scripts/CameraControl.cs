using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotationAngle = 90f; // Angle to rotate the camera
    public float transitionSpeed = 2f; // Speed of the rotation and position transition
    public Vector3[] positions; // Predefined positions for the camera
    public Vector3[] rotations; // Predefined rotations for the camera

    private Quaternion targetRotation;
    private Vector3 targetPosition;
    private Vector3 initialRotation;
    private int currentZone = 0;
    private bool isTransitioning = false;

    void Start()
    {
        targetRotation = transform.rotation;
        targetPosition = transform.position;
        initialRotation = transform.rotation.eulerAngles;
        positions = new Vector3[] {
            new Vector3(0, 40, -40), // Zone1
            new Vector3(-40, 40, 0), // Zone2
            new Vector3(0, 40, 40), // Zone3
            new Vector3(40, 40, 0)  // Zone4
        };
        rotations = new Vector3[] {
            new Vector3(45, 0, 0), // Zone1
            new Vector3(45, 90, 0), // Zone2
            new Vector3(45, 180, 0), // Zone3
            new Vector3(45, 270, 0) // Zone4
        };
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("Key L Pressed");
            RotateCamera(-rotationAngle); // Rotate anti-clockwise
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Key R Pressed");
            RotateCamera(rotationAngle); // Rotate clockwise
        }

        // Smoothly rotate and move the camera to the target rotation and position
        if (isTransitioning)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * transitionSpeed);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * transitionSpeed);

            // Check if the rotation and position transition is nearly complete
            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f && Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                transform.rotation = targetRotation; // Snap to the final rotation
                transform.position = targetPosition; // Snap to the final position
                isTransitioning = false;
            }
        }
    }

    void RotateCamera(float angle)
    {
        float newY = (initialRotation.y + angle) % 360;
        if (newY < 0) newY += 360;
        initialRotation = new Vector3(initialRotation.x, newY, initialRotation.z);

        targetRotation = Quaternion.Euler(initialRotation);
        UpdateCameraPositionAndRotation();
        isTransitioning = true;
    }

    void UpdateCameraPositionAndRotation()
    {
        float cameraAngle = targetRotation.eulerAngles.y;

        if (Mathf.Approximately(cameraAngle, 0))
        {
            Debug.Log("Zone1");
            currentZone = 0;
        }
        else if (Mathf.Approximately(cameraAngle, 90))
        {
            Debug.Log("Zone2");
            currentZone = 1;
        }
        else if (Mathf.Approximately(cameraAngle, 180))
        {
            Debug.Log("Zone3");
            currentZone = 2;
        }
        else if (Mathf.Approximately(cameraAngle, 270))
        {
            Debug.Log("Zone4");
            currentZone = 3;
        }
        else
        {
            Debug.Log("Unknown Zone");
        }

        // Update the target position and rotation for smooth transition
        targetPosition = positions[currentZone];
        targetRotation = Quaternion.Euler(rotations[currentZone]);
    }
}
