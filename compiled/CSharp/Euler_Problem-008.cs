/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADtl81uG0cQhF+FYJyLaCf9O90tJEIeJHBy45UnPb+/kS0ECAwo1vKYAYYr7nC3pquraqDz81nklvHwqFzSHh4eTW4PLrfOS8hNkrmYxWy5nRjPp2Pj"+
                                    "SVOuvPNpyRW0689/8vHrXK5nOX964KZeHlnmR5+C+dPzX48t17+5fnjKl1U25V9XTsPGTk8lV7n2erh85K9+fez8+/kjT/7yxz/Yn//jHn9jfvixR773ineNp/7K+eaH"+
                                    "ei+PdvpG0umVJVbmIrcXrk6brG8Vf37PZr+/0de7n+n9Ra9Sbz/yzvHDe74r+v/j36NcV2mtdHWXZTE6Zqk6qyJsZUWFeabvlRiP45izpj1NXK0qUpbbMp+sdm1RVoNL"+
                                    "r4nqTu3w45idvTSXVI+qUUhMRk6Kltdku+ukdbpJtyQEHMdUyxCqgULNTvNeTsbyZY3byFA4oAbRLgHH9fY73xpr9awVTWURaXvSYYrUzhXiwnYUBrSM/bjqHbhdZjaN"+
                                    "NMy9gWj1dF9Wa2lYW8sKRrOvTULFHMd08eyRslkwiTbpbYRUISQY9lbJTfq41CwB+zhmIRYLK9jr9oHJqRE+dwvHdLZ2p7aCWsar7oCJAa0cawoFQSqOUDPBkcEuZCq3"+
                                    "ytBZ4ha0dA+vpGUHLCKUVXhhiTrsUjImiuAewo1QtmZKMswddJu+plphtDrQK8bBoanwCsXLXiyjsxf5ZtF2HJOCqCDUK6FZqJO0GzFUi2i2tHphIY30VBGC8A6Ypmt5"+
                                    "wSZqJXPwjQiCIQfCdxai2aDDlY1mF90+jqlri7Y0aoa+hQ2mxKbLYyUxj1/Jdt1BwULQ5Dtg1ovdyXleHLkgEoEupLoIBPJJDQ8RD0TygoK4Qz/xJh4040DbqjVUqnts"+
                                    "L0pStxYETygkkwkhfRyTrOG4Eu8kzikUmCD6Bpe+ZG1vzkkNchBpDcFxHLPhVQg8lEQA7NaRu5UBkgg6wp6cAjC8zzvOdrlDP2XrkTyITe7EPsZAxBW2rUkn+X8CISeB"+
                                    "SyxgnjyOWUohtoZKu+mq7MOE+po0EhRsWcnBaULwcZbinuOYXwA+olORJA0AAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<116&&y<29)?g[y*116+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<116&&y<29)g[y*116+x]=v;}
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1;
        gw(0,0,118);
        gw(1,0,20);
        gw(2,0,50);
        gw(3,0,1000);
        gw(4,0,13);
        gw(5,0,0);
        gw(6,0,0);
        gw(7,0,0);
        gw(8,0,0);
        t0=0;
    _1:
        gw(6,0,gr(5,0));
        t0=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48;
    _2:
        t1=gr(6,0)+1;
        gw(6,0,gr(6,0)+1);
        t1-=gr(5,0);
        t1-=gr(4,0);

        if((t1)!=0)goto _3;else goto _4;
    _3:
        t0*=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48;
        goto _2;
    _4:
        if(t0>gr(8,0))goto _10;else goto _5;
    _5:
        t0=gr(5,0)+1;
        gw(5,0,gr(5,0)+1);
        t0-=gr(3,0);

        if((t0)!=0)goto _1;else goto _6;
    _6:
        gw(7,0,9);
    _7:
        System.Console.Out.Write((char)(gr(gr(7,0),0)+48));

        if((gr(7,0)-8-gr(4,0))!=0)goto _9;else goto _8;
    _8:
        System.Console.Out.Write('=');
        System.Console.Out.Write(gr(8,0)+" ");
        return;
    _9:
        gw(7,0,gr(7,0)+1);
        goto _7;
    _10:
        gw(8,0,t0);
        gw(6,0,0);
    _11:
        gw(gr(6,0)+9,0,gr(tm(gr(6,0)+gr(5,0),gr(2,0)),(td(gr(6,0)+gr(5,0),gr(2,0)))+9)-48);
        t0=gr(6,0)+1;
        gw(6,0,gr(6,0)+1);
        t0-=gr(4,0);
        if((t0)!=0)goto _11;else goto _5;
}
}
