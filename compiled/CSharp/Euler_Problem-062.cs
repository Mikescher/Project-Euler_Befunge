/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrfX7+Y1GUgc+xi9UnPelsRLfDL7FM/qLbl4eF7REUHx/YtuLuuOvuN+6ENlHTsXC+/J+/seLOBaytmfVOHDw++VWhzPfLZBW07kcPOj"+
                                    "FexHPyyQADGTKgJ4+LseOhraaLTRSnCK1JWzfM1xnvs9t/aHlW6v7/s3/4LG/W+XrwVnlz3bOCXz9vXjzrevzSmbfa/j/jetHUGrNPb5va6yv+96+T1v/Lo7B3dttl33"+
                                    "0Tqo9vGdjT5T0//+FpgjKjhZfef7UNHl0v8EvJfverB6H9enDL/mu27xq7d4Gp2rPfpFvWv72oNmvSWKuzYYB7rtrPpVHCjC//JLRfj6z7Mjvv8SncN6WuRa4Je6K7P/"+
                                    "MHe4pq+fY7jXR/nAPv/GP8onjA9vXxlTKKYTpDGlz/G56vqpGdU/3iy0lRCs36P8RZz7vvu6H6o368881+PfMePT3f9/AnxEl//69PfPfYvH+re49af/CM8qYmAAAFun"+
                                    "LAS3AQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<505&&y<58)?g[y*505+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<505&&y<58)g[y*505+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(2,8,5);
        gw(2,4,501);
        gw(2,5,48);
        gw(2,6,24048);
        gw((tm(24047,gr(2,4)))+4,td(24047,gr(2,4)),0);
        sa(24046);
    _1:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),gr(2,4)))+4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,4)));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _2;else goto _20;
    _2:
        gw(2,2,1);
        sa(1);
        sa(0);
        sa(1);
        sa(1);
    _3:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(9);
    _4:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _19;else goto _5;
    _5:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10));

        sa(tm(sr(),10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _6:
        if(sp()!=0)goto _3;else goto _7;
    _7:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sp();
        sp();
    _8:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _9;else goto _10;
    _9:
        sa(sp()+sp());
        goto _8;
    _10:
        sa(sp()+sp());

        sa(sr());
        gw(2,0,sp());
        sa(0);
        sa(gr(4,0));
        sa(gr(4,0));
    _11:
        if(sp()!=0)goto _12;else goto _18;
    _12:
        sa(sp()-gr(2,0));


        if(sp()!=0)goto _17;else goto _13;
    _13:
        sa(sp()*3L);

        sa(sr()+2);
        sa((tm(sr(),gr(2,4)))+4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,4)));

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()+1L);


        if(sr()-gr(2,8)==0)goto _14;else goto _15;
    _14:
        sp();
        sa(sp()+1L);

        sa((tm(sr(),gr(2,4)))+4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,4)));

        {long v0=sp();t0=gr(sp(),v0);}
        System.Console.Out.Write(t0+" ");
        sp();
        sp();
        sp();
        return;
    _15:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+2L);

        sa((tm(sr(),gr(2,4)))+4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,4)));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    _16:
        sp();
        sa(sp()+1L);

        sa(sr());
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        sa(sr());
        gw(2,2,sp());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _6;
    _17:
        sa(sp()+1L);

        sa(sr()*3);
        sa((tm(sr(),gr(2,4)))+4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,4)));

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        goto _11;
    _18:
        sp();
        sa(sp()*3L);

        sa(sr());
        sa(sr());
        sa(gr(2,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),gr(2,4)))+4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,4)));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(2,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);

        sa((tm(sr(),gr(2,4)))+4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,4)));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+2L);

        sa((tm(sr(),gr(2,4)))+4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,4)));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _16;
    _19:
        sa(sp()-1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*9L);
        goto _4;
    _20:
        sa(sp()-1L);
        goto _1;
}
}
