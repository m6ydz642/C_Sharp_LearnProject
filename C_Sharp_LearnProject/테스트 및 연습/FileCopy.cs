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

            // If the destination directory doesn't exist, create it.
            var sourcefileinfo2 = new FileInfo(sourceDirName);
            if (!destdir.Exists) // 복사될 파일에 경로가 존재하지 않으면
            {
                Directory.CreateDirectory(destDirName); // 대상 디렉토리에 폴더 생성
             // Directory.SetLastWriteTime(destDirName, sourcefileinfo2.LastWriteTime);  // 해당 destDirName 하위지정된 폴더이름을 sourceName 하위지정폴더의 마지막 작성날짜로 변경            

             // 여기서 의미없음 (재귀함수 호출시 폴더가 만들어질때 파일이 있으면 반복문을 돌면서 마지막 수정시간이 파일생성이 되면서 시스템에 의해 바뀌기 때문)

            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] sourcefiles = sourcedir.GetFiles(); // 현재 경로의 파일
            FileInfo[] destfiles = destdir.GetFiles(); // 대상 경로의 파일

            DateTime sourceLastWriteTime;
            DateTime destLastWriteTime;

            foreach (FileInfo sourcefile in sourcefiles)
            {
                // winform 사용시 Progress bar 여기다가 타이머나 반복 횟수로 로딩바 조절예정

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
                }

                if (!System.IO.File.Exists(tempPath))
                    // sourcefile 경로를 반복하고 있을때 destfileinfo 경로의 대상파일이 destfile에 존재하지않으면 
                {
                    sourcefile.CopyTo(tempPath, false); // source파일에서 destfile로 덮어쓰기 및 복사
                }
            }
            Directory.SetLastWriteTime(destDirName, sourcefileinfo2.LastWriteTime); // 디렉토리 마지막 수정시간 원상복귀 (source folder와 같이)
            // 파일추가 반복문을 다 돌고 마지막에 재귀함수 호출 시 추가된 create folder로 선택되어있는 수정시간을 가져와 적용함
            // (sourcefileinfo2 에서 재귀함수로 호출할때 선택되어있는 시간임)


            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo sourcedirinfo in sourcedirs) 
                    // 디렉토리를 재귀로 호출하기 때문에 새로운 디렉토리내에 파일이 생기면 같이 복사 or 수정검사함
                {
                    string tempPath = Path.Combine(destDirName, sourcedirinfo.Name);
                    DirectoryCopy(sourcedirinfo.FullName, tempPath, copySubDirs);
                }
            }
        }

        static void Main(string[] args)
        {
            DirectoryCopy(@"C:\Users\m6ydz642\Desktop\sourcefile", @"C:\Users\m6ydz642\Desktop\targetfile", true);
        }
    }
}
