using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Mover
{
    float x, y;
    private SpriteRenderer spriteRenderer;

    protected override void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();

        DontDestroyOnLoad(gameObject);
    }

    private void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        UpdateMotor(new Vector3(x, y, 0));
    }

    public void SwapSprite(int selection)
    {
        spriteRenderer.sprite = GameManager.instance.playerSprites[selection];
    }

    public void OnLevelUp()
    {
        maxHitpoint += Mathf.RoundToInt(Mathf.Sqrt(GameManager.instance.GetCurrentLevel()));
        hitpoint = maxHitpoint;
    }

    public void SetLevel(int level)
    {
        for (int i=1; i<level; i++)
            OnLevelUp();
    }

    public void SetHealth(int power)
    {
        hitpoint += power;
        if (hitpoint > maxHitpoint)
            hitpoint = maxHitpoint;
    }
}