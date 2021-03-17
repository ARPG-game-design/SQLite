using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System;
using System.Data;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int a;
        // 資料庫檔案的具體路徑，有的是.sqlite/.db
        string path = "data source =" + Application.streamingAssetsPath + "/" + "database0117.db";

        SQLite sql = new SQLite(path);





        SqliteDataReader reader1 = sql.InsertData("FirstTable", new string[] { "name", "score" }, new object[] { "'Aa'", 99 }); //資料庫的字串資料必須使用單引號框起來
        // 讀取到的資訊使用之後需要關閉
        //SqliteDataReader reader1 = sql.SelectData("FirstTable", new string[] { "score" });
        //Debug.Log(reader1);
        reader1.Close();

        SqliteDataReader reader2 = sql.DeleteData("FirstTable", new string[] { "name = 'Bb'" });
        reader2.Close();

        //SqliteDataReader reader3 = sql.UpdateData("FirstTable", new string[] { "'Aa'", "50" }, new string[] { "'Aa'" });
        //reader3.Close();



        sql.CloseDataBase();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
