using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Grass() //load grassy level
    {
        SceneManager.LoadScene(1);
    }
    public void Sand() //load sand level
    {
        SceneManager.LoadScene(2);
    }
    public void Space() //load space level
    {
        SceneManager.LoadScene(3);
    }
}
