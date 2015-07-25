/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long t0,t1;
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
        sa(gr(9,0)*7);
        sa(gr(9,0)*7);
        sa(0);
        sa(gr(tm(gr(9,0)*7,10),0));
        sa(td(gr(9,0)*7,10));
        sa(td(gr(9,0)*7,10));
    _1:
        if(sp()!=0)goto _2;else goto _3;
    _2:
        sa(tm(sr(),10));
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10));
        sa(sr());
        if(sp()!=0)goto _10;else goto _3;
    _3:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _9;else goto _4;
    _4:
        sa(sp()+sp());
        t0=sp();
        sa(sp()-t0);
        t1=sp();
        if((t1)!=0)goto _5;else goto _8;
    _5:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _6;else goto _7;
    _6:
        sa(sr());
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),10));
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10));
        sa(sr());
        goto _1;
    _7:
        System.Console.Out.Write(gr(1,1)-3);
        sa(sr());
        sp();
        sp();
        return;
    _8:
        t0=sr()+gr(1,1);
        gw(1,1,t0);
        goto _5;
    _9:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _3;
    _10:
        sa(tm(sr(),10));
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10));
        sa(sr());
        goto _1;
}}