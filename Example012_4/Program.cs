// Вид 4

string Method4(int count, string c)
{
    int i = 0;
    string result = "";

    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);