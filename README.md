# started with VSCode using C# and DesignPatterns
==============================

Documentation
--------------
IDE: [Visual Studio Code](//code.visualstudio.com/)
language: C#
topic: DesignPattern
[ref](//github.com/OmniSharp/omnisharp-vscode/blob/master/debugger.md)

How to run?
--------------
- download 
- VSCode Open 
- View->Integrated Terminal"(Ctrl+`)
```
$ dotnet new
$ dotnet restore
```
- .Net version
```
C:> dotnet --info
.NET Core SDK(global.json 반영):
 Version:   2.2.102
 Commit:    96ff75a873
```

How to Visual Stdio Code?
--------------
1. [Install VSCode](//code.visualstudio.com/)
2. [Install .NET command line tools](//www.microsoft.com/net/core)
```
OSX: brew install openssl 
```
3. [Install C# Extension for VS Code](//code.visualstudio.com/docs/languages/csharp)

Create to Visual Stdio Code project?
--------------
1. Visual Studio Code에서 "View->Integrated Terminal"(Ctrl+`) 터미널 창 열기
2. 프로젝트 생성 콘솔 명령어 
새로온 폴더 생성 할 경우:
```
$ cd ~
$ mkdir MyApplication
$ cd MyApplication
$ dotnet new console        // 기본 샘풀을 생성해 준다.
$ dotnet restore            // 프로젝트 리셋
& code . --user-data-dir=.  // 터미널에서 "폴더 열기" 하는 명령어
```
    
How run?
--------------
```
$ dotnet run                // 디버그 모드 실행 F5 단축키
```

3. etc
빌드 오류 "작업 'build'을(를) 찾을 수 없습니다. 
"View->Integrated Terminal"(Ctrl+`) 터미널 창 열기
```
$ mkdir vscode      // 디렉토리 생성
$ code tasks.json   // 파일 생성 아래 내용 입력
```
```
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
```
```
$ code .\.vscode\launch.json        // 실행 설정 파일 열기(생성이 되어 있음 없으면 F5눌러 생성 한다.
```
```
...
"program": "${workspaceFolder}/bin/Debug/<insert-target-framework-here>/<insert-project-name-here>.dll",
...
    위 내용중 <insert...>/<inst...> 부분을 채워 넣는 다 프레임워크 버전과 프로젝트 명을 넣는다. 아래는 예시
...
"program": "${workspaceFolder}/bin/Debug/netcoreapp2.2/MyApplication.dll",
...
```
