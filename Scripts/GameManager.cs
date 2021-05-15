using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    [SerializeField]SwipeHandler sweip;
    [SerializeField]FirstBarier wall;
    [SerializeField]SecondBarier wall2;
    [SerializeField]Barrier3 wall3;
    [SerializeField]Barrier4 wall4;
    [SerializeField]Barrier5 wall5;
   
    private float score = 0.0f;
    private float score1 = 1.0f;
    private float score2 = 1.0f;
    private float score3 = 1.0f;
    private float score4 = 1.0f;
    private float score5 = 1.0f;
    private float mainScore;
    float temp;
    bool isCount;
    bool isField1;
    bool isField2;
    bool isField3;
    bool isField4;
    public bool isField5;
    

    [SerializeField] Text field1;
    [SerializeField] Text field2; 
    [SerializeField] Text field3;
    [SerializeField] Text field4;
    [SerializeField] Text field5;
    [SerializeField] Text fieldMain;



    
    private void OnEnable()
    {
        UpdateText();
                
    }
    private void Start()
    {
        sweip.Left += SweipLeft;
        sweip.Right += SweipRight;
        wall.Barier1 += Barier1Set;
        wall2.Barier2 += Barier2Set;
        wall3.Barier3 += Barier3Set;
        wall4.Barier4 += Barier4Set;
        wall5.Barier5 += Barier5Set;
    }
    void SweipLeft()
    {
        if (isCount)
        {
            if(isField1 || isField3)
            {
                isCount = false;
            }
        }
    }
    void SweipRight()
    {
        if (isCount)
        {
            if (isField2 || isField4)
            {
                isCount = false;
            }
            if (isField5)
            {
                isCount = false;
                isField5 = false;
                SetMainTable();
            }
        }
    }
    void Barier1Set()
    {
        StartCount();
        isField1 = true;
        
    }
    void Barier2Set()
    {
        isField1 = false;
        StartCount();
        isField2 = true;
    }
    void Barier3Set()
    {
        isField2 = false;
        StartCount();
        isField3 = true;
    }
    void Barier4Set()
    {
        isField3 = false;
        StartCount();
        isField4 = true;
    }
    void Barier5Set()
    {
        isField4 = false;
        StartCount();
        isField5 = true;
    }
    public void UpdateText()
    {
        field1.text = " 0 ";
        field2.text = " 0 ";
        field3.text = " 0 ";
        field4.text = " 0 ";
        field5.text = " 0 ";
        fieldMain.text = " 0 ";
        score = 0;
        isCount = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            SweipLeft();
            Debug.Log("A");
        }
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            Debug.Log("D");
            SweipRight();
        } 

        if (isCount)
        {
            score = Time.time - temp;
            if (isField1)
            {
                field1.text = score.ToString();
                score1 = score;
            }
            else if (isField2)
            {
                field2.text = score.ToString();
                score2 = score;
            }
            else if (isField3)
            {
                field3.text = score.ToString();
                score3 = score;
            }
            else if (isField4)
            {
                field4.text = score.ToString();
                score4 = score;
            }
            else if (isField5)
            {
                field5.text = score.ToString();
                score5 = score;
            }
        }
             
        
    }
    public void StartCount()
    {
        isCount = true;
        temp = Time.time;        
    }

    public void SetMainTable()
    {
        mainScore = (score1 + score2 + score3 + score4 + score5) / 5;
        fieldMain.text = mainScore.ToString();
        if (PlayerPrefs.HasKey("1_Level"))
        {
            if (mainScore < PlayerPrefs.GetFloat("1_Level"))
            {
                PlayerPrefs.SetFloat("1_Level", mainScore);
            }
        }
        else
        {
            PlayerPrefs.SetFloat("1_Level", mainScore);
        }
    }






}
