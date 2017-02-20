﻿@rem Generate the C# code for .proto files

setlocal

@rem enter this directory
cd /d %~dp0

@rem set TOOLS_PATH=..\packages\Grpc.Tools.0.14.0\tools\windows_x86

set TOOLS_PATH=..\packages\Grpc.Tools.0.14.0\tools\windows_x86

%TOOLS_PATH%\protoc.exe -I protos --csharp_out gen  protos/Order.proto --grpc_out gen --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe

endlocal