using System;
using System.Collections.Generic;

namespace VogCodeChallenge.Console
{
    public class QuestionClass
    {
        public static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static T TESTModule<T>(T input)
        {
            var caseValue = DetermineCase(input);

            switch (caseValue)
            {
                case "A":
                    return (T)Convert.ChangeType(Convert.ToInt32(input) * 2, typeof(T));
                case "B":
                    return (T)Convert.ChangeType(Convert.ToInt32(input) * 3, typeof(T));
                case "C":
                    throw new ArgumentOutOfRangeException();
                case "D":
                    return (T)Convert.ChangeType(3.0f, typeof(T));
                case "E":
                    return (T)Convert.ChangeType(input.ToString()?.ToUpper(), typeof(T));
                case "F":
                    return input;
                default:
                    return input;
            }
        }

        private static string DetermineCase<T>(T input)
        {
            if (typeof(T) == typeof(int))
            {
                if (Convert.ToInt32(input) >= 1 && Convert.ToInt32(input) <= 4) return "A";
                if (Convert.ToInt32(input) <= 0) return "C";
                return "B";
            }

            if (typeof(T) == typeof(float))
            {
                if (Math.Abs((float)(object)input - 1.0f) < 0.001 || Math.Abs((float)(object)input - 2.0f) < 0.001)
                    return "D";
            }

            if (typeof(T) == typeof(string))
            {
                if (!string.IsNullOrWhiteSpace(input.ToString()))
                    return "E";
            }

            return "F";
        }
    }
}
