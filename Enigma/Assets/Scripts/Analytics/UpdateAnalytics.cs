using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class UpdateAnalytics : MonoBehaviour
{
    // [SerializeField] private string URL;
    private string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSeiu3C-xejSlgdM7f0EvU4mFiRAZ-qBfQVnLKod3nWBHfkqAw/formResponse";
    private long _sessionID;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        // Assign sessionID to identify playtests
        _sessionID = System.DateTime.Now.Ticks;
    }

    public void Send()
    {
        StartCoroutine(Post(_sessionID.ToString(), Metrics.moves.ToString(), Metrics.level.ToString()));
    }

    private IEnumerator Post(string sessionID, string moves, string level)
    {
        // Create form and enter responses
        WWWForm form = new WWWForm();
        form.AddField("entry.1129034070", sessionID);
        form.AddField("entry.712653030", level);
        form.AddField("entry.338609209", moves);

        // Send POST request and verify the result
        using (UnityWebRequest www = UnityWebRequest.Post(URL, form))
        {
            yield return www.SendWebRequest();

            if(www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete");
            }
        }
    }
}
