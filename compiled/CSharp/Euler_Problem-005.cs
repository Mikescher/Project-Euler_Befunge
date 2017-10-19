/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        long x0=20;
        long x1=1;
        long x2=1;
        long x3=48;
        long x4=112;
        long x5=48;
    _1:
        x1*=x2;
        t0=x0>(x2+1)?1:0;
        x2++;

        if((t0)!=0)goto _3;else goto _2;
    _2:
        System.Console.Out.Write(x1+" ");
        return;
    _3:
        x3=1;
    _4:
        t0=x3;
        x3++;
        t0=t0>x0?1:0;

        if((t0)!=0)goto _1;else goto _5;
    _5:
        if((tm(x1,x3))!=0)goto _4;else goto _6;
    _6:
        x5=td(x1,x3);
        x4=1;
    _7:
        t0=x2>(x4+1)?1:0;
        x4++;

        if((t0)!=0)goto _9;else goto _8;
    _8:
        x1/=x3;
        goto _5;
    _9:
        if((tm(x5,x4))!=0)goto _4;else goto _7;
}
}
