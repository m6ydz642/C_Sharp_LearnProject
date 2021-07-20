using System;
using System.IO;

namespace FileCopy
{
   
    class FileCopy
    {

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo sourcedir = new DirectoryInfo(sourceDirName);
            DirectoryInfo destdir = new DirectoryInfo(destDirName);

            if (!sourcedir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] sourcedirs = sourcedir.GetDirectories();
            DirectoryInfo[] destdirs = destdir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] sourcefiles = sourcedir.GetFiles(); // 현재 경로의 파일
            FileInfo[] destfiles = destdir.GetFiles(); // 대상 경로의 파일

            DateTime sourceLastWriteTime;
            DateTime destLastWriteTime;
            string sourceFileName;
            string destFileName;

  

            foreach (FileInfo sourcefile in sourcefiles)
            {
                string tempPath = Path.Combine(destDirName, sourcefile.Name);
                var sourcefileinfo = new FileInfo(sourceDirName + "\\" + sourcefile.Name);

                sourceLastWriteTime = sourcefileinfo.LastWriteTime;

                foreach (FileInfo destfile in destfiles) // sourcefiles를 대상으로 상대 destdir경로의 파일들을 검색 함
                {
                    var destfileinfo = new FileInfo(destDirName + "\\" + destfile.Name);
                    destLastWriteTime = destfileinfo.LastWriteTime;

                    if (sourcefile.Name.Equals(destfile.Name) && !sourceLastWriteTime.Equals(destLastWriteTime))
                        // 파일이름은 같은데 파일날짜가 동일하지 않다면, 파일이 수정 및 교체된 것으로 간주
                    {
                            sourcefile.CopyTo(tempPath, true); // source파일에서 destfile로 덮어쓰기 및 복사
                    }
                    if (!System.IO.File.Exists(tempPath))// destfile경로를 반복하고 있을때 source경로의 대상파일이 destfile에 존재하지않으면 
                    {
                        sourcefile.CopyTo(tempPath, false); // source파일에서 destfile로 덮어쓰기 및 복사
                    }

                }
               
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in sourcedirs) // 폴더 복사도 위 파일과 동일하게 해볼예정
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        static void Main(string[] args)
        {
            DirectoryCopy(@"C:\Users\m6ydz642\Desktop\sourcefile", @"C:\Users\m6ydz642\Desktop\targetfile", true);
        }
    }
}
