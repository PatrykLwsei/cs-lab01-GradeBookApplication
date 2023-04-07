using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private bool _isHonors;
        
        public StandardGradeBook(string name, bool isHonors) : base(name)
        {
            Type = GradeBookType.Standard;
            _isHonors = isHonors;
        }

        public StandardGradeBook(string name) : base(name)
        {
            throw new System.NotImplementedException();
        }
    }
}