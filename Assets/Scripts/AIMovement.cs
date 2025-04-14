using UnityEngine;

public class AIMove : MonoBehaviour
{
	public float speed;
	public Transform Top;
	public Transform Bottom;

	private float y;

	private void Start()
	{
		y = 0;
	}

	void FixedUpdate()
	{
		if (Mathf.Abs(transform.position.y - y) > 0.1)
		{
			int direction = y - transform.position.y > 0 ? 1 : -1;
			float newY = transform.position.y + speed * Time.fixedDeltaTime * direction;
			transform.position = new Vector2(transform.position.x, Mathf.Clamp(newY, Bottom.position.y + (transform.localScale.y / 2), Top.position.y - (transform.localScale.y / 2)));
		}
	}

	public void UpdateDestination(float y)
	{
		this.y = y;
	}
}
