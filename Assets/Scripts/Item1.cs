using UnityEngine;
using System.Collections;

public class Item1 : MonoBehaviour
{
	public GameObject leaf;
	public GameObject projectile;
	Vector2 direction;

	float currentTime = 0.0f;
	public float fireRate = 0.6f;

	// Update is called once per frame
	void Update()
	{
		currentTime += Time.deltaTime;

		if (currentTime > fireRate && Input.GetKey(KeyCode.Alpha1))
		{
			currentTime = 0f;
			leaf = GameObject.FindGameObjectWithTag ("leaf");

			GameObject instance;
			instance = Instantiate(projectile, leaf.transform.position, leaf.transform.rotation) as GameObject;
		}
	}
}
