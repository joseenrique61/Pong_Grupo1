using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
	public Transform Top;
	public Transform Bottom;

	private void FixedUpdate()
	{
		float newY = transform.position.y + Input.GetAxisRaw("Vertical") * speed * Time.fixedDeltaTime;
		transform.position = new Vector2(transform.position.x, Mathf.Clamp(newY, Bottom.position.y + (transform.localScale.y / 2), Top.position.y - (transform.localScale.y / 2)));
	}
}
