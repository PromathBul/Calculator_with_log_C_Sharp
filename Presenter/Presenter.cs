public class Presenter<T>
{
    UI v;
    T model;

    /**
     * Конструктор объекта типа Presenter
     * @param v - объект типа UI
     * @param model - объект типа CommonModel
     */
    public Presenter(UI v, T model)
    {
        this.model = model;
        this.v = v;
    }

    /**
     * Основной метод, объединяющий получений значений, выбор операции, получение результата и логирование
     */
    public void runOperation()
    {
        ILog log = new LogTXT();
        String txt = "";
        Double x = v.inputDouble("Input first number: ");
        Double y = v.inputDouble("Input second number: ");
        int choice = v.getChoice();
        switch (choice)
        {
            case 1:
                {
                    SumModel model = new SumModel();
                    model.setX(x);
                    model.setY(y);
                    Double res = model.result();
                    txt = log.getExpression(x, y, res, choice);
                    System.Console.WriteLine(res);
                    break;
                }
            case 2:
                {
                    SubtractionModel model = new SubtractionModel();
                    model.setX(x);
                    model.setY(y);
                    Double res = model.result();
                    txt = log.getExpression(x, y, res, choice);
                    System.Console.WriteLine(res);

                    break;
                }
            case 3:
                {
                    MultiplationModel model = new MultiplationModel();
                    model.setX(x);
                    model.setY(y);
                    Double res = model.result();
                    txt = log.getExpression(x, y, res, choice);
                    System.Console.WriteLine(res);

                    break;
                }
            case 4:
                {
                    DivisionModel model = new DivisionModel();
                    model.setX(x);
                    model.setY(y);
                    Double res = model.result();
                    txt = log.getExpression(x, y, res, choice);
                    System.Console.WriteLine(res);

                    break;
                }
        }
        log.writeFile(txt, "Log\\Saving.txt");
    }

}
