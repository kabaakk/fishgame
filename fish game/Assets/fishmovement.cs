using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishmovement : MonoBehaviour
{
    public float speed;
    float rast;
    int skor = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        if (transform.position.y < -5)
        {
            rast = Random.Range(-8f, 8f);
            transform.position = new Vector3(rast, 10, -3);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gemi")
        {
            skor += 1;
            rast = Random.Range(-8f, 8f);
            transform.position = new Vector3(rast, 6, -3);
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.white;
        GUI.Box(new Rect(20, 20, 100, 50), skor.ToString());
    }
}
