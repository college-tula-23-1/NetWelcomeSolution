using NetDataStructuresProject;

CData cData1 = new CData() { value = 1 };
CData cData2 = cData1; //new CData() { value = 1 };
Console.WriteLine(cData1.Equals(cData2));
cData2.value = 2;
Console.WriteLine(cData1.value);
Console.WriteLine();


SData sData1 = new SData() { value = 1 };
SData sData2 = sData1; //new SData() { value = 1 };
Console.WriteLine(sData1.Equals(sData2));
sData2.value = 2;
Console.WriteLine(sData1.value);

class CData
{
    public int value;
}

struct SData
{
    public int value;
}
