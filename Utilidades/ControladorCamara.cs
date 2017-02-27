using UnityEngine;

public class ControladorCamara{

   public GameObject objetivoASeguir;
   public float velocidadMovimiento;
   public Vector3 posicionObjetivo;
   public BoxCollider2D limitesColisionCamara;
   
   public static bool camaraExiste;
   
   private Vector3 bordeMaximo;
   private Vector3 bordeMinimo;
   private float mitadAltura;
   private float mitadAnchura;
   
   private Camera camara;
   
   void Start(){
     DontDestroyOnLoad(transform.gameObject)
     
     if(!camaraExiste){
        camaraExiste=true;
        DontDestroyOnLoad(transform.gameObject);
     }else{
     Destroy(gameObject);
     }
     
     bordeMaximo = limitesColisionCamara.bounds.max;
     bordeMinimo = limitesColisionCamara.bounds.min;
     
     mitadAltura = camara.orthographicSize;
     mitadAnchura = mitadAltura* Screen.width/Screen.height;
   }
   
   void Update(){
      posicionObjetivo = new Vector3(objetivoASeguir.transform.position.x,objetivoASeguir.transform.position.y,transform.position.z);
      transform.position = Vector3.Lerp(transform.positiom, posicionObjetivo, velocidadMovimiento*Time.deltaTime);
      
      float clampearX = Mathf.Clamp(transform.position.x, bordeMinimo.x + mitadAnchura, bordeMaximo.x - mitadAnchura );
      
      float clampearY = Mathf.Clamp(transform.position.y, bordeMinimo.y + mitadAltura, bordeMaximo.y - mitadAltura );
      
      transform.position = new Vector(clampearX, clampearY, transform.position.z);
   }
}