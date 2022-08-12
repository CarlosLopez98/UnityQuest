using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : Collidable
{
    // public string[] sceneNames;
    public string sceneName;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            GameManager.instance.SaveState();
            // Teleport the player
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);

            // To random scene
            // string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
            // UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}
