using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Collectable
{
    public int healthPower = 5;
    private Color textColor = new Color(0.73f, 0.26f, 0.27f);

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GameManager.instance.player.SetHealth(healthPower);
            GameManager.instance.ShowText("+" + healthPower + " health!", 25, textColor, transform.position, Vector3.up * 25, 1.5f);
            Destroy(gameObject);
        }
    }
}
