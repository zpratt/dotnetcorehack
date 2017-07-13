# dotnetcorehack
A very basic API to get back into things with C#

## Prerequisites for Running and Writing Code
1. Install [.Net Core](https://www.microsoft.com/net/download/core)
2. Install [Install .NET Core SDK](https://www.microsoft.com/net/core#macos)
3. Install [Visual Studio Code](https://code.visualstudio.com/download)
4. Install the csharp extension for Visual Studio code within the IDE.

## Optional steps for using docker (macOS specific)

1. `brew cask install docker`
- Open docker from Applications for one-time manual setup
- `./scripts/build.sh`
- `./scripts/run.sh`
- `curl http://localhost:8080/contacts`

Use `cntl+c` to kill the running app.

## Run the app without docker
1. `dotnet restore` - this will download all the dependnecies
2. `dotnet run` - this will start the app
3. JSON request using Postman can be made to `http://localhost:5000/contacts`
