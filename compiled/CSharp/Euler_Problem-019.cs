/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABACtkcFqxCAQhl8lNU0pimXmNyREgvRBQnopzNWTpzx8xyULuwS2bNoRRceZz3/GEihAx2VpzlsJ/C+c4Q+5t5ZgU4wkhozvR+sWyjGWU6gtes68ODv2"+
                                    "XnHCzfw8pDSvJ7KOlkDIzDqBbPBmLLuATBPyU9UVkGMBZUxOML04ryfuRnXNqd2DqG1K3e/K01FNSSpE2KmgAOm7u9vtGsVNSoAsUmO93w6cX2pWtPk2nebRWsW0V64+"+
                                    "q9zITpsxDO4huXS2V4ogaIHrF68q0Du25h0XZ0aoHQlK5EdfddOFNVWKuibIx+fuuwuefwDyEoFQYAMAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<72&&y<12)?g[y*72+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<72&&y<12)g[y*72+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(12,0,gr(12,0)-20);
        gw(12,1,gr(12,1)-20);
        sa(11);
    _1:
        sa(sr());
        sa(sr());
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);

        sa(sp()+28L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);

        sa(sp()+28L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        if(sp()!=0)goto _1;else goto _3;
    _3:
        gw(0,2,2);
        gw(1,2,1);
        gw(2,2,1);
        gw(3,2,1901);
        gw(9,2,0);
        gw(9,2,(((tm(gr(0,2),7))+(gr(1,2)-1)!=0)?0:1)+gr(9,2));
        gw(0,2,gr(0,2)+1);
        gw(1,2,gr(1,2)+1);
        sp();
    _4:
        if(tm(gr(3,2),4)!=0)goto _5;else goto _12;
    _5:
        sa(gr(gr(2,2),0)-(gr(1,2)-1));
    _6:
        if(sp()!=0)goto _9;else goto _7;
    _7:
        gw(1,2,1);
        t0=gr(2,2);
        gw(2,2,gr(2,2)+1);
        t0-=12;

        if((t0)!=0)goto _9;else goto _8;
    _8:
        gw(2,2,1);
        gw(3,2,gr(3,2)+1);
    _9:
        if(gr(3,2)!=2001)goto _10;else goto _11;
    _10:
        gw(9,2,(((tm(gr(0,2),7))+(gr(1,2)-1)!=0)?0:1)+gr(9,2));
        gw(0,2,gr(0,2)+1);
        gw(1,2,gr(1,2)+1);
        goto _4;
    _11:
        System.Console.Out.Write(gr(9,2)+" ");
        return;
    _12:
        if(tm(gr(3,2),100)!=0)goto _13;else goto _14;
    _13:
        sa(gr(gr(2,2),1)-(gr(1,2)-1));
        goto _6;
    _14:
        if(tm(gr(3,2),400)!=0)goto _5;else goto _13;
}
}
