using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleculeRotation : MonoBehaviour
{
    [SerializeField]
    private float PCRotationSpeed = 10f;

    [SerializeField]
    private float MobileRotationSpeed = 0.4f;

    [SerializeField]
    private Camera cam;

    void Update()
    {
        // transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));


        foreach (Touch touch in Input.touches)
        {
            Debug.Log("Touching at: " + touch.position);
            Ray camRay = cam.ScreenPointToRay(touch.position);
            RaycastHit raycastHit;
            if (Physics.Raycast(camRay, out raycastHit, 10))
            {
                if (touch.phase == TouchPhase.Began)
                {
                    Debug.Log("Touch phase began at: " + touch.position);
                }
                else if (touch.phase == TouchPhase.Moved)
                {
                    Debug.Log("Touch phase Moved");
                    transform.Rotate(
                        touch.deltaPosition.y * MobileRotationSpeed,
                        -touch.deltaPosition.x * MobileRotationSpeed,
                        0,
                        Space.World
                    );
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    Debug.Log("Touch phase Ended");
                }
            }
        }
    }

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * PCRotationSpeed;
        float rotY = Input.GetAxis("Mouse Y") * PCRotationSpeed;

        Vector3 right = Vector3.Cross(
            cam.transform.up,
            transform.position - cam.transform.position
        );
        Vector3 up = Vector3.Cross(transform.position - cam.transform.position, right);
        transform.rotation = Quaternion.AngleAxis(-rotX, up) * transform.rotation;
        transform.rotation = Quaternion.AngleAxis(rotY, right) * transform.rotation;
    }
}
