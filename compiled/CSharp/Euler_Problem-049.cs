/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
        long x0=4818;
        sa(1488L);
        sa(1800L);
        sa(1800L);
    _1:
        if((((tm(x0,10L))+2L)*((tm(td(x0,10L),10L))+2L)*((tm(td(td(x0,10L),10L),10L))+2L)*((td(td(td(x0,10L),10L),10L))+2L))!=(((tm(x0+3330L,10L))+2L)*((tm(td(x0+3330L,10L),10L))+2L)*((tm(td(td(x0+3330L,10L),10L),10L))+2L)*((td(td(td(x0+3330L,10L),10L),10L))+2L)))goto _14;else goto _2;
    _2:
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _3;else goto _14;
    _3:
        sa(sr());
        if(sr()>9999L)goto _11;else goto _4;
    _4:
        sa(sr());
        if(tm(sr(),2L)==0)goto _5;else goto _6;
    _5:
        sp();
        sp();
        sa(sp()+1L);
        sa(sr());
        sa(sr());
        sa((tm(sr(),10L))+2L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa((tm(sr(),10L))+2L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa((tm(sr(),10L))+2L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(sp()+2L);
        sa(sp()*sp());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+3330L);
        x0=sp();
        sa(sr());
        goto _1;
    _6:
        if(tm(sr(),3L)==0)goto _5;else goto _7;
    _7:
        x0=sp();
        sa(7L);
        sa((tm(x0,7L)!=0)?0:1);
    _8:
        if(sp()!=0)goto _5;else goto _9;
    _9:
        if(sr()>td(x0,2L))goto _10;else goto _12;
    _10:
        sp();
        sa(sp()+3330L);
        if(sr()>9999L)goto _11;else goto _4;
    _11:
        sp();
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write(' ');
        sa(sp()+3330L);
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write(' ');
        sa(sp()+3330L);
        System.Console.Out.Write((long)(sp()));
        return;
    _12:
        sa(sr()-2L);
        sa(x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}
        if(sp()!=0)goto _13;else goto _5;
    _13:
        sa(sp()+6L);
        sa(sr());
        sa(x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}
        sa((sp()!=0)?0:1);
        goto _8;
    _14:
        sp();
        sp();
        sa(sp()+1L);
        sa(sr());
        sa(sr());
        sa((tm(sr(),10L))+2L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa((tm(sr(),10L))+2L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa((tm(sr(),10L))+2L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(sp()+2L);
        sa(sp()*sp());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+3330L);
        x0=sp();
        sa(sr());
        goto _1;
}}