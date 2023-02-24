public partial class Program
{

    public static void Main(string[] args)
    {
        Presenter<CommonModel> presenter = new Presenter<CommonModel>(new UI(), new CommonModel());
        presenter.runOperation();

    }
}
