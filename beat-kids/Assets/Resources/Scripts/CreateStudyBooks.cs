using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreateStudyBooks : MonoBehaviour {

    private string StudyBook_Math; // 수학 문제집
    private string StudyBook_English; // 영어 문제집

    [Serializable]
    public class NoteInfo // 노트 정보 클래스
    {
        public float appearTime = 0; // 등장 시간
        public string Choice; // 노트에 들어갈 값

        public NoteInfo(float _appearTime, string _Choice)
        {
            this.appearTime = _appearTime;
            this.Choice = _Choice;
        }
    }

    [Serializable]
    public class Problem // 문제 정보 클래스
    {
        public string Question; // 문제 내용
        public List<NoteInfo> Choices = new List<NoteInfo>(); // 노트들
        public string Answer; // 답
    }

    [Serializable]
    public class StudyBook  // 문제집 클래스
    {
        public string Name; // 문제집 이름
        public List<Problem> Problems = new List<Problem>(); // 문제들
    }

    protected void Awake()
    {
        // 수학 문제집
        StudyBook Math_StudyBook = new StudyBook();
        Math_StudyBook.Name = "수학 문제집";

        Problem[] Math_Array = new Problem[70];
        for (int i = 0; i < Math_Array.Length; i++)
        {
            Math_Array[i] = new Problem();
        }

        Math_Array[0].Question = "1 + 1 = □";
        Math_Array[0].Choices.Add(new NoteInfo(5.0f, "1"));
        Math_Array[0].Choices.Add(new NoteInfo(5.0f, "2"));
        Math_Array[0].Choices.Add(new NoteInfo(5.0f, "3"));
        Math_Array[0].Answer = "2";

        Math_Array[1].Question = "1 + 7 = □";
        Math_Array[1].Choices.Add(new NoteInfo(10.0f, "8"));
        Math_Array[1].Choices.Add(new NoteInfo(10.0f, "9"));
        Math_Array[1].Choices.Add(new NoteInfo(10.0f, "10"));
        Math_Array[1].Answer = "9";

        Math_Array[2].Question = "5 + 6 = □";
        Math_Array[2].Choices.Add(new NoteInfo(15.0f, "9"));
        Math_Array[2].Choices.Add(new NoteInfo(15.0f, "11"));
        Math_Array[2].Choices.Add(new NoteInfo(15.0f, "13"));
        Math_Array[2].Answer = "11";

        Math_Array[3].Question = "9 + 5 = □";
        Math_Array[3].Choices.Add(new NoteInfo(20.0f, "12"));
        Math_Array[3].Choices.Add(new NoteInfo(20.0f, "13"));
        Math_Array[3].Choices.Add(new NoteInfo(20.0f, "14"));
        Math_Array[3].Answer = "14";

        Math_Array[4].Question = "7 + 7 = □";
        Math_Array[4].Choices.Add(new NoteInfo(25.0f, "11"));
        Math_Array[4].Choices.Add(new NoteInfo(25.0f, "14"));
        Math_Array[4].Choices.Add(new NoteInfo(25.0f, "13"));
        Math_Array[4].Answer = "14";

        Math_Array[5].Question = "3 + 3 + 3 = □";
        Math_Array[5].Choices.Add(new NoteInfo(30.0f, "7"));
        Math_Array[5].Choices.Add(new NoteInfo(30.0f, "8"));
        Math_Array[5].Choices.Add(new NoteInfo(30.0f, "9"));
        Math_Array[5].Answer = "9";

        Math_Array[6].Question = "1 + 9 + 3 = □";
        Math_Array[6].Choices.Add(new NoteInfo(35.0f, "13"));
        Math_Array[6].Choices.Add(new NoteInfo(35.0f, "14"));
        Math_Array[6].Choices.Add(new NoteInfo(35.0f, "12"));
        Math_Array[6].Answer = "13";

        Math_Array[7].Question = "8 + 5 + 2 = □";
        Math_Array[7].Choices.Add(new NoteInfo(40.0f, "13"));
        Math_Array[7].Choices.Add(new NoteInfo(40.0f, "16"));
        Math_Array[7].Choices.Add(new NoteInfo(40.0f, "15"));
        Math_Array[7].Answer = "15";

        Math_Array[8].Question = "5 + 4 + 8 = □";
        Math_Array[8].Choices.Add(new NoteInfo(45.0f, "17"));
        Math_Array[8].Choices.Add(new NoteInfo(45.0f, "25"));
        Math_Array[8].Choices.Add(new NoteInfo(45.0f, "15"));
        Math_Array[8].Answer = "17";

        Math_Array[9].Question = "7 + 6 + 5 = □";
        Math_Array[9].Choices.Add(new NoteInfo(50.0f, "16"));
        Math_Array[9].Choices.Add(new NoteInfo(50.0f, "20"));
        Math_Array[9].Choices.Add(new NoteInfo(50.0f, "18"));
        Math_Array[9].Answer = "18";

        Math_Array[10].Question = "50 + 1 = □";
        Math_Array[10].Choices.Add(new NoteInfo(55.0f, "51"));
        Math_Array[10].Choices.Add(new NoteInfo(55.0f, "52"));
        Math_Array[10].Choices.Add(new NoteInfo(55.0f, "50"));
        Math_Array[10].Answer = "51";

        Math_Array[11].Question = "40 + 8 = □";
        Math_Array[11].Choices.Add(new NoteInfo(60.0f, "46"));
        Math_Array[11].Choices.Add(new NoteInfo(60.0f, "48"));
        Math_Array[11].Choices.Add(new NoteInfo(60.0f, "50"));
        Math_Array[11].Answer = "48";

        Math_Array[12].Question = "81 + 7 = □";
        Math_Array[12].Choices.Add(new NoteInfo(65.0f, "98"));
        Math_Array[12].Choices.Add(new NoteInfo(65.0f, "89"));
        Math_Array[12].Choices.Add(new NoteInfo(65.0f, "88"));
        Math_Array[12].Answer = "88";

        Math_Array[13].Question = "88 + 5 = □";
        Math_Array[13].Choices.Add(new NoteInfo(70.0f, "83"));
        Math_Array[13].Choices.Add(new NoteInfo(70.0f, "93"));
        Math_Array[13].Choices.Add(new NoteInfo(70.0f, "94"));
        Math_Array[13].Answer = "93";

        Math_Array[14].Question = "28 + 9 = □";
        Math_Array[14].Choices.Add(new NoteInfo(75.0f, "47"));
        Math_Array[14].Choices.Add(new NoteInfo(75.0f, "27"));
        Math_Array[14].Choices.Add(new NoteInfo(75.0f, "37"));
        Math_Array[14].Answer = "37";

        Math_Array[15].Question = "10 + 10 = □";
        Math_Array[15].Choices.Add(new NoteInfo(80.0f, "30"));
        Math_Array[15].Choices.Add(new NoteInfo(80.0f, "20"));
        Math_Array[15].Choices.Add(new NoteInfo(80.0f, "10"));
        Math_Array[15].Answer = "20";

        Math_Array[16].Question = "10 + 70 = □";
        Math_Array[16].Choices.Add(new NoteInfo(85.0f, "80"));
        Math_Array[16].Choices.Add(new NoteInfo(85.0f, "100"));
        Math_Array[16].Choices.Add(new NoteInfo(85.0f, "71"));
        Math_Array[16].Answer = "80";

        Math_Array[17].Question = "20 + 30 = □";
        Math_Array[17].Choices.Add(new NoteInfo(90.0f, "23"));
        Math_Array[17].Choices.Add(new NoteInfo(90.0f, "40"));
        Math_Array[17].Choices.Add(new NoteInfo(90.0f, "50"));
        Math_Array[17].Answer = "50";

        Math_Array[18].Question = "50 + 30 = □";
        Math_Array[18].Choices.Add(new NoteInfo(95.0f, "80"));
        Math_Array[18].Choices.Add(new NoteInfo(95.0f, "35"));
        Math_Array[18].Choices.Add(new NoteInfo(95.0f, "53"));
        Math_Array[18].Answer = "80";

        Math_Array[19].Question = "30 + 60 = □";
        Math_Array[19].Choices.Add(new NoteInfo(100.0f, "50"));
        Math_Array[19].Choices.Add(new NoteInfo(100.0f, "70"));
        Math_Array[19].Choices.Add(new NoteInfo(100.0f, "90"));
        Math_Array[19].Answer = "90";

        Math_Array[20].Question = "17 + 40 = □";
        Math_Array[20].Choices.Add(new NoteInfo(105.0f, "57"));
        Math_Array[20].Choices.Add(new NoteInfo(105.0f, "67"));
        Math_Array[20].Choices.Add(new NoteInfo(105.0f, "77"));
        Math_Array[20].Answer = "57";

        Math_Array[21].Question = "28 + 20 = □";
        Math_Array[21].Choices.Add(new NoteInfo(110.0f, "18"));
        Math_Array[21].Choices.Add(new NoteInfo(110.0f, "38"));
        Math_Array[21].Choices.Add(new NoteInfo(110.0f, "48"));
        Math_Array[21].Answer = "48";

        Math_Array[22].Question = "22 + 41 = □";
        Math_Array[22].Choices.Add(new NoteInfo(115.0f, "62"));
        Math_Array[22].Choices.Add(new NoteInfo(115.0f, "63"));
        Math_Array[22].Choices.Add(new NoteInfo(115.0f, "64"));
        Math_Array[22].Answer = "63";

        Math_Array[23].Question = "46 + 23 = □";
        Math_Array[23].Choices.Add(new NoteInfo(120.0f, "67"));
        Math_Array[23].Choices.Add(new NoteInfo(120.0f, "59"));
        Math_Array[23].Choices.Add(new NoteInfo(120.0f, "69"));
        Math_Array[23].Answer = "69";

        Math_Array[24].Question = "85 + 12 = □";
        Math_Array[24].Choices.Add(new NoteInfo(125.0f, "107"));
        Math_Array[24].Choices.Add(new NoteInfo(125.0f, "77"));
        Math_Array[24].Choices.Add(new NoteInfo(125.0f, "97"));
        Math_Array[24].Answer = "97";

        Math_Array[25].Question = "2 + □ = 8";
        Math_Array[25].Choices.Add(new NoteInfo(130.0f, "7"));
        Math_Array[25].Choices.Add(new NoteInfo(130.0f, "8"));
        Math_Array[25].Choices.Add(new NoteInfo(130.0f, "6"));
        Math_Array[25].Answer = "6";

        Math_Array[26].Question = "□ + 1 = 8";
        Math_Array[26].Choices.Add(new NoteInfo(135.0f, "7"));
        Math_Array[26].Choices.Add(new NoteInfo(135.0f, "5"));
        Math_Array[26].Choices.Add(new NoteInfo(135.0f, "6"));
        Math_Array[26].Answer = "7";

        Math_Array[27].Question = "□ + 12 = 15";
        Math_Array[27].Choices.Add(new NoteInfo(140.0f, "2"));
        Math_Array[27].Choices.Add(new NoteInfo(140.0f, "3"));
        Math_Array[27].Choices.Add(new NoteInfo(140.0f, "4"));
        Math_Array[27].Answer = "3";

        Math_Array[28].Question = "15 + □ = 28";
        Math_Array[28].Choices.Add(new NoteInfo(145.0f, "3"));
        Math_Array[28].Choices.Add(new NoteInfo(145.0f, "12"));
        Math_Array[28].Choices.Add(new NoteInfo(145.0f, "13"));
        Math_Array[28].Answer = "13";

        Math_Array[29].Question = "31 + □ = 46";
        Math_Array[29].Choices.Add(new NoteInfo(150.0f, "15"));
        Math_Array[29].Choices.Add(new NoteInfo(150.0f, "11"));
        Math_Array[29].Choices.Add(new NoteInfo(150.0f, "16"));
        Math_Array[29].Answer = "15";

        Math_Array[30].Question = "3 - 3 = □";
        Math_Array[30].Choices.Add(new NoteInfo(155.0f, "2"));
        Math_Array[30].Choices.Add(new NoteInfo(155.0f, "3"));
        Math_Array[30].Choices.Add(new NoteInfo(155.0f, "0"));
        Math_Array[30].Answer = "0";

        Math_Array[31].Question = "5 - 0 = □";
        Math_Array[31].Choices.Add(new NoteInfo(160.0f, "500"));
        Math_Array[31].Choices.Add(new NoteInfo(160.0f, "50"));
        Math_Array[31].Choices.Add(new NoteInfo(160.0f, "5"));
        Math_Array[31].Answer = "5";

        Math_Array[32].Question = "8 - 6 = □";
        Math_Array[32].Choices.Add(new NoteInfo(165.0f, "1"));
        Math_Array[32].Choices.Add(new NoteInfo(165.0f, "2"));
        Math_Array[32].Choices.Add(new NoteInfo(165.0f, "3"));
        Math_Array[32].Answer = "2";

        Math_Array[33].Question = "9와 5의 차";
        Math_Array[33].Choices.Add(new NoteInfo(170.0f, "4"));
        Math_Array[33].Choices.Add(new NoteInfo(170.0f, "44"));
        Math_Array[33].Choices.Add(new NoteInfo(170.0f, "2"));
        Math_Array[33].Answer = "4";

        Math_Array[34].Question = "7과 9의 차";
        Math_Array[34].Choices.Add(new NoteInfo(175.0f, "5"));
        Math_Array[34].Choices.Add(new NoteInfo(175.0f, "2"));
        Math_Array[34].Choices.Add(new NoteInfo(175.0f, "3"));
        Math_Array[34].Answer = "2";

        Math_Array[35].Question = "4 - 1 - 1 = □";
        Math_Array[35].Choices.Add(new NoteInfo(180.0f, "7"));
        Math_Array[35].Choices.Add(new NoteInfo(180.0f, "5"));
        Math_Array[35].Choices.Add(new NoteInfo(180.0f, "2"));
        Math_Array[35].Answer = "2";

        Math_Array[36].Question = "9 - 6 - 1 = □";
        Math_Array[36].Choices.Add(new NoteInfo(185.0f, "3"));
        Math_Array[36].Choices.Add(new NoteInfo(185.0f, "2"));
        Math_Array[36].Choices.Add(new NoteInfo(185.0f, "4"));
        Math_Array[36].Answer = "2";

        Math_Array[37].Question = "7 - 2 + 3 = □";
        Math_Array[37].Choices.Add(new NoteInfo(190.0f, "3"));
        Math_Array[37].Choices.Add(new NoteInfo(190.0f, "7"));
        Math_Array[37].Choices.Add(new NoteInfo(190.0f, "8"));
        Math_Array[37].Answer = "8";

        Math_Array[38].Question = "6 + 3 - 4 = □";
        Math_Array[38].Choices.Add(new NoteInfo(195.0f, "5"));
        Math_Array[38].Choices.Add(new NoteInfo(195.0f, "9"));
        Math_Array[38].Choices.Add(new NoteInfo(195.0f, "4"));
        Math_Array[38].Answer = "5";

        Math_Array[39].Question = "3 + 6 - 2 = □";
        Math_Array[39].Choices.Add(new NoteInfo(200.0f, "9"));
        Math_Array[39].Choices.Add(new NoteInfo(200.0f, "7"));
        Math_Array[39].Choices.Add(new NoteInfo(200.0f, "8"));
        Math_Array[39].Answer = "7";

        Math_Array[40].Question = "10 - 7 = □";
        Math_Array[40].Choices.Add(new NoteInfo(205.0f, "10"));
        Math_Array[40].Choices.Add(new NoteInfo(205.0f, "7"));
        Math_Array[40].Choices.Add(new NoteInfo(205.0f, "3"));
        Math_Array[40].Answer = "3";

        Math_Array[41].Question = "28 - 5 = □";
        Math_Array[41].Choices.Add(new NoteInfo(210.0f, "23"));
        Math_Array[41].Choices.Add(new NoteInfo(210.0f, "13"));
        Math_Array[41].Choices.Add(new NoteInfo(210.0f, "25"));
        Math_Array[41].Answer = "23";

        Math_Array[42].Question = "15 - 9 = □";
        Math_Array[42].Choices.Add(new NoteInfo(215.0f, "9"));
        Math_Array[42].Choices.Add(new NoteInfo(215.0f, "6"));
        Math_Array[42].Choices.Add(new NoteInfo(215.0f, "3"));
        Math_Array[42].Answer = "6";

        Math_Array[43].Question = "13 - 7 = □";
        Math_Array[43].Choices.Add(new NoteInfo(220.0f, "8"));
        Math_Array[43].Choices.Add(new NoteInfo(220.0f, "7"));
        Math_Array[43].Choices.Add(new NoteInfo(220.0f, "6"));
        Math_Array[43].Answer = "6";

        Math_Array[44].Question = "13 - 3 = □";
        Math_Array[44].Choices.Add(new NoteInfo(225.0f, "9"));
        Math_Array[44].Choices.Add(new NoteInfo(225.0f, "10"));
        Math_Array[44].Choices.Add(new NoteInfo(225.0f, "11"));
        Math_Array[44].Answer = "10";

        Math_Array[45].Question = "20 - 10 = □";
        Math_Array[45].Choices.Add(new NoteInfo(230.0f, "10"));
        Math_Array[45].Choices.Add(new NoteInfo(230.0f, "20"));
        Math_Array[45].Choices.Add(new NoteInfo(230.0f, "30"));
        Math_Array[45].Answer = "10";

        Math_Array[46].Question = "60 - 30 = □";
        Math_Array[46].Choices.Add(new NoteInfo(235.0f, "20"));
        Math_Array[46].Choices.Add(new NoteInfo(235.0f, "30"));
        Math_Array[46].Choices.Add(new NoteInfo(235.0f, "40"));
        Math_Array[46].Answer = "30";

        Math_Array[47].Question = "90 - 30 = □";
        Math_Array[47].Choices.Add(new NoteInfo(240.0f, "50"));
        Math_Array[47].Choices.Add(new NoteInfo(240.0f, "70"));
        Math_Array[47].Choices.Add(new NoteInfo(240.0f, "60"));
        Math_Array[47].Answer = "60";

        Math_Array[48].Question = "50 - 50 = □";
        Math_Array[48].Choices.Add(new NoteInfo(245.0f, "0"));
        Math_Array[48].Choices.Add(new NoteInfo(245.0f, "550"));
        Math_Array[48].Choices.Add(new NoteInfo(245.0f, "100"));
        Math_Array[48].Answer = "0";

        Math_Array[49].Question = "80 - 40 = □";
        Math_Array[49].Choices.Add(new NoteInfo(250.0f, "40"));
        Math_Array[49].Choices.Add(new NoteInfo(250.0f, "30"));
        Math_Array[49].Choices.Add(new NoteInfo(250.0f, "50"));
        Math_Array[49].Answer = "40";

        Math_Array[50].Question = "16 - 10 = □";
        Math_Array[50].Choices.Add(new NoteInfo(255.0f, "10"));
        Math_Array[50].Choices.Add(new NoteInfo(255.0f, "6"));
        Math_Array[50].Choices.Add(new NoteInfo(255.0f, "5"));
        Math_Array[50].Answer = "6";

        Math_Array[51].Question = "75 - 60 = □";
        Math_Array[51].Choices.Add(new NoteInfo(260.0f, "35"));
        Math_Array[51].Choices.Add(new NoteInfo(260.0f, "25"));
        Math_Array[51].Choices.Add(new NoteInfo(260.0f, "15"));
        Math_Array[51].Answer = "15";

        Math_Array[52].Question = "49 - 37 = □";
        Math_Array[52].Choices.Add(new NoteInfo(265.0f, "12"));
        Math_Array[52].Choices.Add(new NoteInfo(265.0f, "14"));
        Math_Array[52].Choices.Add(new NoteInfo(265.0f, "13"));
        Math_Array[52].Answer = "12";

        Math_Array[53].Question = "98 - 45 = □";
        Math_Array[53].Choices.Add(new NoteInfo(270.0f, "43"));
        Math_Array[53].Choices.Add(new NoteInfo(270.0f, "33"));
        Math_Array[53].Choices.Add(new NoteInfo(270.0f, "53"));
        Math_Array[53].Answer = "53";

        Math_Array[54].Question = "66 - 42 = □";
        Math_Array[54].Choices.Add(new NoteInfo(275.0f, "44"));
        Math_Array[54].Choices.Add(new NoteInfo(275.0f, "24"));
        Math_Array[54].Choices.Add(new NoteInfo(275.0f, "42"));
        Math_Array[54].Answer = "24";

        Math_Array[55].Question = "3 - □ = 1";
        Math_Array[55].Choices.Add(new NoteInfo(280.0f, "2"));
        Math_Array[55].Choices.Add(new NoteInfo(280.0f, "0"));
        Math_Array[55].Choices.Add(new NoteInfo(280.0f, "1"));
        Math_Array[55].Answer = "2";

        Math_Array[56].Question = "□ - 7 = 1";
        Math_Array[56].Choices.Add(new NoteInfo(285.0f, "10"));
        Math_Array[56].Choices.Add(new NoteInfo(285.0f, "8"));
        Math_Array[56].Choices.Add(new NoteInfo(285.0f, "9"));
        Math_Array[56].Answer = "8";

        Math_Array[57].Question = "18 - □ = 10";
        Math_Array[57].Choices.Add(new NoteInfo(290.0f, "6"));
        Math_Array[57].Choices.Add(new NoteInfo(290.0f, "7"));
        Math_Array[57].Choices.Add(new NoteInfo(290.0f, "8"));
        Math_Array[57].Answer = "8";

        Math_Array[58].Question = "□ - 31 = 24";
        Math_Array[58].Choices.Add(new NoteInfo(295.0f, "55"));
        Math_Array[58].Choices.Add(new NoteInfo(295.0f, "65"));
        Math_Array[58].Choices.Add(new NoteInfo(295.0f, "45"));
        Math_Array[58].Answer = "55";

        Math_Array[59].Question = "□ - 83 = 15";
        Math_Array[59].Choices.Add(new NoteInfo(300.0f, "89"));
        Math_Array[59].Choices.Add(new NoteInfo(300.0f, "98"));
        Math_Array[59].Choices.Add(new NoteInfo(300.0f, "108"));
        Math_Array[59].Answer = "98";

        Math_Array[60].Question = "2 × 4 = □";
        Math_Array[60].Choices.Add(new NoteInfo(305.0f, "8"));
        Math_Array[60].Choices.Add(new NoteInfo(305.0f, "6"));
        Math_Array[60].Choices.Add(new NoteInfo(305.0f, "10"));
        Math_Array[60].Answer = "8";

        Math_Array[61].Question = "7 × 8 = □";
        Math_Array[61].Choices.Add(new NoteInfo(310.0f, "65"));
        Math_Array[61].Choices.Add(new NoteInfo(310.0f, "64"));
        Math_Array[61].Choices.Add(new NoteInfo(310.0f, "56"));
        Math_Array[61].Answer = "56";

        Math_Array[62].Question = "9 × 3 = □";
        Math_Array[62].Choices.Add(new NoteInfo(315.0f, "22"));
        Math_Array[62].Choices.Add(new NoteInfo(315.0f, "72"));
        Math_Array[62].Choices.Add(new NoteInfo(315.0f, "27"));
        Math_Array[62].Answer = "27";

        Math_Array[63].Question = "5 × 0 = □";
        Math_Array[63].Choices.Add(new NoteInfo(320.0f, "5"));
        Math_Array[63].Choices.Add(new NoteInfo(320.0f, "0"));
        Math_Array[63].Choices.Add(new NoteInfo(320.0f, "50"));
        Math_Array[63].Answer = "0";

        Math_Array[64].Question = "8 ×4 = □";
        Math_Array[64].Choices.Add(new NoteInfo(325.0f, "32"));
        Math_Array[64].Choices.Add(new NoteInfo(325.0f, "40"));
        Math_Array[64].Choices.Add(new NoteInfo(325.0f, "28"));
        Math_Array[64].Answer = "32";

        Math_Array[65].Question = "30 × 5 = □";
        Math_Array[65].Choices.Add(new NoteInfo(330.0f, "15"));
        Math_Array[65].Choices.Add(new NoteInfo(330.0f, "35"));
        Math_Array[65].Choices.Add(new NoteInfo(330.0f, "150"));
        Math_Array[65].Answer = "150";

        Math_Array[66].Question = "40 × 6 = □";
        Math_Array[66].Choices.Add(new NoteInfo(335.0f, "420"));
        Math_Array[66].Choices.Add(new NoteInfo(335.0f, "240"));
        Math_Array[66].Choices.Add(new NoteInfo(335.0f, "320"));
        Math_Array[66].Answer = "240";

        Math_Array[67].Question = "50 × 7 = □";
        Math_Array[67].Choices.Add(new NoteInfo(340.0f, "350"));
        Math_Array[67].Choices.Add(new NoteInfo(340.0f, "53"));
        Math_Array[67].Choices.Add(new NoteInfo(340.0f, "35"));
        Math_Array[67].Answer = "350";

        Math_Array[68].Question = "10 × 8 = □";
        Math_Array[68].Choices.Add(new NoteInfo(345.0f, "2"));
        Math_Array[68].Choices.Add(new NoteInfo(345.0f, "80"));
        Math_Array[68].Choices.Add(new NoteInfo(345.0f, "18"));
        Math_Array[68].Answer = "80";

        Math_Array[69].Question = "60 × 9 = □";
        Math_Array[69].Choices.Add(new NoteInfo(350.0f, "540"));
        Math_Array[69].Choices.Add(new NoteInfo(350.0f, "54"));
        Math_Array[69].Choices.Add(new NoteInfo(350.0f, "630"));
        Math_Array[69].Answer = "540";

        for(int i = 0; i < Math_Array.Length; i++)
        {
            Math_StudyBook.Problems.Add(Math_Array[i]);
        }

        StudyBook_Math = JsonUtility.ToJson(Math_StudyBook);

        Debug.Log(StudyBook_Math);

        // 영어 문제집
        //StudyBook English_StudyBook = new StudyBook();
        //English_StudyBook.Name = "영어 문제집";

        //Problem[] English_Array = new Problem[70];
        //for (int i = 0; i < English_Array.Length; i++)
        //{
        //    English_Array[i] = new Problem();
        //}

        //English_Array[0].Question = "";
        //English_Array[0].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[0].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[0].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[0].Answer = 2;

        //English_Array[1].Question = "";
        //English_Array[1].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[1].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[1].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[1].Answer = 2;

        //English_Array[2].Question = "";
        //English_Array[2].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[2].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[2].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[2].Answer = 2;

        //English_Array[3].Question = "";
        //English_Array[3].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[3].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[3].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[3].Answer = 2;

        //English_Array[4].Question = "";
        //English_Array[4].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[4].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[4].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[4].Answer = 2;

        //English_Array[5].Question = "";
        //English_Array[5].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[5].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[5].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[5].Answer = 2;

        //English_Array[6].Question = "";
        //English_Array[6].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[6].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[6].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[6].Answer = 2;

        //English_Array[7].Question = "";
        //English_Array[7].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[7].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[7].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[7].Answer = 2;

        //English_Array[8].Question = "";
        //English_Array[8].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[8].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[8].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[8].Answer = 2;

        //English_Array[9].Question = "";
        //English_Array[9].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[9].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[9].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[9].Answer = 2;

        //English_Array[10].Question = "";
        //English_Array[10].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[10].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[10].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[10].Answer = 2;

        //English_Array[11].Question = "";
        //English_Array[11].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[11].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[11].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[11].Answer = 2;

        //English_Array[12].Question = "";
        //English_Array[12].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[12].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[12].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[12].Answer = 2;

        //English_Array[13].Question = "";
        //English_Array[13].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[13].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[13].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[13].Answer = 2;

        //English_Array[14].Question = "";
        //English_Array[14].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[14].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[14].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[14].Answer = 2;

        //English_Array[15].Question = "";
        //English_Array[15].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[15].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[15].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[15].Answer = 2;

        //English_Array[16].Question = "";
        //English_Array[16].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[16].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[16].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[16].Answer = 2;

        //English_Array[17].Question = "";
        //English_Array[17].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[17].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[17].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[17].Answer = 2;

        //English_Array[18].Question = "";
        //English_Array[18].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[18].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[18].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[18].Answer = 2;

        //English_Array[19].Question = "";
        //English_Array[19].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[19].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[19].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[19].Answer = 2;

        //English_Array[20].Question = "";
        //English_Array[20].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[20].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[20].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[20].Answer = 2;

        //English_Array[21].Question = "";
        //English_Array[21].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[21].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[21].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[21].Answer = 2;

        //English_Array[22].Question = "";
        //English_Array[22].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[22].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[22].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[22].Answer = 2;

        //English_Array[23].Question = "";
        //English_Array[23].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[23].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[23].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[23].Answer = 2;

        //English_Array[24].Question = "";
        //English_Array[24].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[24].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[24].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[24].Answer = 2;

        //English_Array[25].Question = "";
        //English_Array[25].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[25].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[25].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[25].Answer = 2;

        //English_Array[26].Question = "";
        //English_Array[26].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[26].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[26].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[26].Answer = 2;

        //English_Array[27].Question = "";
        //English_Array[27].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[27].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[27].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[27].Answer = 2;

        //English_Array[28].Question = "";
        //English_Array[28].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[28].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[28].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[28].Answer = 2;

        //English_Array[29].Question = "";
        //English_Array[29].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[29].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[29].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[29].Answer = 2;

        //English_Array[30].Question = "";
        //English_Array[30].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[30].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[30].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[30].Answer = 2;

        //English_Array[31].Question = "";
        //English_Array[31].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[31].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[31].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[31].Answer = 2;

        //English_Array[32].Question = "";
        //English_Array[32].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[32].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[32].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[32].Answer = 2;

        //English_Array[33].Question = "";
        //English_Array[33].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[33].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[33].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[33].Answer = 2;

        //English_Array[34].Question = "";
        //English_Array[34].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[34].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[34].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[34].Answer = 2;

        //English_Array[35].Question = "";
        //English_Array[35].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[35].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[35].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[35].Answer = 2;

        //English_Array[36].Question = "";
        //English_Array[36].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[36].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[36].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[36].Answer = 2;

        //English_Array[37].Question = "";
        //English_Array[37].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[37].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[37].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[37].Answer = 2;

        //English_Array[38].Question = "";
        //English_Array[38].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[38].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[38].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[38].Answer = 2;

        //English_Array[39].Question = "";
        //English_Array[39].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[39].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[39].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[39].Answer = 2;

        //English_Array[40].Question = "";
        //English_Array[40].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[40].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[40].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[40].Answer = 2;

        //English_Array[41].Question = "";
        //English_Array[41].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[41].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[41].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[41].Answer = 2;

        //English_Array[42].Question = "";
        //English_Array[42].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[42].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[42].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[42].Answer = 2;

        //English_Array[43].Question = "";
        //English_Array[43].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[43].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[43].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[43].Answer = 2;

        //English_Array[44].Question = "";
        //English_Array[44].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[44].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[44].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[44].Answer = 2;

        //English_Array[45].Question = "";
        //English_Array[45].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[45].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[45].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[45].Answer = 2;

        //English_Array[46].Question = "";
        //English_Array[46].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[46].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[46].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[46].Answer = 2;

        //English_Array[47].Question = "";
        //English_Array[47].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[47].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[47].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[47].Answer = 2;

        //English_Array[48].Question = "";
        //English_Array[48].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[48].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[48].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[48].Answer = 2;

        //English_Array[49].Question = "";
        //English_Array[49].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[49].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[49].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[49].Answer = 2;

        //English_Array[50].Question = "";
        //English_Array[50].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[50].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[50].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[50].Answer = 2;

        //English_Array[51].Question = "";
        //English_Array[51].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[51].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[51].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[51].Answer = 2;

        //English_Array[52].Question = "";
        //English_Array[52].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[52].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[52].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[52].Answer = 2;

        //English_Array[53].Question = "";
        //English_Array[53].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[53].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[53].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[53].Answer = 2;

        //English_Array[54].Question = "";
        //English_Array[54].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[54].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[54].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[54].Answer = 2;

        //English_Array[55].Question = "";
        //English_Array[55].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[55].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[55].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[55].Answer = 2;

        //English_Array[56].Question = "";
        //English_Array[56].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[56].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[56].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[56].Answer = 2;

        //English_Array[57].Question = "";
        //English_Array[57].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[57].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[57].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[57].Answer = 2;

        //English_Array[58].Question = "";
        //English_Array[58].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[58].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[58].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[58].Answer = 2;

        //English_Array[59].Question = "";
        //English_Array[59].Choices.Add(new NoteInfo(5.0f, 1));
        //English_Array[59].Choices.Add(new NoteInfo(5.0f, 2));
        //English_Array[59].Choices.Add(new NoteInfo(5.0f, 3));
        //English_Array[59].Answer = 2;

        //for (int i = 0; i < English_Array.Length; i++)
        //{
        //    English_StudyBook.Problems.Add(English_Array[i]);
        //}

        //StudyBook_English = JsonUtility.ToJson(English_StudyBook);
    }

    public string getStudyBook_Math()
    {
        return StudyBook_Math;
    }

    public string getStudyBook_English()
    {
        return StudyBook_English;
    }

 //   // Use this for initialization
 //   void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
