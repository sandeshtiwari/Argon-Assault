using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        if(numMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        // destroy ourselves
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
   
}
