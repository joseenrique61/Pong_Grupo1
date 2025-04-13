using UnityEngine;

public class AIMove : MonoBehaviour
{
	public Transform Ball;
	public Transform Top;
	public Transform Bottom;

	void FixedUpdate()
	{
		transform.position = new Vector2(transform.position.x, Mathf.Clamp(Ball.position.y, Bottom.position.y + transform.localScale.y / 2, Top.position.y - transform.localScale.y / 2));
	}
}
