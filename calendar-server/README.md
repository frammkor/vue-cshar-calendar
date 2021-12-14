# CS 1410 Object-Oriented Programming - Final Project
This project intended to be a full stack app using Vue.js for the front end and C# for the server.
In the future it will be fully RESTful and use a DataBase, but right now is only using in memory or in file information to respond to only GET requests.

## TESTING

The test where run by using visual studio code debugger.
There is a .vscode folder in each minirepo (client and server)
On the server's launch.json file use the following code:
...
{
	"version": "0.2.0",
	"configurations": [
		{
			// Use IntelliSense to find out which attributes exist for C# debugging
			// Use hover for the description of the existing attributes
			// For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md
			"name": ".NET Core Launch (web)",
			"type": "coreclr",
			"request": "launch",
			"preLaunchTask": "build",
			// If you have changed target frameworks, make sure to update the program path.
			"program": "${workspaceFolder}/Events.Api/bin/Debug/net5.0/Events.Api.dll",
			"args": [],
			"cwd": "${workspaceFolder}/Events.Api",
			"stopAtEntry": false,
			// Enable launching a web browser when ASP.NET Core starts. For more information: https://aka.ms/VSCode-CS-LaunchJson-WebBrowser
			"serverReadyAction": {
				"action": "openExternally",
				"pattern": "\\bNow listening on:\\s+(https?://\\S+)"
			},
			"env": {
				"ASPNETCORE_ENVIRONMENT": "Development"
			},
			"sourceFileMap": {
				"/Views": "${workspaceFolder}/Events.Api/Views"
			}
		},
		{
			"name": ".NET Core Attach",
			"type": "coreclr",
			"request": "attach"
		}
	]
}

...