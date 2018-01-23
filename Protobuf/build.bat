@echo off
setlocal

set PROTOC=..\packages\Grpc.Tools.1.8.3\tools\windows_x64\protoc.exe
set PLUGIN=..\packages\Grpc.Tools.1.8.3\tools\windows_x64\grpc_csharp_plugin.exe

%PROTOC% -I..\Protobuf --csharp_out ..\rlcx.Protobuf.Examples AddressBook.proto --grpc_out ..\rlcx.Protobuf.Examples --plugin=protoc-gen-grpc=%PLUGIN%

echo Si pas d'erreurs, c'est ok !
pause