namespace TestProject1;

public class ClassOccurence
{
    protected ClassPage classPage;

    public ClassPage ClassPage
    {
        get
        {
            if (classPage == null)
                classPage = new ClassPage();
            return classPage;
        }
    }
}

public class ClassPage
{
    
}