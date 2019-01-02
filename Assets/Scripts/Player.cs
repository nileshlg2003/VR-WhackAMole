using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("I am Here");
    }

    // Update is called once per frame
    void Update()
    {

		RaycastHit hit;

		if (Input.GetKeyDown("space"))
		{
			if (Physics.Raycast(transform.position, transform.forward, out hit))
			{

				if (hit.transform.GetComponent<mole>() != null) {
					Debug.Log("Hit a Mole");
				}
			}
		}

	}
}
