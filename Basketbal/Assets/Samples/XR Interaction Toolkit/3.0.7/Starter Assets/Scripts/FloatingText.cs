using UnityEngine;

public class FloatingText : MonoBehaviour
{
    Transform mainCam;

    public float distanceFromPlayer = 2.0f;     // offset from player
    public float verticalOffset = 0f;
    public float horizontalOffset = -4f;

    void Start()
    {
        mainCam = Camera.main.transform;
    }

    void Update()
    {
        Vector3 forwardOffset = mainCam.forward * distanceFromPlayer;
        Vector3 verticalOffsetVector = Vector3.up * verticalOffset;
        Vector3 horizontalOffsetVector = mainCam.right * horizontalOffset;

        transform.position = mainCam.position + forwardOffset + verticalOffsetVector + horizontalOffsetVector;

        Vector3 cameraForward = mainCam.forward;
        cameraForward.y = 0;                    // keeps text upright
        Quaternion lookRotation = Quaternion.LookRotation(cameraForward);
        transform.rotation = lookRotation;
    }
}
