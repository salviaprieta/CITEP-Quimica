using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    [Header("CorrectGeometry1")]
    [SerializeField]
    private Transform[] geometry1Elements;

    void Start()
    {
        if (gameObject.name == "CorrectGeometry1")
        {
            // print("PEPE");
            // GUIUtility.ScaleAroundPivot(
            //     geometry1Elements[0].position,
            //     geometry1Elements[1].position
            // );
            // GUI.Label(new Rect(200, 200, 256, 256), "");

            // LineRenderer lineRenderer = new GameObject("Line").AddComponent<LineRenderer>();
            // lineRenderer.startColor = Color.black;
            // lineRenderer.endColor = Color.black;
            // lineRenderer.startWidth = 0.01f;
            // lineRenderer.endWidth = 0.01f;
            // lineRenderer.positionCount = 2;
            // lineRenderer.useWorldSpace = true;

            // lineRenderer.SetPosition(0, geometry1Elements[0].position);
            // lineRenderer.SetPosition(1, geometry1Elements[1].position);
        }
    }
}
