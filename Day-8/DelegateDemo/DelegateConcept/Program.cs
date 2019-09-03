using System;

namespace DelegateConcept
{
    delegate void CalDel(int x, int y);
    /*
    class CalDel:MulticastDelegate//:Delegate:object
    {
        private object _target;
        private MethodInfo _method;

        public CalDel(object target, MethodInfo method)
        {
            if (target != null)
                _target = target;
            _method = method;
        }
        public void Invoke(int x, int y)
        {
            if (_target != null)
                _method.Invoke(_target, new object[] { x, y });

            else
                _method.Invoke(null, new object[] { x, y });
        }
    }
    */
    class Program
    {
        static void Main()
        {
            //CalDel calDelSubtract = new CalDel(Calculation.Subtract);
            CalDel calDelSubtract = Calculation.Subtract;

            Calculation calculation = new Calculation();
            //CalDel calDelAdd = new CalDel(calculation.Add);
            CalDel calDelAdd = calculation.Add;

            //calculation.GetType().GetMethod("Add")
            //typeof(Calculation).GetMethod("Subtract")

            Console.WriteLine($"Method referred by {nameof(calDelAdd)} delegate is {calDelAdd.Method.Name} and will be invoked on the instance of {calDelAdd.Target}");

            Console.WriteLine($"Method referred by {nameof(calDelSubtract)} delegate is {calDelSubtract.Method.Name} and will be invoked on the instance of {(calDelSubtract.Target != null ? calDelSubtract.Target : "NULL")}");

            calDelAdd.Invoke(12, 13);
            calDelSubtract(12, 3);

        }
    }
}
