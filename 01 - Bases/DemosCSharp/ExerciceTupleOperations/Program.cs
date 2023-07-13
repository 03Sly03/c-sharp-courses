//(float, float, float, float) Operation(float x, float y)
//{
//    float add = x + y;
//    float sub = x - y;
//    float mul = x * y;
//    float div = x / y;

//    (float, float, float, float) tuple = (add, sub, mul, div);

//    return tuple;
//}

//(float, float, float, float) Operation(float x, float y)
//{
//    return (x + y, x - y, x * y, x / y);
//}

//Console.WriteLine(Operation(5,10));

(float Add, float Sub, float Mul, float Div) Operation(float x, float y)
{
    return (x + y, x - y, x * y, x / y);
}

Console.WriteLine(Operation(40, 2).Add);
Console.WriteLine(Operation(4, 20).Sub);
Console.WriteLine(Operation(4, 200).Mul);
Console.WriteLine(Operation(400, 2).Div);


var monTuple = Operation(4, 2);
Console.WriteLine(monTuple.Add);
Console.WriteLine(monTuple.Item1);