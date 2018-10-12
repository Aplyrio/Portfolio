using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {

    private Vector3 Eu;

	// Use this for initialization
	void Start () {

        Eu = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		


	}

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Tiradente")
        {
            transform.position = new Vector3(-33, 10, -1);
        }

        if (coll.gameObject.tag == "Bola")
        {
            transform.position = Eu;
        }

        if (coll.gameObject.tag == "Paqueta")
        {
            transform.position = Eu;
        }

    }


}
