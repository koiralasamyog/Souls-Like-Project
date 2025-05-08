using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSaveGameManager : MonoBehaviour
{
    public static WorldSaveGameManager instance;
    [SerializeField] int buildNumber = 1;

    private void Awake()
    {
        if (instance == null) 
        { 
            instance = this; 
        }
        else
        {
            Destroy(instance);
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public IEnumerator LoadNewGame()
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(buildNumber);

        yield return null;
    }
}
