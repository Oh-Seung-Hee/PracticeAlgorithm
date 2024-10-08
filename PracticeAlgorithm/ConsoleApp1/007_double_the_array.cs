﻿using System;
/// <summary>
/// <배열 두 배 만들기>
/// [문제 설명]
/// 정수 배열 numbers가 매개변수로 주어집니다. numbers의 각 원소에 두배한 원소를 가진 배열을 return하도록 solution 함수를 완성해주세요.
/// [제한 사항]
/// -10,000 ≤  numbers의 원소 ≤ 10,000
/// 1 ≤  numbers의 길이 ≤ 1,000
/// </summary>
namespace Level_0
{
    public class Solution007
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = numbers;

            for (int i = 0; i < numbers.Length; i++)
            {
                answer[i] *= 2;
            }

            return answer;
        }
    }
}