using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public Vector3 RotationAxis = Vector3.up;
    public float RotationSpeed = 10;

	void Update () {
        transform.RotateAround(transform.position, RotationAxis, RotationSpeed * Time.deltaTime);
	}
}
