using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadFromCsv : MonoBehaviour
{

    public TextAsset textAssetData;
    public Text printDataText;

    public List<string> playerList = new List<string>();

    [SerializeField] public int rowNum; 

    void Start()
    {
        ReadCsv();
    }

    private void Update()
    {
        
    }

    void ReadCsv()
    {
        string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
        int dataColumn = rowNum;
        int dataRoll;

        print("data length: " + data.Length);
        dataRoll = data.Length / dataColumn;                          // the line of the data

        string[] strr = new string[dataRoll];
        for (int i = 0; i < dataRoll; i++)
        {
            for (int j = rowNum * i; j < rowNum * (i + 1); j++)
            {
                strr[i] += data[j] + " ";                            // combine the string


            }
            if (i > 0)
                playerList.Add(strr[i]);                        // store the player.
        }
        string printPlayer = "";
        // print all data in string
        for (int i = 0; i < dataRoll; i++)
        {
            printPlayer += strr[i] + "\n";
        }
        printDataText.text = printPlayer;

        Debug.Log(playerList[0]);                  //print

    }
}
