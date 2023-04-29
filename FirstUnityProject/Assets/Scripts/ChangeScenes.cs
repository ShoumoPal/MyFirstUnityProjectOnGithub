using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public Button sceneOne;
    public Button sceneTwo;
    public Button sceneThree;
    public string one;
    public string two;
    public string three;

    private void SceneOne()
    {
        var scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
    private void SceneTwo()
    {
        SceneManager.LoadScene(two, LoadSceneMode.Single);
    }
    private void SceneThree()
    {
        SceneManager.LoadScene(three, LoadSceneMode.Single);
    }
    // Start is called before the first frame update
    void Start()
    {
        sceneOne.onClick.AddListener(SceneOne);
        sceneTwo.onClick.AddListener(SceneTwo);
        sceneThree.onClick.AddListener(SceneThree);
    }


}
