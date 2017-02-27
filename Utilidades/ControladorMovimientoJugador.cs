using UnityEngine;

public class ControladorMovimientoJugador(
	public float velocidadMovimientoJugador;
	
	void Start(){
	}
	
	void Update(){
		if(Input.GetAxisRaw("Horizontal")>0.2f || Input.GetAxisRaw("Horizontal") <0.2f) {
				transform.translate(new Vector2(Input.GetAxisRaw("Horizontal")*velocidadMovimientoJugador*Time.deltaTime),0f);
			}
	if(Input.GetAxisRaw("Vertical")>0.2f || Input.GetAxisRaw("Vertical") <0.2f) {
				transform.translate(new Vector2(0f, Input.GetAxisRaw("Vertical")*velocidadMovimientoJugador*Time.deltaTime));
			}
		}
			
}