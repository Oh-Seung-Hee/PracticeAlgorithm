﻿using System;
/// <summary>
/// <숫자 비교하기>
/// [문제 설명]
/// 정수 num1과 num2가 매개변수로 주어집니다. 두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.
/// [제한 사항]
/// 0 ≤ num1 ≤ 10,000
/// 0 ≤ num2 ≤ 10,000
/// </summary>
namespace Level_0
{
    public class Solution008
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;
            return answer = num1 == num2 ? 1 : -1;
        }
    }
}