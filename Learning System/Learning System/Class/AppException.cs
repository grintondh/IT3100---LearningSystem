namespace Learning_System.Class
{
    public class E01CantFindFile : Exception
    {
        public E01CantFindFile() { }
        public E01CantFindFile(string path) : base("[E01] Can't get information from " + path + ". Your file may not found in selected folder or be broken!") { }
    }

    public class E02CantGetCategoryName : Exception
    {
        public E02CantGetCategoryName() { }
        public E02CantGetCategoryName(string categoryName) : base("[E02] Can't get category name " + categoryName + ". This name may not correct or your file doesn't have this element!") { }
    }

    public class E03EmptyData : Exception {
        public E03EmptyData() { }
        public E03EmptyData(string database) : base("[E02] Can't process " + database + " because it has no data. Your database name or queries may be not correct!") { }
    }
    public class E99OtherException : Exception
    {
        public E99OtherException() { }
        public E99OtherException(string message) : base("[E99] Something got error.\nDescription:" + message) { }
    }
}
