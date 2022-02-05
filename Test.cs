using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 Direction;
    public float MaxDistance = 5;

    private float _sign = 1;

    private void Update()
    {
        var rotation = transform.eulerAngles;
        rotation.x += 1;
        rotation.y += -1;
        Cube.transform.position += _sign * Direction * Time.deltaTime;
        if (MaxDistance <= Cube.transform.position.magnitude)
            _sign *= -1; 
        transform.eulerAngles = rotation;
    }
}
