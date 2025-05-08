using UnityEngine;
using UnityEngine.SceneManagement;

public class NG2CS : MonoBehaviour
{
    public void OnClickSceneChangeButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
