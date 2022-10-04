program ConsoleProject;

{$APPTYPE CONSOLE}

{$R *.res}

uses
 Classes, SysUtils, Character;

var filePath: PWideChar;

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

function ReadTextFile_Delphi(const FileName: PWideChar; out Text: WideString; out Count: Integer): HResult; stdcall;
  var TextFile: TStringList;
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

                Line := TStringList.Create;
                Line.Delimiter := #9;

                //Line.DelimitedText := TextFile.Strings[0];
                //writeln(Line.Count - 1);

                Count := 0;
                for i := 0 to TextFile.Count-1 do begin
                  Line.DelimitedText := TextFile.Strings[i];
                  NumsAmount := 0;
                  //writeln(Line.Count-1);
                    for j := 0 to Line.Count-1 do begin
                      //writeln('Строка = ', i ,' Номер симола = ', j ,' Символ = ', Line[j]);
                      if ( isNumber(Line[j]) ) then begin
                        NumsAmount := NumsAmount + 1;
                      end
                      else begin
                        NumsAmount := 0;
                        writeln('Строка = ', i ,' Номер симола = ', j ,' Символ = ', Line[j]);
                        Break;
                      end;
                  end;
                  if (NumsAmount >= 2) then begin
                    Count := Count + 1;
                  end;

                end;


                writeln( Count );

                Text := TextFile.Text;
                TextFile.Free;
                Result := 2;
            except
              on E: Exception do Result := -1
            end;
           end;

var Count: Integer;
var Text: WideString;

begin
  filePath := 'E:\SystemProgramming\Files\test.tsv';
  ReadTextFile_Delphi(filePath, Text, Count);
  //writeln(IsNumber('12.0'));

  Readln;
end.
