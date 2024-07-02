using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusShoot : MonoBehaviour
{
	public GameObject	boom;

	public void shoot() {
		GameObject	cpy;

		cpy = Instantiate(boom, transform.position, transform.rotation);
		cpy.gameObject.transform.parent = transform;
	}
}
