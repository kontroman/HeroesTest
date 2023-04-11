using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroPicker : MonoBehaviour
{
    public static HeroPicker Instance { get; private set; }

    public List<Hero> Heroes = new List<Hero>();    //Список всех доступных героев

    public Hero currentHero;    //Текущий выбранный герой
    private AsyncOperation sceneAsync;

    private void Awake()
    {
        if (Instance != null)
            return;
        else { Instance = this; DontDestroyOnLoad(gameObject); }

        currentHero = Heroes[0];
    }

    //Тыкнули по кнопке и выбрали нового героя
    public void SelectNewHero(Hero hero)
    {
        if (currentHero != null && currentHero != hero)
            currentHero.HeroDePicked();

        currentHero = hero;

        hero.HeroPicked();
    }

    public void ReturnFromTavern()
    {
        StartCoroutine(LoadScene(0));
    }

    IEnumerator LoadScene(int index)
    {
        AsyncOperation scene = SceneManager.LoadSceneAsync(index, LoadSceneMode.Additive);
        scene.allowSceneActivation = false;
        sceneAsync = scene;

        while (scene.progress < 0.9f)
        {
            Debug.Log("Loading scene " + " [][] Progress: " + scene.progress);
            yield return null;
        }

        OnFinishedLoadingAllScene();
    }

    private void EnableScene(int index)
    {
        sceneAsync.allowSceneActivation = true;

        Scene sceneToLoad = SceneManager.GetSceneByBuildIndex(index);

        if (sceneToLoad.IsValid())
        {
            Debug.Log("Scene is Valid");
            SceneManager.MoveGameObjectToScene(currentHero.gameObject, sceneToLoad);
            SceneManager.SetActiveScene(sceneToLoad);
        }
    }

    void OnFinishedLoadingAllScene()
    {
        EnableScene(0);
    }
}
