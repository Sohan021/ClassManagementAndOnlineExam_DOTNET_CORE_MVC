﻿namespace onlineexam.Models.Quiz
{
    public class TestQuestion
    {
        public int Id { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }

        public string CurrectAnswer { get; set; }

        public int TestId { get; set; }

        public Test Test { get; set; }
    }
}
