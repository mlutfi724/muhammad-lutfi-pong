using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using UnityEngine;

public class PUPaddlePanjangController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Collider2D paddleKanan;
    public Collider2D paddleKiri;

    public float spawnDuration;
    public float PowerUpScale;

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
            paddleKanan.GetComponent<PaddleController>().ActivatePUPaddlePanjang(PowerUpScale);
            paddleKiri.GetComponent<PaddleController>().ActivatePUPaddlePanjang(PowerUpScale);
            manager.RemovePowerUp(gameObject);
        }
    }
}