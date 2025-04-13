using UnityEngine;

public class BallMovement : MonoBehaviour
{
	public float speed;
	public float speedIncrement;

	private Rigidbody2D rb;
	private int horizontalDirection;
	private int verticalDirection;
	private Vector2 movement;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

		System.Random random = new();
		int randDir = random.Next(1, 2);
		horizontalDirection = randDir == 1 ? 1 : -1;

		randDir = random.Next(1, 2);
		verticalDirection = randDir == 1 ? 1 : -1;
	}

	private void Update()
	{
		movement.x = horizontalDirection * speed;
		movement.y = verticalDirection * speed;
	}

	void FixedUpdate()
	{
		rb.MovePosition(rb.position + (speed * Time.fixedDeltaTime * movement));
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.transform.CompareTag("Roof"))
		{
			verticalDirection *= -1;
		}
		else
		{
			horizontalDirection *= -1;
			speed += speedIncrement;
		}
	}
}
