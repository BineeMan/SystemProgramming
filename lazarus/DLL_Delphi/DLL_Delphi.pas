library DLL_Delphi;

uses
 Classes, SysUtils;

function Add2(val1: integer; val2: integer): integer; stdcall;

begin

Result := val1 + val2;

end;


//PWideChar - LPCWSTR
//WideString - BSTR

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

exports
GetFileContent_Delphi,
Add2;


begin

end.
