using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataController : MonoBehaviour
{

    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }

    static DataController _instance;
    public static DataController Instance                                                   //�ش� ��ũ��Ʈ�� ��𿡼��� �ҷ��� �� �ְԲ� �ϴ� �Լ� 
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "DataController";
                _instance = _container.AddComponent(typeof(DataController)) as DataController;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    public GameData _gameData;
    public GameData gameData
    {
        get
        {
            if (_gameData == null)
            {

                LoadGameData();
                //UnityEngine.Debug.Log("������ ��");
                ToGameJson();
            }
            return _gameData;
        }
    }

    public void LoadGameData()                                                                                                                  //���� ������ �ҷ�����
    {
        string filePath = Path.Combine(Application.dataPath, "GameDataManagement/gameData.json");


        if (File.Exists(filePath))
        {
            print(filePath);
            //UnityEngine.Debug.Log("�ҷ����� ����!");
            string FromJsonData = File.ReadAllText(filePath);
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);
        }
        else
        {
            //UnityEngine.Debug.Log("�� ���� ����!");
            ToGameJson();

        }
    }
    System.IO.StreamWriter SW = null;


    [ContextMenu("To Game Json")]
    public void ToGameJson()
    {
        string jsonData = JsonUtility.ToJson(gameData);
        string path = Path.Combine(Application.dataPath, "GameDataManagement/gameData.json");
        File.WriteAllText(path, jsonData);
    }

    void OnApplicationQuit()
    {
        ToGameJson();
        //UnityEngine.Debug.Log("����Ϸ�����");
    }

    void Start()
    {
        //Debug.Log("������ ���ʽ���" + PlayerPrefs.HasKey("playnumber"));
        if (PlayerPrefs.HasKey("key") == true)
        {
            if (gameObject.name == "DataControllerF")
                GameObject.Find("DataControllerF").SetActive(false);
        }

        if (PlayerPrefs.HasKey("key") == false) // ���ʽ����̸�
        {
            PlayerPrefs.SetInt("key", PlayerPrefs.GetInt("key", 0)); //���ʽ���� ���� ����...
            //Debug.Log("���ʽ���");

            ToGameJson();

            if (gameObject.name == "DataControllerF")
                GameObject.Find("DataControllerF").SetActive(false);
        }


    }

    IEnumerator SaveGameData()
    {
        while (true)
        {
            string path = Path.Combine(Application.dataPath, "GameDataManagement/gameData.json");
            File.WriteAllText(path, JsonUtility.ToJson(gameData));
            //UnityEngine.Debug.Log("�ڷ�ƾ ���ӵ����� ����");
            try
            {
                SW = new System.IO.StreamWriter(path);
            }
            catch (Exception exp)
            {
                UnityEngine.Debug.Log(exp);
            }
            finally
            {
                if (SW != null)
                {
                    SW.Close();
                }
            }



            yield return new WaitForSeconds(0.5f);
        }

    }

    [System.Serializable]
    public class GameData
    {
        public int clues = 0;
        public int jump = 0;

        public bool isMove = false;

        public Vector3 cameraOffset;

        public int Ep1_obj1 = 0;
        public int Ep1_obj2 = 0;

        public int Ep1_Clear = 0;

        public int Ep1_obj1Order = 0;
        public int Ep1_obj2Order = 0;
    }
}