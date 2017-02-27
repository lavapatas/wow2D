using UnityEngine;

public class ControladorMovimientoJugador(
	public float velocidadMovimiento;
	
	void Start(){
	}
	
	void Update(){
		if(Input.GetAxisRaw("Horizontal")>0.2f || Input.GetAxisRaw("Horizontal") <0.2f) {
				transform.translate(new Vector2(Input.GetAxisRaw("Horizontal")*velocidadMovimiento*Time.deltaTime),0f);
			}
	if(Input.GetAxisRaw("Vertical")>0.2f || Input.GetAxisRaw("Vertical") <0.2f) {
				transform.translate(new Vector2(Input.GetAxisRaw("Vertical")*velocidadMovimiento*Time.deltaTime),0f);
			}
		}
			
}