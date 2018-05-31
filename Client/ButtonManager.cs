using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public GameObject pageLog;
    public GameObject pageCre;
    public GameObject pageLea;

    public LeaderBoardScript ldb;
	public void LogToCreate()
    {
        pageLog.SetActive(false);
        pageCre.SetActive(true);

    }

    public  void CreateToLog()
    {
        pageCre.SetActive(false);
        pageLog.SetActive(true);

    }
    public void LogToBoard()
    {
        pageLog.SetActive(false);
        pageLea.SetActive(true);
    }
    public void BoardToLog()
    {
        pageLea.SetActive(false);
        pageLog.SetActive(true);
        ldb.DelList();

    }
}
