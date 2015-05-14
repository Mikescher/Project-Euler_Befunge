/* compiled with BefunCompile v1.0.5 (c) 2015 */
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
        sa(31);
        sa(31);
    _1:
        if(sp()!=0)goto _2;else goto _3;
    _2:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _1;
    _3:
        gw(1,0,1);
        gw(8,0,9999);
        sp();
        sa(9);
        sa(9);
    _4:
        sa(gr(8,0));
        sa(9);
        sa(9);
    _5:
        if(sp()!=0)goto _6;else goto _7;
    _6:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _5;
    _7:
        sp();
        sa(sr());
    _8:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _9;else goto _93;
    _9:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _10;else goto _92;
    _10:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _11;else goto _8;
    _11:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _12:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _13;else goto _91;
    _13:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _14;else goto _89;
    _14:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _15;else goto _12;
    _15:
        sp();
        sa(sp()*sp());
        sa(sr());
    _16:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _17;else goto _88;
    _17:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _18;else goto _86;
    _18:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _19;else goto _16;
    _19:
        sp();
        sa(9);
        sa(9);
    _20:
        if(sp()!=0)goto _21;else goto _22;
    _21:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _20;
    _22:
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
    _23:
        if(sp()!=0)goto _85;else goto _24;
    _24:
        sp();
    _25:
        sa(gr(8,0)-1);
        sa(gr(8,0)-1-1000);
        if(sp()!=0)goto _84;else goto _26;
    _26:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _83;else goto _27;
    _27:
        sp();
        sa(1);
    _28:
        if(sp()!=0)goto _82;else goto _29;
    _29:
        gw(8,0,sp());
        sa(sr());
    _30:
        sa(gr(8,0));
        sa(9);
        sa(9);
    _31:
        if(sp()!=0)goto _32;else goto _33;
    _32:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _31;
    _33:
        sp();
        sa(sr());
    _34:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _35;else goto _81;
    _35:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _36;else goto _80;
    _36:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _37;else goto _34;
    _37:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _38:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _39;else goto _79;
    _39:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _40;else goto _77;
    _40:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _41;else goto _38;
    _41:
        sp();
        sa(sp()*sp());
        sa(sr());
    _42:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _43;else goto _76;
    _43:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _44;else goto _74;
    _44:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _45;else goto _42;
    _45:
        sp();
        sa(9);
        sa(9);
    _46:
        if(sp()!=0)goto _47;else goto _48;
    _47:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _46;
    _48:
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
    _49:
        if(sp()!=0)goto _73;else goto _50;
    _50:
        sp();
    _51:
        sa(gr(8,0)-1);
        sa(gr(8,0)-1-100);
        if(sp()!=0)goto _54;else goto _52;
    _52:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(10);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _53;else goto _55;
    _53:
        sa(999);
    _54:
        sa(0);
        goto _28;
    _55:
        gw(8,0,32);
        gw(7,0,gr(8,0)-1);
        sp();
    _56:
        sa(gr(gr(8,0),2));
        sa(((gr(gr(8,0),2))!=0)?0:1);
        if(sp()!=0)goto _72;else goto _57;
    _57:
        sa(gr(gr(7,0),2));
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _58;else goto _71;
    _58:
        sa(gr(7,0));
        sa(gr(7,0)-1);
        if(sp()!=0)goto _70;else goto _59;
    _59:
        sp();
        sa(gr(8,0));
        sa(gr(8,0)-2);
        if(sp()!=0)goto _69;else goto _60;
    _60:
        sp();
        sa(0);
        sa(31);
        sa(31);
    _61:
        if(sp()!=0)goto _62;else goto _65;
    _62:
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        if(sp()!=0)goto _63;else goto _64;
    _63:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _61;
    _64:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _61;
    _65:
        sp();
    _66:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _68;else goto _67;
    _67:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _68:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _66;
    _69:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        gw(8,0,sp());
        gw(7,0,gr(8,0)-1);
        goto _56;
    _70:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        gw(7,0,sp());
        goto _56;
    _71:
        gw(gr(7,0),2,0);
        goto _58;
    _72:
        sp();
        goto _58;
    _73:
        sa(gr(1,0));
        gw(1,0,gr(1,0)+1);
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _51;
    _74:
        sp();
    _75:
        sp();
        sp();
        sa(0);
        sa(0);
        goto _49;
    _76:
        sp();
        goto _75;
    _77:
        sp();
    _78:
        sp();
        goto _75;
    _79:
        sp();
        goto _78;
    _80:
        sp();
        goto _78;
    _81:
        sp();
        goto _78;
    _82:
        gw(8,0,999);
        sa(99);
        sa(99);
        goto _30;
    _83:
        gw(8,0,9999);
        sa(sr());
        goto _4;
    _84:
        gw(8,0,sp());
        sa(sr());
        goto _4;
    _85:
        sa(gr(1,0));
        gw(1,0,gr(1,0)+1);
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _25;
    _86:
        sp();
    _87:
        sp();
        sp();
        sa(0);
        sa(0);
        goto _23;
    _88:
        sp();
        goto _87;
    _89:
        sp();
    _90:
        sp();
        goto _87;
    _91:
        sp();
        goto _90;
    _92:
        sp();
        goto _90;
    _93:
        sp();
        goto _90;
}}