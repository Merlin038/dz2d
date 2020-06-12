using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using Object = UnityEngine.Object;

public class Test : MonoBehaviour
{
    public string rpcname;
	// Use this for initialization
	void Start ()
    {
//        Read1("D:/TestStr/str.txt");
//        Read2("D:/TestStr/str.txt");
        string str = "世博";
        Int16 i = 5556;
        i.GetType();
        print("3333==="+i.GetType());
    }
	
    public void Read1(string path)
    {
        StreamReader sr = new StreamReader(path,Encoding.UTF8);
        string line;
        string strtemp = "";
        string strtype = "";
        string strbool = "";
        string strannotation = "";
        
        string strone = "";
        string strall = "";
        while ((line = sr.ReadLine()) != null)
        {
            string str = line.ToString();
            if (str.Contains("optional"))
            {
                strbool = "否";
            }
            else
            {
                strbool = "是"; 
            }
            string[] arr1 = str.Split('=');
            string[] arra = arr1[0].Split(' ');
            //print("wwwww==="+arra.Length);

            List<string> list = new List<string>();
            for (int k = 0; k < arra.Length;k++)
            {
                if (arra[k]!= String.Empty)
                {
                    arra[k] = arra[k].Trim();
                    list.Add(arra[k]); 
                }
            }
//            print("0000==="+arra[0]);
//            print("1111==="+arra[1]);
//            print("222==="+arra[2]);
//            print("333==="+arra[3]);
//            print("444==="+arra[4]);
//            print("555==="+arra[5]);
//            print("666==="+arra[6]);
//            print("777==="+arra[7]);

//            strtemp = arra[arra.Length-2];
//            strtype = arra[arra.Length-3];

            strtemp = list[2];
            strtype = list[1];

            string[] arr2 = str.Split(';');
            strannotation = arr2[1].Trim().Replace("//","");

            strone = "|" + strtemp + "|" + strbool + "|" + strtype + "|" + strannotation+ "|";
            strall = strall + "\n" + strone;
        }
        print(strall);
    }
    
    public void Read2(string path)
    {
        StreamReader sr = new StreamReader(path,Encoding.UTF8);
        string line;
        string strtemp = "";
        string strtype = "";
        string strbool = "";
        string strannotation = "";
        
        string strone = "";
        string strall = "";
        while ((line = sr.ReadLine()) != null)
        {
            string str = line.ToString();
            if (str.Contains("optional"))
            {
                strbool = "否";
            }
            else
            {
                strbool = "是"; 
            }
            string[] arr1 = str.Split('=');
            string[] arra = arr1[0].Split(' ');
//            print("wwwww==="+arra.Length);
//            print("0000==="+arra[0]);
//            print("1111==="+arra[1]);
//            print("222==="+arra[2]);
//            print("333==="+arra[3]);
//            print("444==="+arra[4]);
//            print("555==="+arra[5]);
//            print("666==="+arra[6]);
//            print("777==="+arra[7]);

            List<string> list = new List<string>();
            for (int k = 0; k < arra.Length;k++)
            {
//                print("8888888888888888==="+arra[k]);
                
                if (arra[k]!= String.Empty)
                {
                    arra[k] = arra[k].Trim();
                    list.Add(arra[k]); 
                }
            }
//            print("0000==="+arra[0]);
//            print("1111==="+arra[1]);
//            print("222==="+arra[2]);
//            print("333==="+arra[3]);
//            print("444==="+arra[4]);
//            print("555==="+arra[5]);
//            print("666==="+arra[6]);
//            print("777==="+arra[7]);

//            strtemp = arra[arra.Length-2];
//            strtype = arra[arra.Length-3];

            strtemp = list[2];
            strtype = list[1];

            string[] arr2 = str.Split(';');
            strannotation = arr2[1].Trim().Replace("//","");

            strone = "|" + strtemp + "|" + strtype + "|" + strbool + "| |" + strannotation+ "|";
            strall = strall + "\n" + strone;
        }
        print(strall);
    }

    public string GetStr(string rpcname)
    {
        
        string str ="**简要描述：** "+"\n"+"- " + rpcname + "\n" +"**请求URL：** " + "\n" +"**请求方式：**"
            + "\n" +"**参数：**"+ "\n" +"|参数名|必选|类型|说明|"+ "\n" +"|:----    |:---|:----- |-----   |"
            + "\n" +"**参数：**"
    }
    
}

