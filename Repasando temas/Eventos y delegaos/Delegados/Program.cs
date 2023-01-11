

static void PerformAction( MathAction action, int a, int b ){
        Console.WriteLine(action.Invoke(a,b));
}

Calculator cal = new Calculator();
MathAction matAdd = new MathAction(Calculator.Add);
MathAction matSub = new MathAction(Calculator.Substract);

PerformAction(matAdd,5,6);
PerformAction(matSub,5,6);

delegate int MathAction(int a, int b);

/*
        Normalmente, un objeto delegado se construye al proporcionar el nombre del método que
        el delegado encapsulará o con una expresión lambda.

                public delegate void name(string x);
*/