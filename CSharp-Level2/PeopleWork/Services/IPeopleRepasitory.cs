namespace PeopleWork.Services
{
    public interface IPeopleRepasitory
    {
        void AddPeople();
        string SearchPeople(double salery);
        string SearchPeople(decimal carPrice);
        string SearchPeople(int familyCount);
        string SearchPeople(string name);
    }
}