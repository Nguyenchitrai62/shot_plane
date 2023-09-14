using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butlet : MonoBehaviour
{
    public float toc_do = 0.02f;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 12f)
        {
            Destroy(gameObject);
        }
        transform.Translate(new Vector2(0,toc_do));
    }
}
