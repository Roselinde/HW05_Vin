using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Net;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class LeaderBoardScript : MonoBehaviour
{

    public GameObject showListUI;
    public GameObject listUserID;
    public GameObject parent;

    private GameObject useridText;



    public string URL = "http://localhost:8081/user/id";

    // Use this for initialization
    void Start ()
    {


       
    }
	
	// Update is called once per frame
	void Update ()
    {
       
	}
    public void ShowList()
    {
        try
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            string responseBody = new StreamReader(stream).ReadToEnd();


            UserID[] userIDs = JsonConvert.DeserializeObject<UserID[]>(responseBody);
            for (int i = 0; i < userIDs.Length; i++)
            {
                GameObject listID = Instantiate(listUserID) as GameObject;

                listID.transform.SetParent(showListUI.transform, false);
                listID.GetComponent<ListandScore>().userID.text = "" + userIDs[i].userID;
                listID.GetComponent<ListandScore>().score.text = "" + userIDs[i].score;        
  
            }          

        }
        catch (WebException ex)
        {

        }

    }

    public void DelList()
    {
        foreach(Transform child in parent.transform)
        {
            Destroy(child.gameObject);

        }
    }
}
