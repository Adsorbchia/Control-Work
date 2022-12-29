// 
//
Console.WriteLine("Введите текст : ");
string a = Console.ReadLine()??"1"; 
Console.WriteLine("Введите текст : ");
string b = Console.ReadLine()??"1"; 
Console.WriteLine("Введите текст : ");
string c = Console.ReadLine()??"1"; 
string[]text=new string[]{ a,b,c };
Console.Write($"[{string.Join(", ", text)}] ->");
 int FindTheNumberOfRowsInTheArrayWithALengthOfNoMoreThan3(string []text1 ){
    int resalt=0;
    for(var i=0;i< text1.Length;i++){
        int count=0;
        string str= text1[i].ToString();
        foreach( var j in str){
            count++;
        }if (count <=3)
             resalt++;}
        return resalt;
    }
int res=FindTheNumberOfRowsInTheArrayWithALengthOfNoMoreThan3(text);
string[] FillANewArrayWithStringsNoLongerThan3 (int num,string[]text2 ){
    string [] text3 =new string[num];
    int index=0;
    for(var i=0;i< text2.Length;i++){int count=0;
        string str= text2[i].ToString();
        foreach( var j in str){
            count++;
        }if (count <=3){
            text3[index]=str;
            index++;
        }

} return text3;}
string[] dh= FillANewArrayWithStringsNoLongerThan3 (res,text);
Console.Write($"[{string.Join(", ", dh)}]");
