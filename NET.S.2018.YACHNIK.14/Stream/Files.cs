using System;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace FileWorks
{
    public class Files
    {
        #region Public API

        public static int ByByteCopy(string pathFrom, string pathTo)
        {
            Validation(pathFrom, pathTo);
            using (FileStream streamReader = File.OpenRead(pathFrom))
            {
                using (FileStream streamWriter = File.OpenWrite(pathTo))
                {
                    int b = default(int);
                    while ((b = streamReader.ReadByte()) != -1)
                    {
                        streamWriter.WriteByte((byte)b);
                    }

                    return (int)streamWriter.Length;
                }
            }
        }

        public static int InMemoryByByteCopy(string pathFrom, string pathTo)
        {
            Validation(pathFrom, pathTo);
            byte[] data = default(byte[]);
            using (StreamReader streamRead = new StreamReader(pathFrom))
            {           
                byte[] fileBytes = Encoding.UTF8.GetBytes(streamRead.ReadToEnd());
                using (MemoryStream streamMemory = new MemoryStream(fileBytes))
                {
                    data = streamMemory.ToArray();
                }
            }
            using (StreamWriter streamWrite = new StreamWriter(pathTo))
            {
                char[] fileBytes = Encoding.UTF8.GetChars(data);
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    streamWrite.Write(fileBytes[i]);
                }
                return fileBytes.Length;
            }
        }

        public static int ByBlockCopy(string pathFrom, string pathTo)
        {
            Validation(pathFrom, pathTo);
            using (FileStream streamRead = File.OpenRead(pathFrom))
            {
                using (FileStream streamWrite = File.OpenWrite(pathTo))
                {
                    streamRead.CopyTo(streamWrite);
                    return (int)streamWrite.Length;
                }
            }
        }

        public static int InMemoryByBlockCopy(string pathFrom, string pathTo)
        {
            Validation(pathFrom, pathTo);
            byte[] data;
            using (StreamReader streamRead = new StreamReader(pathFrom))
            {
                byte[] fileBytes = Encoding.UTF8.GetBytes(streamRead.ReadToEnd());
                using (MemoryStream streamMemory = new MemoryStream(fileBytes))
                {
                    data = streamMemory.ToArray();
                }
            }

            using (StreamWriter streamWrite = new StreamWriter(pathTo))
            {
                char[] fileBytes = Encoding.UTF8.GetChars(data);
                streamWrite.Write(fileBytes);
                return fileBytes.Length;
            }
        }

        public static int BufferedCopy(string pathFrom, string pathTo)
        {
            Validation(pathFrom, pathTo);
            byte[] data = File.ReadAllBytes(pathFrom);
            using (FileStream streamWrite = File.Open(pathTo, FileMode.Create))
            {
                using (BufferedStream streamBuffer = new BufferedStream(streamWrite))
                {
                    streamBuffer.Write(data, 0, data.Length);
                    return (int)streamWrite.Length;
                }

            }
        }

        public static int ByLineCopy(string pathFrom, string pathTo)
        {
            int counter = 0;
            using (StreamReader streamReader = new StreamReader(pathFrom, System.Text.Encoding.Default))
            {
                using (StreamWriter streamWriter = new StreamWriter(pathTo, false, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        streamWriter.WriteLine(line);
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static bool IsContentEquals(string pathFrom, string pathTo)
        {
            Validation(pathFrom, pathTo);
            if (pathFrom == pathTo)
            {
                return true;
            }

            using (FileStream fileFrom = new FileStream(pathFrom, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fileTo = new FileStream(pathTo, FileMode.Open, FileAccess.Read))
                {
                    for (int i = 0; i < fileFrom.Length; i++)
                    {
                        if (fileFrom.ReadByte() != fileTo.ReadByte())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        #endregion

        #region Private members

        private static void Validation(string pathFrom, string pathTo)
        {
            if (pathFrom == null)
            {
                throw new ArgumentNullException(nameof(pathFrom));
            }

            if (pathTo == null)
            {
                throw new ArgumentNullException(nameof(pathTo));
            }

            if (!File.Exists(pathFrom))
            {
                throw new FileNotFoundException(nameof(pathFrom));
            }

            if (!File.Exists(pathTo))
            {
                throw new FileNotFoundException(nameof(pathTo));
            }
        }

        #endregion
    }
}
