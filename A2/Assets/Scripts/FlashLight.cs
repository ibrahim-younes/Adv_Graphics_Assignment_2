using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashLight : MonoBehaviour
{
    [SerializeField] GameObject FlashLightLight;
    [SerializeField] Light directionalLight;

    private bool FlashLightActive = false;

    private void Start()
    {
        FlashLightLight.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (FlashLightActive == false)
            {
                FlashLightLight.gameObject.SetActive(true);
                FlashLightActive = true;
            }
            else
            {
                FlashLightLight.gameObject.SetActive(false);
                FlashLightActive = false;
            }
        }
    }
}
