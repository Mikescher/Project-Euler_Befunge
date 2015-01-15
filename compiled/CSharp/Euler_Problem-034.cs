/* compiled with BefunCompile v1.0.3 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACVjr0OgzAMhF8lUsriiGID4ecURX2QCMasnjLx8A2dWqoO9XLW2b7PxfxRUcCsQhDWntCzDoSBdSSMrJ5Q3paLivBNeQWtygtoUZ5Bs/IEmpR9+Mov"+
                                    "e7G/6Wgl1EwT4sp5pghwivDeNZxTlQ627NHZkGDD7trjPHKvv4f2fnuYA53zPmVuqsB88CNE8nZ2Wxapo3jFb1fjCcDxR0M7AQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<45&&y<7)?g[y*45+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<45&&y<7)g[y*45+x]=v;}
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
        goto _5;
    _0:
        if(sp()!=0)goto _13; else goto _6;
    _1:
        if(sp()!=0)goto _14; else goto _6;
    _2:
        if(sp()!=0)goto _7; else goto _8;
    _3:
        if(sp()!=0)goto _10; else goto _9;
    _4:
        if(sp()!=0)goto _11; else goto _12;
    _5:
        gw(0,0,1);
        gw(1,0,1);
        gw(2,0,2);
        gw(3,0,6);
        gw(4,0,24);
        gw(5,0,120);
        gw(6,0,720);
        gw(7,0,5040);
        gw(8,0,40320);
        gw(9,0,362880);
        gw(1,1,0);
        sa((gr(9,0))*(7));
        sa((gr(9,0))*(7));
        sa(0);
        sa(gr(tm((gr(9,0))*(7),10),0));
        sa(td((gr(9,0))*(7),10));
        sa(td((gr(9,0))*(7),10));
        goto _0;
    _6:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _2;
    _7:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _6;
    _8:
        sa(sp()+sp());
        {long v0=sp();sa(sp()-v0);}
        goto _3;
    _9:
        sa(sr());
        sa(gr(1,1));
        sa(sp()+sp());
        gw(1,1,sp());
        goto _10;
    _10:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _4;
    _11:
        sa(sr());
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _12:
        sa(sr());
        sp();
        System.Console.Out.Write((long)((gr(1,1))-(3)));
        sp();
        return;
    _13:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _1;
    _14:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
}}