using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapper : MonoBehaviour
{
    //vowels button triggers scene change to the first lesson
    public void GoToSceneTwo()
    {
        SceneManager.LoadScene("Lesson Vowels");


    }
}