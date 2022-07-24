using Task_004;

MyDictionary instance = new MyDictionary();

try
{
    instance.Translate("сонце", "eng");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    instance.Translate("птах", "rus");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
