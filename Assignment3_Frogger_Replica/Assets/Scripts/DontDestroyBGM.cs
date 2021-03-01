using UnityEngine.SceneManagement;
using UnityEngine;

public class DontDestroyBGM : MonoBehaviour
{
    private static DontDestroyBGM _instance;

    private void Awake()
    {
        //if we don't have an [_instance] set yet
        if (!_instance)
            setInstance();
        //otherwise, if we do, kill this thing
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(transform.gameObject);
    }

    public void setInstance()
    {
        _instance = this;
    }
}
