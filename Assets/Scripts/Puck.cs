using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    public float boostSpeed = 1;
    private Rigidbody2D rb;
    private bool starting = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (!starting)
        {
            StartCoroutine(BoostPuck());
        }
    }

    private int GetRandomDirection()
    {
        int rand = Random.Range(0, 2);
        if (rand == 0) return 1;
        return -1;
    }

    private IEnumerator BoostPuck()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1;
        rb.velocity = new Vector2(boostSpeed * GetRandomDirection(), 0);
        starting = true;
    }

    public void ResetSelf()
    {
        transform.position = Vector2.zero;
        rb.velocity = Vector2.zero;
        starting = false;
    }
}
