using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EBAC.Core.Singleton;

public class PlayerController : Singleton<PlayerController>
{
	[Header("Lerp")]
	public Transform target;
	public float lerpSpeed = 1f;

	public float speed = 1f;

	public string tagToCheckEnemy = "Enemy";
	public string tagToCheckEndLine = "EndLine";

	public GameObject endgame;

	[Header("Animation")]
	public AnimatorManager animatorManager;

	private bool _canRun;
	private Vector3 _pos;
	public float _currentSpeed;
	public bool invencible = true;
	private Vector3 _startPosition;
	public GameObject coinCollactable;
    private void Start()
    {
		_startPosition = transform.position;
		ResetSpeed();
    }
    void Update()
	{
		if (!_canRun) return;
		_pos = target.position;
		_pos.y = target.position.y;
		_pos.z = target.position.z;
		transform.position = Vector3.Lerp(transform.position, _pos, lerpSpeed * Time.deltaTime);
		transform.Translate(transform.forward * _currentSpeed * Time.deltaTime);
	}
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.transform.CompareTag(tagToCheckEnemy))
		{
			if(!invencible) EndGame(AnimatorManager.AnimationType.DEAD);
		}
		if (collision.transform.CompareTag(tagToCheckEndLine))
		{
			EndGame(AnimatorManager.AnimationType.IDLE);
		}
	}
	private void EndGame(AnimatorManager.AnimationType animationType = AnimatorManager.AnimationType.IDLE)
    {
		_canRun = false;
		endgame.SetActive(true);
		animatorManager.Play(animationType);

	}
	private void MoveBack(Transform t)
    {
		
    }
	public void StartRun()
	{
		_canRun = true;
		animatorManager.Play(AnimatorManager.AnimationType.RUN);
	}

	#region POWERUPS
	public void PowerUpSpeedUp(float f)
    {
		_currentSpeed = f;
    }
	public void SetInvencible(bool b = true)
    {
		invencible = b;
    }
	public void ResetSpeed()
	{
		_currentSpeed = speed;
	}
	#endregion
	public void ChangeHeight(float amount, float duration)
    {
		var p = transform.position;
		p.y = amount;
		transform.position = p;
		Invoke(nameof(ResetHeight), duration);
    }
    public void ResetHeight()
    {
		var p = transform.position;
		p.y = _startPosition.y;
		transform.position = p;
    }
	public void ChangeCoinCollactorSize(float amount)
    {
		coinCollactable.transform.localScale = Vector3.one * amount;
    }
}