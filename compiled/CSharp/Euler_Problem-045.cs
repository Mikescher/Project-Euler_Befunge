/* compiled with BefunCompile v1.0.5 (c) 2015 */
public static class Program 
{
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long x0=1152921504606846976;
        long x1=991873;
        long x2=0;
        sa(144);
        sa(991873);
    _1:
        sa(x0);
        sa((x0)>(x1)?1:0);
    _2:
        if(sp()!=0)goto _12;else goto _3;
    _3:
        sa(sr());
        if(sp()!=0)goto _4;else goto _6;
    _4:
        sa(sr());
        sa(sp()+x2);
        {long v0=x1;sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _11;else goto _5;
    _5:
        x2=td(x2,2);
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        if(sp()!=0)goto _4;else goto _6;
    _6:
        sp();
        sa(sp()-(x2*x2));
        sa(((tm(x2,6))-5!=0)?0:1);
        if(sp()!=0)goto _7;else goto _10;
    _7:
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _8;else goto _9;
    _8:
        sa(sr());
        sa(sp()*2);
        sa(sp()-1);
        sa(sp()*sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _9:
        x2=0;
        sa(sp()+1);
        sa(sr());
        sa(sr());
        sa(sp()*2);
        sa(sp()-1);
        sa(sp()*sp());
        sa(sp()*24);
        sa(sp()+1);
        sa(sr());
        x1=sp();
        goto _1;
    _10:
        x2=0;
        sp();
        sa(sp()+1);
        sa(sr());
        sa(sr());
        sa(sp()*2);
        sa(sp()-1);
        sa(sp()*sp());
        sa(sp()*24);
        sa(sp()+1);
        sa(sr());
        x1=sp();
        goto _1;
    _11:
        sa(sr());
        sa(sp()+x2);
        sa(x1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x1=sp();
        sa(sr());
        sa(sp()*2);
        sa(sp()+x2);
        x2=sp();
        x2=td(x2,2);
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        goto _3;
    _12:
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=x1;sa((sp()>v0)?1:0);}
        goto _2;
}}