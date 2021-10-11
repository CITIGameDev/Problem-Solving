using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public Transform[] spawn;
	public bool isspawn = true;
	public GameObject squares;
	public Transform titik;
	void Update()
	{
		titik = spawn[Random.Range(0, spawn.Length)];
		if (isspawn == true)
		{
			Instantiate(squares, titik);
			isspawn = false;
			StartCoroutine(ToSpawnTrue());
		}
	}
	IEnumerator ToSpawnTrue()
	{
		yield return new WaitForSeconds(2);
		isspawn = true;
	}
}