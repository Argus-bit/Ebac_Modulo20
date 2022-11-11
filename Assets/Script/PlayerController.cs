using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public string tagToCheckEnemy = "Enemy";
	public float speed = 1f;
	private bool _canRun;
	private Vector3 _pos;
	public Transform target;
	public float lerpSpeed = 1f;
	public GameObject endgame;
	public void StartRun()
	{
		_canRun = true;
	}
	void Update()
	{
		if (!_canRun) return;
		_pos = target.position;
		_pos.y = target.position.y;
		_pos.z = target.position.z;
		transform.position = Vector3.Lerp(transform.position, _pos, lerpSpeed * Time.deltaTime);
		transform.Translate(transform.forward * speed * Time.deltaTime);
	}
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.transform.CompareTag(tagToCheckEnemy))
		{
			EndGame();
		}
	}
	private void EndGame()
    {
		_canRun = false;
		endgame.SetActive(true);

	}
}