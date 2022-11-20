using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PUPaddleCepatController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Collider2D paddleKanan;
    public Collider2D paddleKiri;

    public float spawnDuration;
    public int PUSpeedPaddle;
    public float timer;

    private void Start()
    {
        timer = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnDuration)
        {
            manager.RemovePowerUp(gameObject);
            timer -= spawnDuration;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddleKanan.GetComponent<PaddleController>().ActivatePUPaddleSpeedUp(PUSpeedPaddle);
            paddleKiri.GetComponent<PaddleController>().ActivatePUPaddleSpeedUp(PUSpeedPaddle);
            manager.RemovePowerUp(gameObject);
        }
    }
}