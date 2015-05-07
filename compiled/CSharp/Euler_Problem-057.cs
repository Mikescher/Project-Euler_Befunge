/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
        goto _0;
    _0:
        gw(79,6,0);
        gw(79,12,0);
        gw(79,18,0);
        gw(79,24,0);
        gw(79,30,0);
        gw(79,36,0);
        sa(393);
        sa(394);
    _1:
        if(sp()!=0)goto _2; else goto _3;
    _2:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(2);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(8);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(14);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(20);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(26);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(32);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(1);
        sa(sp()+sp());
        goto _1;
    _3:
        gw(79,6,1);
        gw(79,12,1);
        gw(79,30,1);
        gw(7,0,0);
        gw(8,0,6);
        gw(9,0,12);
        gw(7,1,0);
        gw(8,1,6);
        gw(9,1,12);
        gw(1,1,1);
        gw(2,1,1);
        gw(4,0,0);
        gw(1,0,0);
        gw(2,0,394);
        sp();
        sa(999);
    _4:
        sa(394);
        sa((gr(79,(4)+((gr(7,0))+(2))))+(((gr(79,(4)+((gr(8,0))+(2))))*(2))+(gr(1,0))));
        sa(tm((gr(79,(4)+((gr(7,0))+(2))))+(((gr(79,(4)+((gr(8,0))+(2))))*(2))+(gr(1,0))),10));
        sa(tm((gr(79,(4)+((gr(7,0))+(2))))+(((gr(79,(4)+((gr(8,0))+(2))))*(2))+(gr(1,0))),10));
    _5:
        if(sp()!=0)goto _6; else goto _8;
    _6:
        sa((395)-(gr(2,0)));
        sa(((395)-(gr(2,0)))>(gr(1,1))?1:0);
        if(sp()!=0)goto _22; else goto _7;
    _7:
        sp();
    _8:
        gw((tm(gr(2,0),79))+(1),(td(gr(2,0),79))+((gr(9,0))+(2)),sp());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        gw(1,0,sp());
        sa(sr());
        if(sp()!=0)goto _9; else goto _10;
    _9:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(sr());
        sa(sr());
        gw(2,0,sp());
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa((gr(7,0))+(2));
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa((gr(8,0))+(2));
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(2);
        sa(sp()*sp());
        sa(gr(1,0));
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _5;
    _10:
        gw(7,0,tm((gr(7,0))+(6),18));
        gw(8,0,tm((gr(8,0))+(6),18));
        gw(9,0,tm((gr(9,0))+(6),18));
        gw(1,0,0);
        gw(2,0,394);
        sp();
        sa(394);
        sa((gr(79,(4)+((gr(7,1))+(20))))+(((gr(79,(4)+((gr(8,1))+(20))))*(2))+(gr(1,0))));
        sa(tm((gr(79,(4)+((gr(7,1))+(20))))+(((gr(79,(4)+((gr(8,1))+(20))))*(2))+(gr(1,0))),10));
        sa(tm((gr(79,(4)+((gr(7,1))+(20))))+(((gr(79,(4)+((gr(8,1))+(20))))*(2))+(gr(1,0))),10));
    _11:
        if(sp()!=0)goto _12; else goto _14;
    _12:
        sa((395)-(gr(2,0)));
        sa(((395)-(gr(2,0)))>(gr(2,1))?1:0);
        if(sp()!=0)goto _21; else goto _13;
    _13:
        sp();
    _14:
        gw((tm(gr(2,0),79))+(1),(td(gr(2,0),79))+((gr(9,1))+(20)),sp());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        gw(1,0,sp());
        sa(sr());
        if(sp()!=0)goto _20; else goto _15;
    _15:
        gw(7,1,tm((gr(7,1))+(6),18));
        gw(8,1,tm((gr(8,1))+(6),18));
        gw(9,1,tm((gr(9,1))+(6),18));
        sp();
        sa((((gr(1,1))>(gr(2,1))?1:0)!=0)?0:1);
        if(sp()!=0)goto _16; else goto _19;
    _16:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        if(sp()!=0)goto _18; else goto _17;
    _17:
        sp();
        System.Console.Out.Write((long)(gr(4,0)));
        return;
    _18:
        gw(1,0,0);
        gw(2,0,394);
        goto _4;
    _19:
        gw(4,0,(gr(4,0))+(1));
        goto _16;
    _20:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(sr());
        sa(sr());
        gw(2,0,sp());
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa((gr(7,1))+(20));
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(79);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa((gr(8,1))+(20));
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(2);
        sa(sp()*sp());
        sa(gr(1,0));
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _11;
    _21:
        gw(2,1,sp());
        goto _14;
    _22:
        gw(1,1,sp());
        goto _8;
}}