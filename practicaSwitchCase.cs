double a, b;
string oper, result;
a = Convert.ToDouble(Console.ReadLine());
oper = Console.ReadLine();
b = Convert.ToDouble(Console.ReadLine());

result = "Ошибка";
switch (oper)
{
    case "+":
        result = (a + b).ToString();
        break;
    case "-":
        result = (a - b).ToString();
        break;
    case "*":
        result = (a * b).ToString();
        break;
    case "/":
        if (b == 0)
        {
            result = "На ноль делить нельзя";
        }
        else
        {
            result = (a / b).ToString();
        }
        break;

    case "^":
        result = Math.Pow(a, b).ToString();
        break;

    case "**":
        result = Math.Pow(a, 1 / b).ToString();
        break;

    case "%":
        result = (a % b).ToString();
        break;

    case "kv":
        double c = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            result = "Это не квадратное уравнение, а линейное";
        }
        else
        {
            double discrim = b * b - 4 * a * c;
            if (discrim < 0)
            {
                result = "Корней нет";
            }
            else if (discrim == 0)
            {
                double x = -b / (2 * a);
                result = "x = " + x.ToString();
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discrim)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discrim)) / (2 * a);
                result = "x1 = " + x1.ToString() + "; x2 = " + x2.ToString();
            }
        }
        break;
}
Console.WriteLine(result);