# design_patterns_cs
프로젝트 사용은 다운로드 후 VSCode에서 열어 사용 하면 됩니다.
.Net version은 아래와 같습니다.
C:> dotnet --info
.NET Core SDK(global.json 반영):
 Version:   2.2.102
 Commit:    96ff75a873
 

- Get started with VSCode using C# and DesignPatterns
- 참고( https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger.md )

================ 환경 설정 =================
1. Install VSCode
https://code.visualstudio.com/

2. Install .NET command line tools (C# SDK 설치)
https://www.microsoft.com/net/core

OSX: brew install openssl 

3. Install C# Extension for VS Code (C#을 활용 할 수 있는 확장자 설치)
https://code.visualstudio.com/docs/languages/csharp


================ 프로젝트 생성 =================
1. Visual Studio Code에서 "View->Integrated Terminal"(Ctrl+`) 터미널 창 열기

2. 프로젝트 생성 콘솔 명령어 
    새로온 폴더 생성 할 경우
    $ cd ~
    $ mkdir MyApplication
    $ cd MyApplication
    $ dotnet new console        // 기본 샘풀을 생성해 준다.
    $ dotnet restore            // 프로젝트 리셋
    & code . --user-data-dir=.  // 터미널에서 "폴더 열기" 하는 명령어
    
    프로젝트 실행
    $ dotnet run                // 디버그 모드 실행 F5 단축키

3. 기타 
빌드 오류 "작업 'build'을(를) 찾을 수 없습니다. " 
"View->Integrated Terminal"(Ctrl+`) 터미널 창 열기

$ mkdir vscode      // 디렉토리 생성
$ code tasks.json   // 파일 생성 아래 내용 입력
{
    "version": "0.1.0",
    "command": "dotnet",
    "isShellCommand": true,
    "args": [],
    "options":  {
        "cwd": "${workspaceRoot}/"
    },
    "tasks": [
        {
            "taskName": "build",
            "args": [ ],
            "isBuildCommand": true,
            "problemMatcher": "$msCompile"
        }
    ]
}

$ code .\.vscode\launch.json        // 실행 설정 파일 열기(생성이 되어 있음 없으면 F5눌러 생성 한다.
...
"program": "${workspaceFolder}/bin/Debug/<insert-target-framework-here>/<insert-project-name-here>.dll",
...
    위 내용중 <insert...>/<inst...> 부분을 채워 넣는 다 프레임워크 버전과 프로젝트 명을 넣는다. 아래는 예시
...
"program": "${workspaceFolder}/bin/Debug/netcoreapp2.2/MyApplication.dll",
...


*/
