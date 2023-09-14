using UnityEngine;

public class e0 : MonoBehaviour
{
    public Vector2 target = new Vector2(-5f, 5f);
    public float time_start = 5;

    private float movementTime = 500f;
    private float elapsedTime = 0f;

    private void Update()
    {
        if (Time.time > time_start && Time.time < time_start + 4)
        {
            elapsedTime += Time.deltaTime;
            transform.position = Vector2.Lerp(transform.position, target, elapsedTime / movementTime);
        } 
    }
}