namespace Days_21.utils
{
    public class FileControl
    { 
        public void WriteToFile(string content)
        {
            //File.WriteAllText("file.txt", content);
            File.AppendAllText("file.txt", content); 
        }
    }
}