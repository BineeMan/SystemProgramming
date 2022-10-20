library DLL_Delphi;

uses
 Classes, SysUtils, Character;

function AddDelphi(val1: integer; val2: integer): integer; stdcall;

begin

Result := val1 + val2;

end;


//PWideChar - LPCWSTR
//WideString - BSTR

function isNumber(str: string): boolean; stdcall
var
  i: Integer;
  val: Integer;
  ch: Char;
begin
  for ch in str do begin
    if ( NOT(TCharacter.IsNumber(ch)) AND ( ord(ch) <> ord('.') ) ) then begin
      Result := False;
      Exit;
    end;
  end;

  Result := True;
end;

function ReadTextFileDelphi(const FileName: PWideChar; out Text: WideString; out Count: Integer): HResult; stdcall;
  var TextFile: TStringList;
  var content: TStringList;
  i, j: Integer;
  var Line: TStringList;
  var val: Double;
  var str: String;
  var NumsAmount: Integer;
           begin
            try
                TextFile := TStringList.Create;
                TextFile.create;
                TextFile.LoadFromFile(FileName);

                content := TStringList.Create;
                content.create;

                Line := TStringList.Create;
                Line.Delimiter := #9;

                Count := 0;
                for i := 0 to TextFile.Count-1 do begin
                  Line.DelimitedText := TextFile.Strings[i];
                  NumsAmount := 0;
                    for j := 0 to Line.Count-1 do begin
                      if ( isNumber(Line[j]) ) then begin
                        NumsAmount := NumsAmount + 1;
                      end
                      else begin
                        NumsAmount := 0;
                        Break;
                      end;
                  end;
                  if (NumsAmount >= 2) then begin
                    Count := Count + 1;
                    content.Append(TextFile.Strings[i]);
                  end;
                end;

                Text := content.Text;
                TextFile.Free;
                content.Free;
                Result := 1;
            except
              on E: Exception do Result := -1
            end;
           end;


exports
ReadTextFileDelphi,
AddDelphi;


begin
end.

