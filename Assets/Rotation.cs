using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float rotationAngleX = 15f;
    public float rotationAngleY = 30f;
    public float rotationAngleZ = 45f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rotationAngleX, rotationAngleY, rotationAngleZ) * rotationSpeed * Time.deltaTime);
    }
}
