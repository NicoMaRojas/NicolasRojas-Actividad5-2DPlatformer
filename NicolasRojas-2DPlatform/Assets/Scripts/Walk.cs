using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Walk : MonoBehaviour {

	float speed = 0.1f;

	int monedas = 0;

	public Text contadorCoins; 

	int life = 0;

	public Text contadorLife; 



	// Use this for initialization
	void Start () {
	}

	public void clickEnElBoton(){
		this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 5, ForceMode2D.Impulse);
	}


	//Cuando el collider 2D que es contenido por el gomebject
	// colisiona con otro collider2D
	void OnCollisionEnter2D(Collision2D coll) {

		if (coll.gameObject.tag == "Moneda") {

			// aumentar la cantidad de monedas del usuario

			monedas = monedas + 1;

			// actualizar el componente text

			contadorCoins.text = monedas.ToString ();

			GameObject.Destroy (coll.gameObject);

		}

		if (coll.gameObject.tag == "Life") {

			life = life + 1;



			contadorLife.text = life.ToString ();

			GameObject.Destroy (coll.gameObject);

		}

	}


	// Update is called once per frame
	void Update () {

		//movimiento a la derecha
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.gameObject.transform.Translate (speed, 0, 0);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.gameObject.transform.Translate (-speed, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {

			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 10, ForceMode2D.Impulse);

		}

	}
}
