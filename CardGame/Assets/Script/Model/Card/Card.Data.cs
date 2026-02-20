

using R3;

public partial class Card
{
    public int type;
    public int num;
    public int ID;
    
    public ReactiveProperty<int> testValue = new ReactiveProperty<int>();
}