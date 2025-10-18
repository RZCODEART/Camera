using UnityEngine;
using UnityEngine.Splines.ExtrusionShapes;

public class SlowMotionController : MonoBehaviour
{
    
    public Collider2D lento;
    public Collider2D original;

    public Color TriggerC = Color.blue;
    public Color whiteC = Color.white;
    public SpriteRenderer srLento;
    public SpriteRenderer srOriginal;

    [Header("Camara lenta")]
    [Range(0.01f, 1f)]
    public float camaraLenta = 0.2f;
    [SerializeField] float escalaTiempoOriginal;

    public CameraController destino;

    private void Awake()
    {
        
    }



    void Start()
    {
        escalaTiempoOriginal = Time.timeScale;
        srLento.material.color = whiteC;
        srOriginal.material.color = whiteC;
       
    }

    // Update is called once per frame
    void Update()
    {




    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trigger")
        {
            srLento.material.color = TriggerC;
            srOriginal.material.color = whiteC;
            Time.timeScale = camaraLenta;
            Time.fixedDeltaTime = Time.timeScale * 0.02f; // Este es el valor por defecto para la fisicas.
        }



        if (other.tag == "OriginalTime")
        {
            Time.timeScale = escalaTiempoOriginal;
            Time.fixedDeltaTime = 0.02f;
            srLento.material.color = whiteC;
            srOriginal.material.color = TriggerC;
        }

        if (other.tag == "Camera")
        {
            if (destino != null)
            {
                destino.CambioCamera();
                print("cambio de camara vaaa...");
            }
            

        }


    }

}
