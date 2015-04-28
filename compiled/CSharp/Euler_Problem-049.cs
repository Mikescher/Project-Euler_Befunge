/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
        long x0=63;
        goto _0;
    _0:
        x0=4818;
        sa(1488);
        sa(1800);
        sa(1800);
    _1:
        if(((((tm(x0,10))+(2))*(((tm(td(x0,10),10))+(2))*(((tm(td(td(x0,10),10),10))+(2))*((td(td(td(x0,10),10),10))+(2)))))-(((tm((x0)+(3330),10))+(2))*(((tm(td((x0)+(3330),10),10))+(2))*(((tm(td(td((x0)+(3330),10),10),10))+(2))*((td(td(td((x0)+(3330),10),10),10))+(2))))))!=0)goto _14;else goto _2;
    _2:
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _3; else goto _14;
    _3:
        sa(sr());
        sa(sr());
        {long v0=9999;sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _10; else goto _4;
    _4:
        sa(sr());
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _13; else goto _5;
    _5:
        sa(sr());
        {long v0=3;sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _13; else goto _6;
    _6:
        x0=sp();
        sa(7);
        sa(((tm(x0,7))!=0)?0:1);
    _7:
        if(sp()!=0)goto _13; else goto _8;
    _8:
        sa(sr());
        {long v0=td(x0,2);sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _9; else goto _11;
    _9:
        sp();
        sa(sp()+(3330));
        sa(sr());
        {long v0=9999;sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _10; else goto _4;
    _10:
        sp();
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((char)(32));
        sa(sp()+(3330));
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((char)(32));
        sa(sp()+(3330));
        System.Console.Out.Write((long)(sp()));
        return;
    _11:
        sa(sr());
        sa(sp()-(2));
        sa(x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        if(sp()!=0)goto _12; else goto _13;
    _12:
        sa(sp()+(6));
        sa(sr());
        sa(x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        goto _7;
    _13:
        sp();
        sp();
        sa(sp()+(1));
        sa(sr());
        sa(sr());
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sp()+(2));
        sa(sp()*sp());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+(3330));
        x0=sp();
        sa(sr());
        goto _1;
    _14:
        sp();
        sp();
        sa(sp()+(1));
        sa(sr());
        sa(sr());
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sp()+(2));
        sa(sp()*sp());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+(3330));
        x0=sp();
        sa(sr());
        goto _1;
}}