using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class SaveNLoad : MonoBehaviour
{

    [System.Serializable]
    public class Data
    {
        public float playerX;
        public float playerY;
        public float playerZ;

        //public List<int> Inventory;

        public string mapName;
        public string sceneName;

        public List<bool> swList;
        public List<string> swNameList;
        public List<string> varNameList;
        public List<float> varNumberList;
    }

    private PlayerMove thePlayer;
    private JoystickTest thePlayer2;
    private DatabaseManager theDatabase;
    //private Inventory theInven;

    public Data data;

    private Vector3 vector;

    public void CallSave()
    {
        theDatabase = FindObjectOfType<DatabaseManager>();
        thePlayer = FindObjectOfType<PlayerMove>();
        //theInven = FindObjectOfType<Inventory>();

        data.playerX = thePlayer.transform.position.x;
        data.playerY = thePlayer.transform.position.y;
        data.playerZ = thePlayer.transform.position.z;

        data.mapName = thePlayer.currentMapName;
        //data.sceneName = thePlayer.currentSceneName; 

        Debug.Log("데이터 정리");

        
        /*for(int i = 0; i < theDatabase.varName.Length; i++)
        {
            data.varNameList.Add(theDatabase.varName[i]);
            data.varNumberList.Add(theDatabase.var[i]);
        }

        for (int i = 0; i < theDatabase.varName.Length; i++)
        {
            data.swNameList.Add(theDatabase.switchName[i]);
            data.swList.Add(theDatabase.switches[i]);
        }*/

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.dataPath + "/SavaFile.sav");

        bf.Serialize(file, data);
        file.Close();

        Debug.Log(Application.dataPath + "의 위치에 저장 완료");
    }

    public void CallLoad()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.dataPath + "/SavaFile.sav", FileMode.Open);

        if (file != null && file.Length > 0)
        {
            data = (Data)bf.Deserialize(file);

            theDatabase = FindObjectOfType<DatabaseManager>();
            thePlayer = FindObjectOfType<PlayerMove>();
            //theInven = FindObjectOfType<Inventory>();

            thePlayer.currentMapName = data.mapName;
            //thePlayer.currentSceneName = data.sceneName;

            vector.Set(data.playerX, data.playerY, data.playerZ);
            thePlayer.transform.position = vector;

            /*theDatabase.var = data.varNumberList.ToArray();
            theDatabase.varName = data.varNameList.ToArray();
            theDatabase.switches = data.swList.ToArray();
            theDatabase.switchName = data.swNameList.ToArray();*/

            //인벤토리 구현 X 

            GameManager theGM = FindObjectOfType<GameManager>();
            theGM.LoadStart(); 

            SceneManager.LoadScene(data.sceneName);
        }
        else
            Debug.Log("저장된 세이브 파일이 없습니다.");

        file.Close();

        

    }
}
//mapName, sceneName 관련 변수에서 장소에 관한 오류 속출중. 지금은 이 상태가 위치나마 저장 가능한 상태.