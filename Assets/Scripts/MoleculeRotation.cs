using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeRotation : MonoBehaviour
{
    [SerializeField]
    float RotationSpeed = 3.0f;

    void Update()
    {
        transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
    }
}
