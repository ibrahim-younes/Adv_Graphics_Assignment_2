using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera thirdPersonCam;
    [SerializeField] CinemachineVirtualCamera firstPersonCam;
    [SerializeField] Light spotLight;
    [SerializeField] Light directionalLight;

    private void Zoom()
    {
            if (Input.GetKeyDown("8"))
            {
                thirdPersonCam.m_Lens.FieldOfView = 55f;
            }

            if (Input.GetKeyDown("9"))
            {
                thirdPersonCam.m_Lens.FieldOfView = 65f;
            }
            if (Input.GetKeyDown("0"))
            {
                thirdPersonCam.m_Lens.FieldOfView = 75f;
            }
    }

    private void OnEnable()
    {
        Switcher.Register(thirdPersonCam);
        Switcher.Register(firstPersonCam);
        Switcher.SwitchCamera(thirdPersonCam);
    }
    private void OnDisable()
    {
        Switcher.Unregister(thirdPersonCam);
        Switcher.Unregister(firstPersonCam);
    }

    public void Update()
    {
        if (Input.GetKeyDown("1")) 
        {
            if (Switcher.IsActiveCamera(thirdPersonCam))
            {
                Switcher.SwitchCamera(firstPersonCam);

                spotLight.enabled = false;

                directionalLight.enabled = true;
            }
        }

        if (Input.GetKeyDown("2")) 
        {
            if (Switcher.IsActiveCamera(firstPersonCam))
            {
                Switcher.SwitchCamera(thirdPersonCam);

                spotLight.enabled = true;

                directionalLight.enabled = false;
            }
        }

        Zoom();
    }

}
