using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Magazine: выпускной номер(IssueNumber).

namespace AbstractClass3
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; private set; } //выпускной номер.
        public Magazine(string title, string author, int issueNumber) : base(title, author)
        {
            IssueNumber = issueNumber;
        }
        public override string GetInfo()
        {
            return $"Журнал \'{Title}\',\nавтор - {Author},\tвыпускной номер - {IssueNumber}";
        }
    }
}
