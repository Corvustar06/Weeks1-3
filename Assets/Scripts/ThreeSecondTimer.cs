using UnityEngine;

public class ThreeSecondTimer : MonoBehaviour
{
    float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;

        t += Time.deltaTime;
        if (t > 3)
        {
            t = 0;
            newPos.x = Random.Range(-10, 10);
            newPos.y = Random.Range(-5, 5);
            transform.position = newPos;
        }
    }
}
