/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        long x0=0;
        long x1=1000000000;
        long x2=2;
        long x3=1;
    _1:
        if(x1>(x2*2))goto _3;else goto _2;
    _2:
        System.Console.Out.Write(x0+" ");
        return;
    _3:
        x0=((x2>2?1:0)*((((2*x2)%3)-1!=0)?0:1)*((((x2-2)*x3)%3!=0)?0L:1L)*((x2*2)-2))+x0;
        x0=(((((x2*2)%3)-2!=0)?0:1)*((((x2+2)*x3)%3!=0)?0L:1L)*(2+(2*x2)))+x0;
        t0=x2+(x3*2);
        x2=(x2*2)+(x3*3);
        x3=t0;
        goto _1;
}
}
