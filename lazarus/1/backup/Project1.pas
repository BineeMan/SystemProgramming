program Project1;

uses
 Classes, SysUtils;

var filePath: PWideChar;

function GetFileContent_Delphi(filePath: PWideChar ): WideString; stdcall;
         var tstr2: TStringList;
         var wstring: WideString;
           begin
                tstr2 := TStringList.Create;
                tstr2.create;
                tstr2.LoadFromFile(filePath);
                wstring := tstr2.Text;
                tstr2.Free;
                Result := wstring;
           end;

begin
  filePath := 'E:\SystemProgramming\Files\test2.txt';
  writeln(GetFileContent_Delphi(filePath));
  readln();
end.

