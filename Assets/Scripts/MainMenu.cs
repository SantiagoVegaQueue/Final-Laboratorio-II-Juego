﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void salir()
    {
        Application.Quit();
    }
}
