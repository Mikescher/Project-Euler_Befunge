/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADtk01ug0AMha9CIWxs0dgj/mYUod6gF0CQ3SzrFascvm4SlAAJUdMsKoSl+dHT6I3ne9AF/7yi19bq90e/Nd9l+635LttvzXfZfmu+y/Zb812234ur"+
                                    "KgoowWDlqHbhZxgz1rpsDcpIKSdKYeCkqU838j0gu4QFoUy3erZGjnVxNTlBBGPLiQppdqXtxn1uAlY5l+Ns4LhmOcjk5vl6fHp883xVOUFBkjOUOhuwOqvCR4Vvdlfp"+
                                    "IH3PzdY6CL9CGwilJGxYmHVYMPn97ho91DbR3jMHLvFkILsArAJikh9WUHHinDMkgwzJG0Q/TPqkGWDyiC7LMHZR046f0syTabvICfEWs0wjN57sdeTa5u7yaiEbo7WY"+
                                    "6ymhst+XQkW/LzbXT59l+EQpQ3NiaEYMqwf82GcpTAj26hzDB/zGBPX/8DxleHbUj+RMiq1wT5BL4Z4gDwneq4rZG/b7t6hrU/KM+iE+S1Xr4M6bhC+3/+4XG7a30abe"+
                                    "P543GNU3DXw8oeAQAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<54)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<54)g[y*80+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(79L,6L,0L);
        gw(79L,12L,0L);
        gw(79L,18L,0L);
        gw(79L,24L,0L);
        gw(79L,30L,0L);
        gw(79L,36L,0L);
        sa(393L);
    _1:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+2L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+8L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+14L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+20L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+26L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+32L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);
        if((sr()+1L)!=0)goto _1;else goto _3;
    _3:
        gw(79L,6L,1L);
        gw(79L,12L,1L);
        gw(79L,30L,1L);
        gw(7L,0L,0L);
        gw(8L,0L,6L);
        gw(9L,0L,12L);
        gw(7L,1L,0L);
        gw(8L,1L,6L);
        gw(9L,1L,12L);
        gw(1L,1L,1L);
        gw(2L,1L,1L);
        gw(4L,0L,0L);
        gw(1L,0L,0L);
        gw(2L,0L,394L);
        sp();
        sa(999L);
    _4:
        sa(394L);
        sa(gr(79L,4L+gr(7L,0L)+2L)+(gr(79L,4L+gr(8L,0L)+2L)*2L)+gr(1L,0L));
        sa(tm(gr(79L,4L+gr(7L,0L)+2L)+(gr(79L,4L+gr(8L,0L)+2L)*2L)+gr(1L,0L),10L));
        sa(tm(gr(79L,4L+gr(7L,0L)+2L)+(gr(79L,4L+gr(8L,0L)+2L)*2L)+gr(1L,0L),10L));
    _5:
        if(sp()!=0)goto _6;else goto _8;
    _6:
        sa(395L-gr(2L,0L));
        if((395L-gr(2L,0L))>gr(1L,1L))goto _22;else goto _7;
    _7:
        sp();
    _8:
        gw((tm(gr(2L,0L),79L))+1L,(td(gr(2L,0L),79L))+gr(9L,0L)+2L,sp());
        sa(td(sp(),10L));
        gw(1L,0L,sp());
        sa(sr());
        if(sp()!=0)goto _21;else goto _9;
    _9:
        gw(7L,0L,tm(gr(7L,0L)+6L,18L));
        gw(8L,0L,tm(gr(8L,0L)+6L,18L));
        gw(9L,0L,tm(gr(9L,0L)+6L,18L));
        gw(1L,0L,0L);
        gw(2L,0L,394L);
        sp();
        sa(394L);
        sa(gr(79L,4L+gr(7L,1L)+20L)+(gr(79L,4L+gr(8L,1L)+20L)*2L)+gr(1L,0L));
        sa(tm(gr(79L,4L+gr(7L,1L)+20L)+(gr(79L,4L+gr(8L,1L)+20L)*2L)+gr(1L,0L),10L));
        sa(tm(gr(79L,4L+gr(7L,1L)+20L)+(gr(79L,4L+gr(8L,1L)+20L)*2L)+gr(1L,0L),10L));
    _10:
        if(sp()!=0)goto _11;else goto _13;
    _11:
        sa(395L-gr(2L,0L));
        if((395L-gr(2L,0L))>gr(2L,1L))goto _20;else goto _12;
    _12:
        sp();
    _13:
        gw((tm(gr(2L,0L),79L))+1L,(td(gr(2L,0L),79L))+gr(9L,1L)+20L,sp());
        sa(td(sp(),10L));
        gw(1L,0L,sp());
        sa(sr());
        if(sp()!=0)goto _19;else goto _14;
    _14:
        gw(7L,1L,tm(gr(7L,1L)+6L,18L));
        gw(8L,1L,tm(gr(8L,1L)+6L,18L));
        gw(9L,1L,tm(gr(9L,1L)+6L,18L));
        sp();
        if(gr(1L,1L)<=gr(2L,1L))goto _15;else goto _18;
    _15:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _17;else goto _16;
    _16:
        sp();
        System.Console.Out.Write((long)(gr(4L,0L)));
        return;
    _17:
        gw(1L,0L,0L);
        gw(2L,0L,394L);
        goto _4;
    _18:
        gw(4L,0L,gr(4L,0L)+1L);
        goto _15;
    _19:
        sa(sp()-1L);
        sa(sr());
        sa(sr());
        sa(sr());
        gw(2L,0L,sp());
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+gr(7L,1L)+20L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+gr(8L,1L)+20L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*2L);
        sa(sp()+gr(1L,0L));
        sa(sp()+sp());
        sa(tm(sr(),10L));
        sa(sr());
        goto _10;
    _20:
        gw(2L,1L,sp());
        goto _13;
    _21:
        sa(sp()-1L);
        sa(sr());
        sa(sr());
        sa(sr());
        gw(2L,0L,sp());
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+gr(7L,0L)+2L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((tm(sr(),79L))+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),79L));
        sa(sp()+gr(8L,0L)+2L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*2L);
        sa(sp()+gr(1L,0L));
        sa(sp()+sp());
        sa(tm(sr(),10L));
        sa(sr());
        goto _5;
    _22:
        gw(1L,1L,sp());
        goto _8;
}}