using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListandScore : MonoBehaviour {

    private static ListandScore instance;

    public Text userID;
    public Text score;

    public Text Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    public Text UserID
    {
        get
        {
            return userID;
        }

        set
        {
            userID = value;
        }
    }

    public static ListandScore Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ListandScore>();
            }

            return instance;
        }

        set
        {
            instance = value;
        }

    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
