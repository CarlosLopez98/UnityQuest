using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Collidable
{
    public Sprite openDoor;
    public bool open = false;

    private AudioSource sound;

    protected override void Start()
    {
        base.Start();
        sound = GetComponent<AudioSource>();
    }

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player" && !open)
        {
            open = true;
            GetComponent<SpriteRenderer>().sprite = openDoor;

            // Play sound
            sound.Play();
            Debug.Log("Door open");
        }
    }
}
