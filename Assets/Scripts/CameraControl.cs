using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    Transform camera;

    [SerializeField]
    float xPosition, yPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            camera.position = new Vector3(xPosition, yPosition, -10f); 
        }
    }
}
