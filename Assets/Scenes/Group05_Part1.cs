using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Group05_Part1 : MonoBehaviour
{

    public TextAsset textFile;

    public class Customer
    {
        public long arrivalTime_;
        public long serviceTime_;
         

        // Constructor
        public Customer (long arrivalTime, long serviceTime )
        {
            arrivalTime_ = arrivalTime;
            serviceTime_ = serviceTime;
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        string text = textFile.text;  //this is the content as string
        byte[] byteText = textFile.bytes;  //this is the content as byte array
        //Debug.Log("Testing" + text);

        Customer[] C = new Customer[500];

        int skipLine = 0;
        
        string[] words = text.Split('\n');
        //System.Console.WriteLine($"<{words.Length}> words in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
            Debug.Log(word);

            System.Console.WriteLine($"<{word}>");

            

          if(skipLine >= 1)
          {
            string[] words2 = word.Split('\t');
            string divider = " ";
            int newLineInt = 0;
           
            foreach (var word2 in words2)
            {
                long arrivalTime = 0;
                long serviceTime = 0;
                

                if(newLineInt == 1)
                {
                    System.Console.WriteLine($"<{word2}>");
                    Debug.Log(word2);
                }
                //Interarrival Time (minutes)
                if(newLineInt == 2)
                {
                    System.Console.WriteLine($"<{word2}>");
                    Debug.Log(word2);
                    arrivalTime = Int64.Parse(word2); 
                }
                //Service Time
                if(newLineInt == 3)
                {
                    Debug.Log("testing");
                    System.Console.WriteLine($"<{word2}>");
                    Debug.Log(word2);
                    serviceTime = Int64.Parse(word2); 
                    //Customer myObj = new Customer(arrivalTime,serviceTime);
                    //C[skipLine - 1] = new Customer(arrivalTime,serviceTime);
                }
                //System.Console.WriteLine($"<{word2}>");
                //Debug.Log(word2);

                newLineInt = newLineInt + 1;

            }
          }
        
            skipLine = skipLine + 1;
            
        }
        //readTextFile("E:\\Centennial\\2022\\Simulation\\Group5-Part1\\roject01_Part01_Group05\\Assets\\Scenes\\Group5-Part1.txt");
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
