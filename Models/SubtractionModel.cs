public class SubtractionModel : CommonModel
{

    public Double result()
    {
        return x - y;
    }
    public void setX(Double value)
    {
        base.x = value;
    }
    public void setY(Double value)
    {
        base.y = value;
    }
}
