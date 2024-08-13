namespace ParameterTypes_june_130824
{
    class stud
    {
        public int roll;
    }
    class class1
    {
        public void method6(int[]x)
        {
            Console.WriteLine("length :" + x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.WriteLine("-------------------");
        }
        public void ParamMethod( char[] fp,params int[] x)
        {
            Console.WriteLine("fp="+fp);
            Console.WriteLine("total parameters are :"+x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.WriteLine("-------------------");
        }
        public void InMethod(in int x)
        {
            Console.WriteLine("x="+x);
            int y = x;
            Console.WriteLine("y="+y);
           
        }
        public void outMethod(out int x)
        {
            x = 9088;
        }
        public void method5(int a=800,int b = 5000,int c = 5000)
        {
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
        }
        public void method4(char cc,int x, float y, double d, char ch)
        {
            Console.WriteLine("cc=" + cc);
            Console.WriteLine("x="+x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("d=" + d);
            Console.WriteLine("ch=" + ch);
        }
        public void metho1(int x)// value parameter type
        {
            Console.WriteLine("x="+x);
            x = 999;
            Console.WriteLine("new x="+x);
        }
        public void method2(ref int p)
        {
            Console.WriteLine("p=" + p);//1000
            p = 999;//999
            Console.WriteLine("new p=" + p);
        }
        public void method3(stud st)
        {
            Console.WriteLine("inside method 3 roll="+st.roll);
            st.roll = 444;
            Console.WriteLine("after change inside method 3 roll=" + st.roll);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           class1 obj1=new class1();

            //int y = 1000;
            //Console.WriteLine("y before calling method "+y);
            //obj1.metho1(y);

            //Console.WriteLine("y after calling method " + y);

            //int q = 1000;//999
            //Console.WriteLine("q before calling method " + q);//1000
            //obj1.method2(ref q);
            //Console.WriteLine("q after calling method " + q);//999

            //stud s1 = new stud() { roll = 222 };
            //Console.WriteLine("before calling");

            //Console.WriteLine("roll ="+s1.roll);
            //obj1.method3(s1);
            //Console.WriteLine("after calling");

            //Console.WriteLine("roll =" + s1.roll);
            //obj1.method4(100, 3.14f, 11.22, 'd');
            //obj1.method4(3.14f, 100, 'c', 400);
            //obj1.method4(d: 11.11,ch:'q', x: 123, y: 7.4f,cc:'U');
            //obj1.method4(x:1000,y:3.14f,cc:'R',ch:'w',d:67);
            //obj1.method5(100, 200);
            //obj1.method5(999);
            //obj1.method5();

            int n = 1000;
            //Console.WriteLine("n="+n);
            //obj1.outMethod(out n);
            //Console.WriteLine("n=" + n);


            //    Console.WriteLine("n="+n);
            //    obj1.InMethod(in n);
            //    Console.WriteLine("n=" + n);

            int a = 100;
            int b = 200;
            int c = 300;
            
            obj1.ParamMethod(3.14f,a, b, c);
            obj1.ParamMethod(1.1f);
           // obj1.method6(a, b, c);

            

        }
    }
}
