/* compiled with BefunCompile v1.0.2 (c) 2015 */
public static class Program 
{
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long x0=63;
        goto _9;
    _0:
        if(sp()!=0)goto _12; else goto _11;
    _1:
        if(sp()!=0)goto _13; else goto _14;
    _2:
        if(sp()!=0)goto _15; else goto _16;
    _3:
        if(sp()!=0)goto _15; else goto _17;
    _4:
        if(sp()!=0)goto _15; else goto _18;
    _5:
        if(sp()!=0)goto _19; else goto _20;
    _6:
        if(sp()!=0)goto _13; else goto _14;
    _7:
        if(sp()!=0)goto _21; else goto _15;
    _8:
        if(((((tm(x0,10))+(2))*(((tm(td(x0,10),10))+(2))*(((tm(td(td(x0,10),10),10))+(2))*((td(td(td(x0,10),10),10))+(2)))))-(((tm((x0)+(3330),10))+(2))*(((tm(td((x0)+(3330),10),10))+(2))*(((tm(td(td((x0)+(3330),10),10),10))+(2))*((td(td(td((x0)+(3330),10),10),10))+(2))))))!=0)goto _11;else goto _10;
    _9:
        x0=4818;
        sa(1488);
        sa(1800);
        sa(1800);
        goto _8;
    _10:
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _0;
    _11:
        sp();
        sp();
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(sr());
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(2);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(2);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(2);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(2);
        sa(sp()+sp());
        sa(sp()*sp());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(3330);
        sa(sp()+sp());
        x0=sp();
        sa(sr());
        goto _8;
    _12:
        sa(sr());
        sa(sr());
        sa(9999);
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _1;
    _13:
        sp();
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((char)(32));
        sa(3330);
        sa(sp()+sp());
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((char)(32));
        sa(3330);
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _14:
        sa(sr());
        sa(sr());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        goto _2;
    _15:
        sp();
        sp();
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(sr());
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(2);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(2);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(2);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(2);
        sa(sp()+sp());
        sa(sp()*sp());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(3330);
        sa(sp()+sp());
        x0=sp();
        sa(sr());
        goto _8;
    _16:
        sa(sr());
        sa(3);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        goto _3;
    _17:
        x0=sp();
        sa(7);
        sa(((tm(x0,7))!=0)?0:1);
        goto _4;
    _18:
        sa(sr());
        sa(td(x0,2));
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _5;
    _19:
        sp();
        sa(3330);
        sa(sp()+sp());
        sa(sr());
        sa(9999);
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _6;
    _20:
        sa(sr());
        sa(2);
        {long v0=sp();sa(sp()-v0);}
        sa(x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _7;
    _21:
        sa(6);
        sa(sp()+sp());
        sa(sr());
        sa(x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        goto _4;
}}