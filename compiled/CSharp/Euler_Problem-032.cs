/* compiled with BefunCompile v1.0.4 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADVVsFuwyAM/RUK7ALKhrNGbVBk7UOi9NBVuXLilI8fISRNm5S1nbq074CMjeQn7Ae25CXAeyxNJAoWx9L0Xg3WpKXSxdI0IkBKKBICiW6WpvI77NIE"+
                                    "JnClFXR/oL7ELT2jgADvK24NnNQf7XENHm7/GLVlDS4Fgqo1SFAmNdF7wpwe9lTgVhm9VXWWyaH+qN3uTTeooV41CCUY5/jQq4ZgqWNREY36HG0KHDeZY1A7Z5ZlWyFE"+
                                    "wqodd1tIoo2IXFedxdlx7eDv+d6olQGueDh6pKv5y+RDxU8TTPiO1hujPEQHMlwpzJNVT+zkMFzIMMGiMi/UuUPk4lOCyNcXH8nn0hDSPV3nAuSnY/40GqLftNePOxdX"+
                                    "0BIamqVx9SQUdMDmS4JsWNmkiW7S0Dxu/XTmGtmWY+81We9Jetf3mMDwWRWk0XX6b+PKWIUsNFJXTGLZGbcRKv5ogn4mctL22sKNN9LaqdDZziC9vpBs2vfCK88d0am3"+
                                    "VBipwoOAkhWlZsVOvn89mHdg1bcXqpauuaLbkD+gJTv8AFvIfdyeDQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<166&&y<21)?g[y*166+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<166&&y<21)g[y*166+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _9;
    _0:
        if(sp()!=0)goto _65; else goto _10;
    _1:
        if(sp()!=0)goto _64; else goto _12;
    _2:
        if(sp()!=0)goto _55; else goto _16;
    _3:
        if(sp()!=0)goto _17; else goto _54;
    _4:
        if(sp()!=0)goto _21; else goto _53;
    _5:
        if(sp()!=0)goto _52; else goto _23;
    _6:
        if(sp()!=0)goto _43; else goto _27;
    _7:
        if(sp()!=0)goto _28; else goto _42;
    _8:
        if(sp()!=0)goto _75; else goto _35;
    _9:
        sa(31);
        sa(31);
        goto _0;
    _10:
        gw(1,0,1);
        gw(8,0,9999);
        sp();
        sa(9);
        sa(9);
        goto _11;
    _11:
        sa(gr(8,0));
        sa(9);
        sa(9);
        goto _1;
    _12:
        sp();
        sa(sr());
        goto _66;
    _13:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _88;
    _14:
        sp();
        sa(sp()*sp());
        sa(sr());
        goto _91;
    _15:
        sp();
        sa(9);
        sa(9);
        goto _2;
    _16:
        sp();
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(9);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _3;
    _17:
        sa(gr(1,0));
        gw(1,0,(gr(1,0))+(1));
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _67;
    _18:
        gw(8,0,sp());
        sa(sr());
        goto _11;
    _19:
        gw(8,0,9999);
        sa(sr());
        goto _11;
    _20:
        sp();
        sa(1);
        goto _4;
    _21:
        gw(8,0,999);
        sa(99);
        sa(99);
        goto _22;
    _22:
        sa(gr(8,0));
        sa(9);
        sa(9);
        goto _5;
    _23:
        sp();
        sa(sr());
        goto _69;
    _24:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _80;
    _25:
        sp();
        sa(sp()*sp());
        sa(sr());
        goto _83;
    _26:
        sp();
        sa(9);
        sa(9);
        goto _6;
    _27:
        sp();
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(9);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _7;
    _28:
        sa(gr(1,0));
        gw(1,0,(gr(1,0))+(1));
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _70;
    _29:
        sa(0);
        goto _4;
    _30:
        gw(8,0,32);
        gw(7,0,(gr(8,0))-(1));
        sp();
        goto _72;
    _31:
        gw(gr(7,0),2,0);
        goto _73;
    _32:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        gw(7,0,sp());
        goto _72;
    _33:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        gw(8,0,sp());
        gw(7,0,(gr(8,0))-(1));
        goto _72;
    _34:
        sp();
        sa(0);
        sa(31);
        sa(31);
        goto _8;
    _35:
        sp();
        goto _76;
    _36:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _76;
    _37:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _38:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _8;
    _39:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _8;
    _40:
        sp();
        goto _73;
    _41:
        sa(999);
        goto _29;
    _42:
        sp();
        goto _70;
    _43:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _6;
    _44:
        sp();
        goto _45;
    _45:
        sp();
        sp();
        sa(0);
        sa(0);
        goto _7;
    _46:
        sp();
        goto _45;
    _47:
        sp();
        goto _48;
    _48:
        sp();
        goto _45;
    _49:
        sp();
        goto _48;
    _50:
        sp();
        goto _48;
    _51:
        sp();
        goto _48;
    _52:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _5;
    _53:
        gw(8,0,sp());
        sa(sr());
        goto _22;
    _54:
        sp();
        goto _67;
    _55:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _2;
    _56:
        sp();
        goto _57;
    _57:
        sp();
        sp();
        sa(0);
        sa(0);
        goto _3;
    _58:
        sp();
        goto _57;
    _59:
        sp();
        goto _60;
    _60:
        sp();
        goto _57;
    _61:
        sp();
        goto _60;
    _62:
        sp();
        goto _60;
    _63:
        sp();
        goto _60;
    _64:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _1;
    _65:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _0;
    _66:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _86; else goto _63;
    _67:
        sa((gr(8,0))-(1));
        sa(((gr(8,0))-(1))-(1000));
        if(sp()!=0)goto _18; else goto _68;
    _68:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _19; else goto _20;
    _69:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _78; else goto _51;
    _70:
        sa((gr(8,0))-(1));
        sa(((gr(8,0))-(1))-(100));
        if(sp()!=0)goto _29; else goto _71;
    _71:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(10);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _41; else goto _30;
    _72:
        sa(gr(gr(8,0),2));
        sa(((gr(gr(8,0),2))!=0)?0:1);
        if(sp()!=0)goto _40; else goto _77;
    _73:
        sa(gr(7,0));
        sa((gr(7,0))-(1));
        if(sp()!=0)goto _32; else goto _74;
    _74:
        sp();
        sa(gr(8,0));
        sa((gr(8,0))-(2));
        if(sp()!=0)goto _33; else goto _34;
    _75:
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        if(sp()!=0)goto _39; else goto _38;
    _76:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _36; else goto _37;
    _77:
        sa(gr(gr(7,0),2));
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _73; else goto _31;
    _78:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _79; else goto _50;
    _79:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _24; else goto _69;
    _80:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _81; else goto _49;
    _81:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _82; else goto _47;
    _82:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _25; else goto _80;
    _83:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _84; else goto _46;
    _84:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _85; else goto _44;
    _85:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _26; else goto _83;
    _86:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _87; else goto _62;
    _87:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _13; else goto _66;
    _88:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _89; else goto _61;
    _89:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _90; else goto _59;
    _90:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _14; else goto _88;
    _91:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _92; else goto _58;
    _92:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _93; else goto _56;
    _93:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _15; else goto _91;
}}