/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABAC9VMtqw0AM/JUh7SnGRVp5X6GYfkhJevPVp3x/R17ogxjaErvCOCvh7OxoRguM0Y4QmUUm7QN/VeZRZbLjKbDUTQc59DF2x1ftPgsdv1iyWf194p+Y"+
                                    "9to/XC9cnD62Yn7FbeS4UsR5rfjLeL7J13BrRBpuqmtfbncSD80YMkq4e/MRj385rRZYRMlQ+boJxQ59E20RuwnbFqGjfJ63NfqTvI0P50s/fhOdEjd5m9w0y9xy0enp"+
                                    "JQhkcL5knVa1vkvsNbkb3wpRBHODicFutd4nSoEE5IxsEFI2pPwfuLV6e9nqwAMkaEIW1Ptt9lMM6k9IiAnFMAiKOLTZ/rgFOTgQrWVcZGdd2YG6I26kowg9eLdDxGCo"+
                                    "ihhQM6JCd7MZW6rqZKlvcxdvksyhpu7F13Efm5FdXgjagkKCrJB1LIiCkL3bFGLz8MFJ7meyK9XbzjkyWYgnpOpXGc1mujGuI1LNslDjCNdljorjVvMm+EmWOy1s6vB3"+
                                    "lpN0goAHAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<120&&y<16)?g[y*120+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<120&&y<16)g[y*120+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(0L,0L,15L);
        gw(2L,0L,gr(0L,0L)-1L);
        gw(1L,0L,0L);
    _1:
        gw(gr(1L,0L),gr(2L,0L)+1L,((gr(gr(1L,0L)*3L,gr(2L,0L)+1L)-48L)*10L)+(gr((gr(1L,0L)*3L)+1L,gr(2L,0L)+1L)-48L));
        sa(gr(1L,0L)+1L);
        gw(1L,0L,gr(1L,0L)+1L);
        sa(sp()-gr(2L,0L));
        sa(sp()-1L);
        if(sp()!=0)goto _1;else goto _3;
    _3:
        sa(gr(2L,0L));
        gw(2L,0L,gr(2L,0L)-1L);
        gw(1L,0L,0L);
        if(sp()!=0)goto _1;else goto _4;
    _4:
        sa(gr(0L,0L)-2L);
        gw(1L,0L,gr(0L,0L)-2L);
        gw(2L,0L,sp());
    _5:
        sa(gr(gr(1L,0L),gr(2L,0L)+1L));
        sa(gr(gr(1L,0L),gr(2L,0L)+2L));
        sa(gr(gr(1L,0L),gr(2L,0L)+2L)-gr(gr(1L,0L)+1L,gr(2L,0L)+2L));
        if((gr(gr(1L,0L),gr(2L,0L)+2L)-gr(gr(1L,0L)+1L,gr(2L,0L)+2L))>0L)goto _6;else goto _10;
    _6:
        sp();
    _7:
        sa(sp()+sp());
        gw(gr(1L,0L),gr(2L,0L)+1L,sp());
        sa(gr(1L,0L));
        gw(1L,0L,gr(1L,0L)-1L);
        if(sp()!=0)goto _5;else goto _8;
    _8:
        sa(gr(2L,0L));
        sa(gr(2L,0L)-1L);
        gw(2L,0L,gr(2L,0L)-1L);
        gw(1L,0L,sp());
        if(sp()!=0)goto _5;else goto _9;
    _9:
        System.Console.Out.Write((long)(gr(0L,1L)));
        return;
    _10:
        {long v0=sp();sa(sp()-v0);}
        goto _7;
}}