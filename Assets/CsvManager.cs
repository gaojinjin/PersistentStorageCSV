using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CsvManager : MonoBehaviour
{
    public string fileName;
    public List<Book> books = new List<Book>();
    void Start()
    {
        //�ļ�·��
        string filePath = Application.streamingAssetsPath + "/" + fileName + ".csv";
        //�����ļ����Ƿ���Ӱ�
        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            //�����ڵĻ������ļ���
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }
        StreamWriter sw = new StreamWriter(filePath);
        sw.WriteLine("ID,Name,Author");
        //�洢����
        for (int i = 0; i < books.Count; i++)
        {
            //д������
            sw.WriteLine($"{books[i].id},{books[i].name},{books[i].author}");
        }
        //���͵����ļ���
        sw.Flush();
        sw.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class Book {
    public int id;
    public string name;
    public string author;
}