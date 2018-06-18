using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	public void Game(string name)
    {
        Application.LoadLevel(name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
