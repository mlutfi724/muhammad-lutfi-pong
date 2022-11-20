using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private float boundary = 3.4f;
    public Vector2 DefaultScale;
    private Rigidbody2D rig;

    public float timerPU;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.transform.localScale = DefaultScale;
        timerPU = 0f;
    }

    //private void Update()
    //{
    //    // Deklarasi variabel position
    //    // jika tidak ada input maka berhenti/zero
    //    Vector2 movement = Vector2.zero;

    //    // ambil input
    //    if (Input.GetKey(upKey))
    //    {
    //        // gerakan ke atas
    //        //speed = new Vector2(0, 1f);
    //        movement = Vector2.up * speed;
    //    }
    //    else if (Input.GetKey(downKey))
    //    {
    //        // gerakan ke bawah
    //        //speed = new Vector2(0, -1f);
    //        movement = Vector2.down * speed;
    //    }
    //    // gerakan objek pake input
    //    transform.Translate(movement * Time.deltaTime);
    //}

    private void Update()
    {
        MoveObject(GetInput());
        timerPU -= Time.deltaTime;
        if (timerPU <= 0)
        {
            resetPaddle();
        }
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            if (gameObject.transform.position.y < boundary)
            {
                Debug.Log("Kecepatan Paddle: " + speed);
                return Vector2.up * speed;
            }
        }
        else if (Input.GetKey(downKey))
        {
            if (gameObject.transform.position.y > -boundary)
            {
                Debug.Log("Kecepatan Paddle: " + speed);
                return Vector2.down * speed;
            }
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        //transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    }

    public void resetPaddle()
    {
        rig.transform.localScale = DefaultScale;
        boundary = 3.4f;
        speed = 10;
    }

    public void ActivatePUPaddlePanjang(float PowerUpScale)
    {
        timerPU = 5f;
        rig.transform.localScale = new Vector2(DefaultScale.x, DefaultScale.y * PowerUpScale);
        boundary /= 1.5f;
    }

    public void ActivatePUPaddleSpeedUp(int PUSpeedPaddle)
    {
        timerPU = 5f;
        speed *= PUSpeedPaddle;
    }
}