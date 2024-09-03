using System;
/// <summary>
/// <두 수의 차>
/// [문제 설명]
/// 정수 num1과 num2가 주어질 때, num1에서 num2를 뺀 값을 return하도록 solution 함수를 완성해주세요.
/// [제한 사항]
/// -50,000 ≤ num1 ≤ 50,000
/// -50,000 ≤ num2 ≤ 50,000
/// </summary>
public class Solution002
{
    public int solution(int num1, int num2)
    {
        int answer = 0;

        if (num1 >= -50000 && num1 <= 50000 && num2 >= -50000 && num2 <= 50000)
        {
            answer = (num1 - num2);
        }

        return answer;
    }
}