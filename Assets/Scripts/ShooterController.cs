using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ShooterController : MonoBehaviour
{

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            transform.position.y,
            transform.position.z
        ));
        mousePos.x = Mathf.Clamp(mousePos.x, -2.05f,2.05f);
        transform.position = new Vector3(
            mousePos.x,
            transform.position.y,
            transform.position.z
        );
    }
}
