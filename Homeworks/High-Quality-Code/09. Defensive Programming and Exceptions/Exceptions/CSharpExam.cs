namespace Exceptions
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < CSharpExam.MinScore || CSharpExam.MaxScore < value)
                {
                    throw new ArgumentOutOfRangeException("Socre", "Score should be between 0 and 100!");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, CSharpExam.MinScore, CSharpExam.MaxScore, "Exam results calculated by score.");
        }
    }
}
