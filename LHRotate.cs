using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHRotate : MonoBehaviour
{
    [SerializeField] GameObject LHFlash;
    [SerializeField] float Speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        LHFlash.transform.Rotate(0.0f, Speed, 0.0f, Space.World);
    }
}
