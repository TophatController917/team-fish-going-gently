using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 10;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 inputDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += (Vector3)inputDir * moveSpeed * Time.fixedDeltaTime;
    }
}
