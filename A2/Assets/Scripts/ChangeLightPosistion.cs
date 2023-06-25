using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightPosistion : MonoBehaviour
{

    [SerializeField] private Light Alight;
    public float moveSpeed = 5f; // Speed of light movement

    private void Update()
    {
        // Move the light when the specified key is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            Alight.transform.Rotate(Vector3.up * 60);
        }
    }
}
