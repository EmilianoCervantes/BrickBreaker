using UnityEngine;
using System.Collections;

public class BarraJugador : MonoBehaviour {

	public float velocidad = 1f;

	private Vector3 posicion = new Vector3 (0, 0.4f, -3f);


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float posicionX = transform.position.x + (Input.GetAxis ("Horizontal")*velocidad);
		posicion = new Vector3 (Mathf.Clamp (posicionX, -4f, 4f), 0.4f, -3f);
		transform.position = posicion;
	}
}
