using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Editor
{
    public class TextDocument
    {
        private string _DefaultName = "isimsiz";
        private FileInfo fileInfo;

        public string Title
        {
            get
            {
                if (IsModified)
                    return Name + "*";
                else
                    return Name;
            }
        }

        public string Name
        {
            get
            {
                //if (fileInfo != null && fileInfo.Name != "")
                if (fileInfo?.Name != "")
                        return fileInfo.Name;
                else
                    return _DefaultName;
            }
        }

        private string _FullName;

        public string FullName
        {
            get { return _FullName; }
            set
            {
                _FullName = value;
                fileInfo = new FileInfo(value);
            }
        }
        public bool IsModified { get; set; } = false;
        private string _Body = "";
        public string Body
        {
            get { return _Body; }
            set
            {
                _Body = value;
                IsModified = true;
            }
        }


        public int CharCount
        {
            get
            {
                if (String.IsNullOrEmpty(Body))
                {
                    return 0;
                }
                else
                {
                    return Body.Length;
                }

            }
        }
        public int WordCount => String.IsNullOrEmpty(Body) ? 0 : Body.Split(' ').Length;

    }
}
