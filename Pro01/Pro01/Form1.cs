using System;
using System.Collections.Generic; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace Pro01 
{
    public partial class FormTest1 : Form
        
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string Section, string key, string def, StringBuilder sb, int size, string path);
        

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string Section, string key, string val, string path);
      


        public FormTest1() 
        {
            InitializeComponent();
        }

        int cn1, cn2,cn3, cn4, cn5;

        

        // Call 버튼!
        // 항목별 입력값 출력 + NoOp 버튼 Ready로 체인지 
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.cn1 = cn1;
            dlg.cn2 = cn2;
            dlg.cn3 = cn3;
            dlg.cn4 = cn4;
            dlg.cn5 = cn5;

            DialogResult dr = dlg.ShowDialog(); 
           
            if(dr == DialogResult.OK) // C#에서는 꼭 DialogResult.OK라는 식으로 strict하게 표현해 줘야 해!
            {
                cn1 = dlg.cn1;
                cn2 = dlg.cn2;
                cn3 = dlg.cn3;
                cn4 = dlg.cn4;
                cn5 = dlg.cn5; // 입력값 저장해 뒀던 거 다시 dialog에 출력

                sStr = string.Format("{0},{1},{2},{3},{4}", dlg.as1, dlg.as2, dlg.as3, dlg.as4, dlg.as5);
                //MessageBox.Show(sStr);
                //MessageBox.Show("WOW! OK button pressed! ");
                tbTest.Text = sStr;
                btnNoop.Text = "Ready"; //버튼 위의 글자 -> No Operation -> Ready로 변경!
            }
        }

        // NoOp 버튼 눌렀을 때  -> 이름만 추출해 출력하기
        private void btnNoop_Click(object sender, EventArgs e)
        {
            if(btnNoop.Text == "Ready")
            {
                // MessageBox.Show("자 이제 뭔가 할 시간입니다 ㅠ");
                // Mission!  이름만 추출하세요! -> 첫번째 컴마(,)와 컴마(,)사이 값 추출해 오면 되겠지!
                // string.Indexof(), string.SubString()
                // string s1 = sStr.Substring(10); // 10번째 글자부터 마지막 문자열까지 잘라서 new Substring에 저장
                //int n1 = sStr.IndexOf(",");
                //int n2 = sStr.IndexOf(",", n1 + 1);
                //int k = n2 - n1 -1;
                //int next_n = sStr.IndexOf(",", sStr.IndexOf(",")+1);
                //string s1 = sStr.Substring( n1 + 1, k );
                //MessageBox.Show(s1);
                //tbTest.Text = s1;

                /* 해답 알고리즘 구상
                 * 구분자(",")가 위치한 첫 번째 인덱스 찾기 => n1
                 * 다음 구분자 가진 두 번째 인덱스 찾기 => n2
                 * 구분할 문자열 길이는 n2 - n1 -1 => k
                 */

                //함수 써먹기!
                tbTest.Text = GetToken(sStr, ",",1);
            }
        }
        
        public string GetToken(string str, string sep, int n)
        {
            // 함수로 일반화 알고리즘
            // 함수명 : GetToken 
            // 인수로 주어진 문자열에 대하여 주어진 구분자로 구분되는 필드의 n번째 데이터를 추출하여 되돌려 주는 일반 함수
            // 인수(argument) -> string str, string seperator, int field_index (필드의 위치)
            // str : 대상 문자열
            // seperator : 구분자
            // field_index : 구분자로 구분되는 필드 번호
            // return : string sRet  ->  sRet : 추출된 문자 데이터
            // 해당 데이터 없을 경우 "" (빈 문자열) 반환
            // error : 발생 가능한 에러는 ?

            // for loop를 사용하여 n번째 구분자를 탐색
            // n번째 구분자 이후 n+1번째 구분자 탐색
            // 문자열 길이 계산
            // 문자열 추출 : Substirng 메쏘드 사용

            int i;  // int i, j, k; -> for문 사용 시 미리 몇 개 쓸만한 애들 선언해 놓는 거 추천
            int n1 = 0, n2 = 0, n3 = 0;
            for (i = 0; i < n; i++)
            {
                n1 = str.IndexOf(sep, n1) + 1; // n번째 구분자 
                // IndexOf 함수 -> 해당하는 값이 없을 경우 -> -1 반환
                if (n1 == 0) return "";
            }
            n2 = str.IndexOf(sep, n1); // n+1번째 구분자
            if (n2 == -1) n2 = str.Length; // 만약 ","가 앞에 1개밖에 존재 안 할 경우... -> ex) ,홍길동    과 같은 경우?? -> n2 = -1

            n3 = n2 - n1; // 문자열 길이 계산

            string sRet = str.Substring(n1, n3);
            return sRet;
        }


        string sPath = @"C:\Users\kosta\source\repos\Pro01\Pro01\bin\Debug\WinApp1.ini"; // ini 파일 생성 & 이름 정의
        // 경로 설정 안하면 자동으로 현재 작업중인 폴더에 저장되지만 다른 곳에 저장될 수 있으니 주의 .\\으로 현재경로 설정
        // @ 붙여주면 "" 안에 있는 문자열 중에서 escape sequence(\로 시작되는 2개이상 제어문자 ex.\n)를 무시해라 라는 의미 -> .\만 써줘도 됨
        // 만약 내 현재 위치가 검색 안되면(or 오류 나면) full path로 주소 넣음 됨 "C:\Users~"

        public int GetInI_Int(string sec, string key, int def = 0) // 선택적 변수 초기화 -> 특별히 default value 설정 안 해줄 때는 그냥 '0'으로 띄워줘라!
        {
            // 설정값 변경하는 기능 함수의 일반화(#2) -> GetInI_Int(string section, string key, int def);
            // 인수 (Arg) section : ini 파일의 Section 이름
            // key : key 이름
            // def : default int value
            // return : nValue : ini 파일에 추출한 파라미터 값(int)

            StringBuilder sb = new StringBuilder();
            // String Builder -> string이랑 거의 비슷하지만 문자열이 빈번히 갱신되는 경우 -> 동적으로 메모리 할당하는 애! -> 그냥 비용 면에서 이득!
            // using System.Text;  라이브러리 필요!
            // [ example ] 
            // for (int i=0; i<=26; i++)
            // { sb.Append(i.ToString());  //계속 문자열을 attach
            //   sb.Append(System.Environment.NewLine); }  // CRLF
            // string s = sb.ToString(); -> 스트링 빌더 출력할 때는 변환해서 출력해 줘야해
            // Cosole.WriteLine(s);

            GetPrivateProfileString(sec, key, $"{def}", sb, 500, sPath);    // 'sb' means -> string builder
            int nVal = int.Parse(sb.ToString());
            return nVal;
        }
        public string GetInI_String(string sec, string key, string def = "")
        {
            // 함수의 일반화(#3) -> GetInI_String(string section, string key, string def);
            // 인수 (Arg) section : ini 파일의 Section 이름
            // key : key 이름
            // def : default string value
            // return : sValue : ini 파일에 추출한 파라미터 값(string)
           
            StringBuilder sb = new StringBuilder();
            GetPrivateProfileString(sec, key, def, sb, 500, sPath);
            string sVal = sb.ToString();
            return sVal;
        }



        private void FormTest1_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            cn1 = GetInI_Int("Form2 Combo Set", "cn1");
            cn2 = GetInI_Int("Form2 Combo Set", "cn2");
            cn3 = GetInI_Int("Form2 Combo Set", "cn3");
            cn4 = GetInI_Int("Form2 Combo Set", "cn4");
            cn5 = GetInI_Int("Form2 Combo Set", "cn5");

            /*GetPrivateProfileString("Form2 Combo Set", "cn2", "0", sb, 500, sPath); cn2 = int.Parse(sb.ToString());
            GetPrivateProfileString("Form2 Combo Set", "cn3", "0", sb, 500, sPath); cn3 = int.Parse(sb.ToString());
            GetPrivateProfileString("Form2 Combo Set", "cn4", "0", sb, 500, sPath); cn4 = int.Parse(sb.ToString());
            GetPrivateProfileString("Form2 Combo Set", "cn5", "0", sb, 500, sPath); cn5 = int.Parse(sb.ToString());*/
            // 가운데 "0" -> default value

            //form의 위치와 사이즈도 설정

            this.Width = GetInI_Int("Window Configuration", "Width", 1000);
            this.Height = GetInI_Int("Window Configuration", "Height", 700);
            this.Text = GetInI_String("Window Configuration","Title");

            /*GetPrivateProfileString("Window Configuration", "Width", "1000", sb, 500, sPath); this.Width = int.Parse(sb.ToString());
            GetPrivateProfileString("Window Configuration", "Height", "700", sb, 500, sPath); this.Height = int.Parse(sb.ToString());*/
            //size 사용하는 방식도 있는듯
        }

        private void FormTest1_FormClosed(object sender, FormClosedEventArgs e)
        {
            WritePrivateProfileString("Form2 Combo Set", "cn1", $"{cn1}", sPath);
            WritePrivateProfileString("Form2 Combo Set", "cn2", $"{cn2}", sPath);
            WritePrivateProfileString("Form2 Combo Set", "cn3", $"{cn3}", sPath);
            WritePrivateProfileString("Form2 Combo Set", "cn4", $"{cn4}", sPath);
            WritePrivateProfileString("Form2 Combo Set", "cn5", $"{cn5}", sPath);
            // int를 string으로 바꿀 때 보간문자열(String interpolation) 처리 $"{}" == string.Format("{0}",cn1)
            // string.Format("{0}",cn1)  대체!
            // string.Format("stringFormatText", arg1, arg2, arg3...); 대신 사용 간편

            WritePrivateProfileString("Window Configuration", "Width", $"{this.Width}", sPath);
            WritePrivateProfileString("Window Configuration", "Height", $"{this.Height}", sPath);
            WritePrivateProfileString("Window Configuration", "Title", $"{this.Text}", sPath);
        }
        


        private void comboIndex_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /*// int sel_num = int.Parse(comboIndex.SelectedItem.ToString());
            int sel_num_first_try = int.Parse(comboIndex.Text);
            //comboBox 창에 표시된 문자열 -> combobox위에 바로 내용 입력해 버리는 것도 가능하기는 해...
            // 이걸 막으려면 어떻게 하지?? (숫자가 아니라 문자가 입력될 수도 있고...)

            int sel_num_second_try = int.Parse(comboIndex.Items[comboIndex.SelectedIndex].ToString());
            // combobox의 아이템들 중에서 선택된 인덱스를 가져오라는 의미!

            tbTest.Text = GetToken(sStr, ",", sel_num_second_try);*/

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string s1 = GetToken(sStr, ",", 4);
            int n = int.Parse(s1);
            
            // int sel_num_first_try = int.Parse(comboIndex.Text);
            // break point 설정하고 디버깅 -> 중간중간 값 어떻게 대입되어있나 확인 가능 -> 임의로 변수에 들어가는 값도 변경해서 돌려보기도 가능!
            // int sel_num_second_try = int.Parse(comboIndex.Items[comboIndex.SelectedIndex].ToString());
            // tbTest.Text = GetToken(sStr, ",", sel_num_second_try);
            
            //tbTest.Text = string.Format("{0,10}", n);
            // string format { 변수 인덱스, 자릿수(생략하면 그냥 기본 자릿수):변환문자 } 의 형태
            //c에서 printf("%3d \n", 12345) 앞에꺼 세 자리 까지만! 와 같은 기능
            // '\n'의 역할 -> '\r\n'  \r: Carriage Return / Line Feed -> CRLF의 구조 -> 새로운 줄로 바꾸는 방식 의미!
            
            //tbTest.Text = string.Format("{0,10} \r\n {1:C} \r\n {2:E} \r\n {3:F2} \r\n {4:P} \r\n {5:X} \r\n {6:X}", 2.5, 2.5, 250000, 25, 2468013, 250, 0xffff);
            tbTest.Text = string.Format("{0,10} \r\n {1:C} \r\n {2:E} \r\n {3:F2} \r\n {4:P} \r\n {5:X} \r\n {6:X}", n, n, n, n, n, n, n);

            // tbTest.Text = string.Format("{0,10:C} \r\n", 2.5);
            // tbTest.Text += string.Format("{0, 10:C}", -2.5);
            // += 사용 -> 텍스트 박스에 내용 계속 더해가며 출력이 가능
        }

        private void tbTest_TextChanged(object sender, EventArgs e)
        {
            //tbTestPrint.Text = string.Format("{0:X}", int.Parse(str));
            
            string str = tbTest.Text;
            int i, j = 1;
            StringBuilder sb = new StringBuilder();

            tbTestPrint.Text = ""; // for 루프 들어가기 전에 print창 클리어 해놓고

            for (i=0; i < str.Length; i++) { 
            char input_value = str[i];   // 문자'열' 기본적으로 byte로 취급
            byte casted_value = (byte)input_value;  // byte : 1byte int

            //tbTestPrint.Text += string.Format("{0:X2} ", (casted_value));
            sb.Append($"{casted_value:X2} ");  //append문에서도 hexa로 출력하는 게 먹힘!

            //if((i+1) % char_num == 0) 일때 tbTestPrint.Text += "\r\n"; 이것도 가능!
            if (CharNum.Text != "") {
            int char_num = int.Parse(CharNum.Text);
            if (i == (char_num * j)-1) {
                //tbTestPrint.Text += "\r\n";
                sb.Append("\r\n");
                j++;
            }
            }
            }
            tbTestPrint.Text = sb.ToString();
        }
    }
}
