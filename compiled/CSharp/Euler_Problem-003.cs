/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        long x0=775146;
        long x1=600851475143;
        long x2=55;
        long x3=57;
    _1:
        t0=tm(x1,x0-1);
        x0--;
        if((t0)!=0)goto _1;else goto _3;
    _3:
        t0=x0-1;
        x3=x0;
        x2=t0;
    _4:
        if((tm(x3,x2))!=0)goto _5;else goto _1;
    _5:
        t0=x2-2;
        x2--;

        if((t0)!=0)goto _4;else goto _6;
    _6:
        System.Console.Out.Write(x3+" ");
        return;
}
}
