using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Control : MonoBehaviour
{
    public float tocDo = 5f; // Tốc độ di chuyển của vật thể
    public GameObject Butlet; // Prefab của vật thể đạn
    public float chu_ki = 0.1f;
    private float fire_time = 0f;
 

    private void Update()
    {
        float diChuyenX = Input.GetAxis("Horizontal"); // Lấy giá trị đầu vào từ các phím A và D (trái: -1, phải: 1, không nhấn: 0)
        float diChuyenY = Input.GetAxis("Vertical"); // Lấy giá trị đầu vào từ các phím W và S (trên: 1, dưới: -1, không nhấn: 0)

        Vector3 diChuyen = new Vector3(diChuyenX, diChuyenY, 0) * tocDo * Time.deltaTime; // Xác định vector di chuyển dựa trên tốc độ và thời gian

        transform.Translate(diChuyen); // Di chuyển vật thể

        // Kiểm tra nếu đủ thời gian để bắn đạn
        if (Time.time - fire_time > chu_ki)
        {
            Instantiate(Butlet, transform.position + new Vector3(0,0.5f,0), Quaternion.identity);
            fire_time = Time.time;
        }
    }
}
