using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public int maxHP = 10;
    public int currentHP;
    public static int Score;
    public Text score_text;

    private void Start()
    {
        currentHP = maxHP;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet") )
        {
            if (Time.time > 19)
            {
                currentHP -= 1;
            }
            
            Destroy(collision.gameObject); // Xóa đạn sau khi va chạm
            if (currentHP <= 0)
            {
                Destroy(gameObject); // Xóa enemy nếu HP <= 0
                Score++;
                score_text.text = "Score: " + Score.ToString();
            }
        }
    }
}