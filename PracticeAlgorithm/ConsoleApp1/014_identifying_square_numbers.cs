﻿/// <summary>
/// <제곱수 판별하기>
/// [문제 설명]
/// 어떤 자연수를 제곱했을 때 나오는 정수를 제곱수라고 합니다. 정수 n이 매개변수로 주어질 때, n이 제곱수라면 1을 아니라면 2를 return하도록 solution 함수를 완성해주세요.
/// [제한 사항]
/// 1 ≤ n ≤ 1,000,000
/// </summary>

//#define sol_01
#define sol_02

using System;

namespace Level_0
{
    public class Solution014
    {
#if sol_01
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 1; i < n / 2; i++)
            {
                if (i * i == n)
                {
                    return answer = 1;
                }
                answer = 2;
            }
            return answer;
        }

#elif sol_02
        public int solution(int n)
        {
            int answer = Math.Sqrt(n) % 1 == 0 ? 1 : 2;
            return answer;
        }
#endif
    }
}