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
        //文件路径
        string filePath = Application.streamingAssetsPath + "/" + fileName + ".csv";
        //检验文件夹是否存子啊
        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            //不存在的话创建文件夹
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }
        StreamWriter sw = new StreamWriter(filePath);
        sw.WriteLine("ID,Name,Author");
        //存储内容
        for (int i = 0; i < books.Count; i++)
        {
            //写入数据
            sw.WriteLine($"{books[i].id},{books[i].name},{books[i].author}");
        }
        //推送到流文件中
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