/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long x0=0;
        long x1=32;
        sa(4);
        sa(1);
        sa(4);
        sa(0);
    _1:
        if(sp()!=0)goto _11;else goto _2;
    _2:
        sa(sp()/2L);
    _3:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sr()!=1)goto _10;else goto _4;
    _4:
        sp();

        if(sr()<x0)goto _5;else goto _9;
    _5:
        sp();
    _6:
        if(sr()>1000000)goto _7;else goto _8;
    _7:
        System.Console.Out.Write(x1+" ");
        System.Console.Out.Write(" :");
        System.Console.Out.Write(x0+" ");
        return;
    _8:
        sa(sp()+1L);

        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr()%2);
        goto _1;
    _9:
        x0=sp();
        x1=sr();
        goto _6;
    _10:
        sa(sp()/1L);

        sa(sr()%2);
        goto _1;
    _11:
        sa(sp()*3L);

        sa(sp()+1L);
        goto _3;
}
}
