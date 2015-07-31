namespace Exceptions
{
    using System;

    public class MathExam : Exam
    {
        private const int MinProblems = 0;
        private const int MaxProblems = 10;
        private const int BadGrade = 2;
        private const int AverageGrade = 5;
        private const int GoodGrade = 8;

        private int problemsSolved;

        public MathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < MathExam.MinProblems || MathExam.MaxProblems < value)
                {
                    throw new ArgumentOutOfRangeException("ProblemsSolved", string.Format("Solved problems should be between {0} and {1}.", MathExam.MinProblems, MathExam.MaxProblems));
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            string comment;

            if (this.ProblemsSolved <= MathExam.BadGrade)
            {
                comment = "Bad result";
            }
            else if (this.ProblemsSolved <= MathExam.AverageGrade)
            {
                comment = "Average result";
            }
            else if (this.ProblemsSolved <= MathExam.GoodGrade)
            {
                comment = "Good result.";
            }
            else
            {
                comment = "Perfect result";
            }

            return new ExamResult(this.ProblemsSolved, MathExam.MinProblems, MathExam.MaxProblems, comment);
        }
    }
}
