using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;  // ссылка на компонент

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();  // находим и получаем ссылку на "соседний" компонент объекта
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)
            || Input.GetKeyDown(KeyCode.W)
            || Input.GetKeyDown(KeyCode.UpArrow)
            ) 
        {
            rb.AddForce(Vector2.up * 300f);
        }
    }
}
