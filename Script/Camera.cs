using TMPro;
using Unity.Cinemachine;
using Unity.Cinemachine.Editor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Header("Camera")]
    public CinemachineCamera vcam;
    [SerializeField] private int zoom;
    [SerializeField] private float zoomP;
    public TextMeshProUGUI TexFOV;
    private string DescZoom;


    void Start()
    {
        zoom = 22;
        vcam = GetComponent<CinemachineCamera>();
        vcam.Lens.FieldOfView = zoom;
        
    }

    // Update is called once per frame
    void Update()
    {

        zoomCamera();
        vcam.Lens.FieldOfView = zoom;
        Limite();
        TexFOV.SetText("FOV: " + zoom + "  " + DescZoom);
    }
    void zoomCamera()
    {
        zoomP = Input.GetAxis("Vertical");
        if (zoomP > 0)
        {
            zoom++;
            DescZoom = "Alejarse";
        }
        if (zoomP < 0)
        {
            zoom--;
            DescZoom = "Acercarse";
          
        }
    }
    void Limite()
    {
        if (zoom <= 2)
        {
            DescZoom = "Muy Cerca";
        }
        if (zoom >= 140)
        {
            DescZoom = "Muy Lejos";
        }
    }
    
}





