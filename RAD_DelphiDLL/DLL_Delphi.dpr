library DLL_Delphi;

uses
 Classes, Character, ComObj, ActiveX, Variants, Windows, Messages, SysUtils,
 Vcl.Forms, Unit1 in '..\RAD_FormApp\Unit1.pas';

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

function ConvertTableToExcel(FileName: PWideChar) : HResult; stdcall;
var
  i, i2, j2: integer;
  MyExcel: OleVariant;
  Text: WideString;
  textStr: string;
  num: string;
  Count: Integer;
  FormatBr: TFormatSettings;
begin
  try
    begin
          FormatBr:= TFormatSettings.Create;
          FormatBr.DecimalSeparator := '.';
          System.SysUtils.FormatSettings := FormatBr;

          CoInitialize(Nil);
          MyExcel:=CreateOleObject('Excel.Application');
          MyExcel.Workbooks.Add;
          ReadTextFileDelphi(FileName, Text, Count);
          textStr :=  Text;
          textStr := StringReplace(textStr, #$D#$A, #10, [rfReplaceAll]);
          i2 := 0;
          j2 := 0;
          num := '';
          for i := 1 to Length(textStr) do begin
            if textStr[i] = #10 then begin
              MyExcel.Cells[i2 + 1, j2 + 1] := num;

              MyExcel.Cells[i2 + 1, 7].Formula:='=SUM(A'+FloatToStr(i2+1)+':E'+FloatToStr(i2+1)+')';
              MyExcel.Cells[i2 + 1, 8].Formula:='=AVERAGE(A'+FloatToStr(i2+1)+':E'+FloatToStr(i2+1)+')';
              i2 := i2 + 1;
              num := '';
              j2 := 0;
            end
            else begin
              if textStr[i] = #9 then begin
                MyExcel.Cells[i2 + 1, j2 + 1] := num;
                num := '';
                j2 := j2 + 1;
              end
              else begin
                num := num + textStr[i];
              end;
            end;
          end;

          MyExcel.Application.EnableEvents:=false;
          MyExcel.Visible:=true;
          Result:=1;
    end
  except
    on E: Exception do Result := -1
  end;
end;


type PDrawCallback1 =
    function (  FileName: PWideChar;
     Width: Integer; Height: Integer; out MyBmb: HBITMAP): HResult; stdcall;

function GetExternalWindow( DrawCallback1: PDrawCallback1;
  HInWindow: HWND; HOutWindow: HWND;
    StatusInfo: WideString; lpReserved: Integer) : HResult; stdcall;
begin
  try
    begin

      Application.Initialize;
      Application.MainFormOnTaskbar := True;
      Application.CreateForm(TForm1, Form1);

      Form1.DrawCallback := DrawCallback1;
      Form1.HInWindow := HInWindow;

      Application.Run;

      Result:=1;
    end
  except
    on E: Exception do Result := -1
  end;

end;

exports
  ReadTextFileDelphi,
  AddDelphi,
  ConvertTableToExcel,
  GetExternalWindow,
  GetExternalWindow2,
  GetExternalWindow3;
begin

end.

