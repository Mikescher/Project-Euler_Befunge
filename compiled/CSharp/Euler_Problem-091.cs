/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1;
        long x0=50;
        long x1=0;
        long x2=50;
        long x3=88;
        long x4=88;
    _1:
        x3=x0;
        x4=x3+1;
    _2:
        if((((x3*(x4-x3))>(x2*x2)?1:0)+(x4>x0?1L:0L))!=0)goto _3;else goto _7;
    _3:
        t0=x3-1;
        t1=6;
        x3--;

        if((t0)!=0)goto _6;else goto _4;
    _4:
        t0=x2-1;
        t1=x2-1;
        x2=t1;

        if((t0)!=0)goto _1;else goto _5;
    _5:
        System.Console.Out.Write(x1+(3*x0*x0)+" ");
        return;
    _6:
        x4=x3+1;
        goto _2;
    _7:
        x1+=((tm((x3-x4)*x3,x2)!=0)?0:1)*2L;
        x4++;
        goto _2;
}
}
