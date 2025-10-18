using TMPro;
using Unity.Cinemachine;
using Unity.Cinemachine.Editor;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.UIElements;



public class CameraController : MonoBehaviour
{

    [Header("Camera")]
    public CinemachineCamera cam01, cam02;
    private string DescZoom;

    [Header("Cameras Live")]
    public TextMeshProUGUI camera1;
    public TextMeshProUGUI camera2;

   // private bool isCamera = false;
   // private bool isBicho = false;


    void Start()
    {
        if (cam01 != null && cam02 != null)
        {
            cam01.Priority = 15;
            cam02.Priority = 10;
            camera1.fontStyle = FontStyles.Bold;
            camera1.color = Color.red;
            camera2.fontStyle = FontStyles.Normal;
            camera2.color = Color.white;

        }

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cam01.Priority = 15;
            cam02.Priority = 10;
            
            camera1.fontStyle = FontStyles.Bold;
            camera1.color = Color.red;
            camera2.fontStyle = FontStyles.Normal;
            camera2.color = Color.white;
            

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cam01.Priority = 10;
            cam02.Priority = 15;

            camera2.fontStyle = FontStyles.Bold;
            camera2.color = Color.red;
            camera1.fontStyle = FontStyles.Normal;
            camera1.color = Color.white;


        }
        
    }

   
    public void selectCamera1()
    {
        cam01.Priority = 15;
        cam02.Priority = 10;

        camera1.fontStyle = FontStyles.Bold;
        camera1.color = Color.red;
        camera2.fontStyle = FontStyles.Normal;
        camera2.color = Color.white;

        print("seleccionas el numero 1");
                 

    }

    public void selectCamera2()
    {
        cam01.Priority = 10;
        cam02.Priority = 15;

        camera2.fontStyle = FontStyles.Bold;
        camera2.color = Color.red;
        camera1.fontStyle = FontStyles.Normal;
        camera1.color = Color.white;


    }

    public void CambioCamera ()
    {
           cam01.Priority = 10;
            cam02.Priority = 15;

            camera2.fontStyle = FontStyles.Bold;
            camera2.color = Color.red;
            camera1.fontStyle = FontStyles.Normal;
            camera1.color = Color.white;

       
    }


}
