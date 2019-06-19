using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreateStudyBooks : MonoBehaviour {
    [Serializable]
    public class NoteInfo // 노트 정보 클래스
    {
        public string Choice; // 노트에 들어갈 값

        public NoteInfo(string _Choice)
        {
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
}
