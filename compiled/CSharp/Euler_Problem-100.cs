/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        long x0=1;
        long x1=1;
        long x2=0;
        long x3=0;
    _1:
        t0=(x2*3)+(x0*2);
        x0=(x0*3)+(x2*4);
        x2=t0;
        t0=(x3*3)-(x1*2);
        x1=(x1*3)-(x3*4);
        x3=t0;
        if((((2+(x2*2))-x0-(2*x3)-x1)/4)>1000000000000L)goto _3;else goto _1;
    _3:
        System.Console.Out.Write(((4+(x1*2)+(x3*2)+(x0*2))-(x2*2))/8+" ");
        return;
}
}
