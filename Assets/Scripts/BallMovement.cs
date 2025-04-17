using UnityEngine;
using UnityEngine.Events;

public class BallMovement : MonoBehaviour
{
	public float speed;
	public float speedIncrement;

	public Transform AI;
	public Score score;
	public int actualScore;

	public UnityEvent<float> DirectionUpdated;

	private Rigidbody2D rb;
	private int horizontalDirection;
	private int verticalDirection;
	private Vector2 movement;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

		SetStartDirection();

		actualScore = 0;

		DirectionUpdated.Invoke(CalculateYDestination());
	}

	private void SetStartDirection()
	{
		System.Random random = new();
		int randDir = random.Next(2);
		horizontalDirection = randDir == 1 ? 1 : -1;

		randDir = random.Next(2);
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

		if (collision.collider.transform.CompareTag("Player"))
		{
			actualScore++;
			score.AddPoints(actualScore);
			Debug.Log(actualScore);
		}

		DirectionUpdated.Invoke(CalculateYDestination());
	}

	private float CalculateYDestination()
	{
		return verticalDirection * (-1 * AI.transform.position.x - Mathf.Abs(transform.position.x)) + transform.position.y;
	}
}
