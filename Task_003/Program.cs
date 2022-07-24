using Task_003;

ICollection<FamilyMember> myFamilyTree = new FamilyTree<FamilyMember>();

#region Заполнение дерева

// 1-ый уровень дерева. 
myFamilyTree.Add(new FamilyMember("Таранов В.Ф.", 1990, 0, 1));

// 2-ой уровень дерева. 
myFamilyTree.Add(new FamilyMember("Таранов Л.С.", 1968, 1, 2));
myFamilyTree.Add(new FamilyMember("Таранова У.В.", 1968, 2, 2));

// 3-ий уровень дерева. 
myFamilyTree.Add(new FamilyMember("Никитин А.В.", 1947, 3, 3));
myFamilyTree.Add(new FamilyMember("Никитина В.М.", 1946, 4, 3));
myFamilyTree.Add(new FamilyMember("Аврин А.В.", 1946, 5, 3));
myFamilyTree.Add(new FamilyMember("Аврина В.М.", 1945, 6, 3));

// 4-ый уровень дерева. 
myFamilyTree.Add(new FamilyMember("Рылов А.В.", 1922, 7, 4));
myFamilyTree.Add(new FamilyMember("Рылова В.М.", 1921, 8, 4));
myFamilyTree.Add(new FamilyMember("Марковкин А.В.", 1918, 9, 4));
myFamilyTree.Add(new FamilyMember("Марковкина В.М.", 1920, 10, 4));
myFamilyTree.Add(new FamilyMember("Свеклов А.В.", 1923, 11, 4));
myFamilyTree.Add(new FamilyMember("Свеклова В.М.", 1924, 12, 4));
myFamilyTree.Add(new FamilyMember("Латин А.В.", 1922, 13, 4));
myFamilyTree.Add(new FamilyMember("Латина В.М.", 1921, 14, 4));

// 5-ый уровень дерева (1 человек). 
myFamilyTree.Add(new FamilyMember("Тошковский В.М.", 1900, 30, 5));

// 6-ой уровень дерева (1 человек).
myFamilyTree.Add(new FamilyMember("Сергеев В.М.", 1880, 31, 6));

#endregion

// Удаление элиментов из коллекции. 
myFamilyTree.Remove(new FamilyMember("Сергеев В.М.", 1880, 31, 6));

// Поиск родственников по году рождения.
Console.WriteLine("Поиск по году рождения : ");

var selectByYear = from p in myFamilyTree
                   where p.GetYear == 1946
                   orderby p.GetYear ascending
                   select p;

foreach (var item in selectByYear)
    item.Show();

Console.WriteLine(new String('-', 25));

// Количество людей в списке.
Console.WriteLine($"Всего в списке : " +
    $"{myFamilyTree.Count} человек(а)");

Console.WriteLine(new String('-', 18));

// Поиск всех наследников.
Console.WriteLine("Поиск наследников : ");

FamilyTree<FamilyMember> fm 
    = (FamilyTree<FamilyMember>)myFamilyTree;

var allIn 
    = fm.HeritanceSearch(new FamilyMember("Тошковский В.М.", 1900, 30, 5), 
    myFamilyTree);

foreach (var item in allIn)
{
    item.Show();
}