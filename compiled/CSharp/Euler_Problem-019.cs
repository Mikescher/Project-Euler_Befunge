/* compiled with BefunCompile v1.0.2 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACtkcFqxCAQhl8lNU0pimXmNyREgvRBQnopzNWTpzx8xyULuwS2bNoRRceZz3/GEihAx2VpzlsJ/C+c4Q+5t5ZgU4wkhozvR+sWyjGWU6gtes68ODv2"+
                                    "XnHCzfw8pDSvJ7KOlkDIzDqBbPBmLLuATBPyU9UVkGMBZUxOML04ryfuRnXNqd2DqG1K3e/K01FNSSpE2KmgAOm7u9vtGsVNSoAsUmO93w6cX2pWtPk2nebRWsW0V64+"+
                                    "q9zITpsxDO4huXS2V4ogaIHrF68q0Du25h0XZ0aoHQlK5EdfddOFNVWKuibIx+fuuwuefwDyEoFQYAMAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=o.Skip(1).ToArray();for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<72&&y<12)?g[y*72+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<72&&y<12)g[y*72+x]=v;}
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
        goto _7;
    _0:
        if(sp()!=0)goto _21; else goto _8;
    _1:
        if(sp()!=0)goto _10; else goto _16;
    _2:
        if(sp()!=0)goto _11; else goto _14;
    _3:
        if(sp()!=0)goto _13; else goto _12;
    _4:
        if(sp()!=0)goto _11; else goto _15;
    _5:
        if(sp()!=0)goto _17; else goto _18;
    _6:
        if(sp()!=0)goto _19; else goto _20;
    _7:
        gw(12,0,((gr(12,0))-(48))+(28));
        gw(12,1,((gr(12,1))-(48))+(28));
        sa(11);
        sa(11);
        goto _0;
    _8:
        gw(0,2,2);
        gw(1,2,1);
        gw(2,2,1);
        gw(3,2,1901);
        gw(9,2,0);
        gw(9,2,((((tm(gr(0,2),7))+((gr(1,2))-(1)))!=0)?0:1)+(gr(9,2)));
        gw(0,2,(gr(0,2))+(1));
        gw(1,2,(gr(1,2))+(1));
        sp();
        goto _9;
    _9:
        sa(tm(gr(3,2),4));
        goto _1;
    _10:
        sa((gr(gr(2,2),0))-((gr(1,2))-(1)));
        goto _2;
    _11:
        sa((gr(3,2))-(2001));
        goto _3;
    _12:
        System.Console.Out.Write((long)(gr(9,2)));
        return;
    _13:
        gw(9,2,((((tm(gr(0,2),7))+((gr(1,2))-(1)))!=0)?0:1)+(gr(9,2)));
        gw(0,2,(gr(0,2))+(1));
        gw(1,2,(gr(1,2))+(1));
        goto _9;
    _14:
        gw(1,2,1);
        sa(gr(2,2));
        gw(2,2,(gr(2,2))+(1));
        sa(12);
        {long v0=sp();sa(sp()-v0);}
        goto _4;
    _15:
        gw(2,2,1);
        gw(3,2,(gr(3,2))+(1));
        goto _11;
    _16:
        sa(tm(gr(3,2),100));
        goto _5;
    _17:
        sa((gr(gr(2,2),1))-((gr(1,2))-(1)));
        goto _2;
    _18:
        sa(tm(gr(3,2),400));
        goto _6;
    _19:
        sa((gr(gr(2,2),0))-((gr(1,2))-(1)));
        goto _2;
    _20:
        sa((gr(gr(2,2),1))-((gr(1,2))-(1)));
        goto _2;
    _21:
        sa(sr());
        sa(sr());
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        sa(28);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        sa(28);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _0;
}}