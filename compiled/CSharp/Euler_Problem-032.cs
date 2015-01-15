/* compiled with BefunCompile v1.0.3 (c) 2015 */
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
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _37;
    _0:
        if(sp()!=0)goto _121; else goto _38;
    _1:
        if(sp()!=0)goto _120; else goto _40;
    _2:
        if(sp()!=0)goto _42; else goto _119;
    _3:
        if(sp()!=0)goto _43; else goto _118;
    _4:
        if(sp()!=0)goto _44; else goto _41;
    _5:
        if(sp()!=0)goto _46; else goto _117;
    _6:
        if(sp()!=0)goto _47; else goto _115;
    _7:
        if(sp()!=0)goto _48; else goto _45;
    _8:
        if(sp()!=0)goto _50; else goto _114;
    _9:
        if(sp()!=0)goto _51; else goto _112;
    _10:
        if(sp()!=0)goto _52; else goto _49;
    _11:
        if(sp()!=0)goto _111; else goto _53;
    _12:
        if(sp()!=0)goto _54; else goto _110;
    _13:
        if(sp()!=0)goto _56; else goto _57;
    _14:
        if(sp()!=0)goto _58; else goto _59;
    _15:
        if(sp()!=0)goto _60; else goto _109;
    _16:
        if(sp()!=0)goto _108; else goto _62;
    _17:
        if(sp()!=0)goto _64; else goto _107;
    _18:
        if(sp()!=0)goto _65; else goto _106;
    _19:
        if(sp()!=0)goto _66; else goto _63;
    _20:
        if(sp()!=0)goto _68; else goto _105;
    _21:
        if(sp()!=0)goto _69; else goto _103;
    _22:
        if(sp()!=0)goto _70; else goto _67;
    _23:
        if(sp()!=0)goto _72; else goto _102;
    _24:
        if(sp()!=0)goto _73; else goto _100;
    _25:
        if(sp()!=0)goto _74; else goto _71;
    _26:
        if(sp()!=0)goto _99; else goto _75;
    _27:
        if(sp()!=0)goto _76; else goto _98;
    _28:
        if(sp()!=0)goto _78; else goto _79;
    _29:
        if(sp()!=0)goto _97; else goto _80;
    _30:
        if(sp()!=0)goto _96; else goto _82;
    _31:
        if(sp()!=0)goto _85; else goto _86;
    _32:
        if(sp()!=0)goto _87; else goto _88;
    _33:
        if(sp()!=0)goto _93; else goto _89;
    _34:
        if(sp()!=0)goto _95; else goto _94;
    _35:
        if(sp()!=0)goto _91; else goto _92;
    _36:
        if(sp()!=0)goto _84; else goto _83;
    _37:
        sa(31);
        sa(31);
        goto _0;
    _38:
        gw(1,0,1);
        gw(8,0,9999);
        sp();
        sa(9);
        sa(9);
        goto _39;
    _39:
        sa(gr(8,0));
        sa(9);
        sa(9);
        goto _1;
    _40:
        sp();
        sa(sr());
        goto _41;
    _41:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _2;
    _42:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        goto _3;
    _43:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _4;
    _44:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _45;
    _45:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _5;
    _46:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        goto _6;
    _47:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _7;
    _48:
        sp();
        sa(sp()*sp());
        sa(sr());
        goto _49;
    _49:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _8;
    _50:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        goto _9;
    _51:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _10;
    _52:
        sp();
        sa(9);
        sa(9);
        goto _11;
    _53:
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
        goto _12;
    _54:
        sa(gr(1,0));
        gw(1,0,(gr(1,0))+(1));
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _55;
    _55:
        sa((gr(8,0))-(1));
        sa(((gr(8,0))-(1))-(1000));
        goto _13;
    _56:
        gw(8,0,sp());
        sa(sr());
        goto _39;
    _57:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        goto _14;
    _58:
        gw(8,0,9999);
        sa(sr());
        goto _39;
    _59:
        sp();
        sa(1);
        goto _15;
    _60:
        gw(8,0,999);
        sa(99);
        sa(99);
        goto _61;
    _61:
        sa(gr(8,0));
        sa(9);
        sa(9);
        goto _16;
    _62:
        sp();
        sa(sr());
        goto _63;
    _63:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _17;
    _64:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        goto _18;
    _65:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _19;
    _66:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _67;
    _67:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _20;
    _68:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        goto _21;
    _69:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _22;
    _70:
        sp();
        sa(sp()*sp());
        sa(sr());
        goto _71;
    _71:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _23;
    _72:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        goto _24;
    _73:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _25;
    _74:
        sp();
        sa(9);
        sa(9);
        goto _26;
    _75:
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
        goto _27;
    _76:
        sa(gr(1,0));
        gw(1,0,(gr(1,0))+(1));
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _77;
    _77:
        sa((gr(8,0))-(1));
        sa(((gr(8,0))-(1))-(100));
        goto _28;
    _78:
        sa(0);
        goto _15;
    _79:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(10);
        {long v0=sp();sa(sp()-v0);}
        goto _29;
    _80:
        gw(8,0,32);
        gw(7,0,(gr(8,0))-(1));
        sp();
        goto _81;
    _81:
        sa(gr(gr(8,0),2));
        sa(((gr(gr(8,0),2))!=0)?0:1);
        goto _30;
    _82:
        sa(gr(gr(7,0),2));
        {long v0=sp();sa(sp()-v0);}
        goto _36;
    _83:
        gw(gr(7,0),2,0);
        goto _84;
    _84:
        sa(gr(7,0));
        sa((gr(7,0))-(1));
        goto _31;
    _85:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        gw(7,0,sp());
        goto _81;
    _86:
        sp();
        sa(gr(8,0));
        sa((gr(8,0))-(2));
        goto _32;
    _87:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        gw(8,0,sp());
        gw(7,0,(gr(8,0))-(1));
        goto _81;
    _88:
        sp();
        sa(0);
        sa(31);
        sa(31);
        goto _33;
    _89:
        sp();
        goto _90;
    _90:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _35;
    _91:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _90;
    _92:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _93:
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        goto _34;
    _94:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _33;
    _95:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _33;
    _96:
        sp();
        goto _84;
    _97:
        sa(999);
        goto _78;
    _98:
        sp();
        goto _77;
    _99:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _26;
    _100:
        sp();
        goto _101;
    _101:
        sp();
        sp();
        sa(0);
        sa(0);
        goto _27;
    _102:
        sp();
        goto _101;
    _103:
        sp();
        goto _104;
    _104:
        sp();
        goto _101;
    _105:
        sp();
        goto _104;
    _106:
        sp();
        goto _104;
    _107:
        sp();
        goto _104;
    _108:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _16;
    _109:
        gw(8,0,sp());
        sa(sr());
        goto _61;
    _110:
        sp();
        goto _55;
    _111:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _11;
    _112:
        sp();
        goto _113;
    _113:
        sp();
        sp();
        sa(0);
        sa(0);
        goto _12;
    _114:
        sp();
        goto _113;
    _115:
        sp();
        goto _116;
    _116:
        sp();
        goto _113;
    _117:
        sp();
        goto _116;
    _118:
        sp();
        goto _116;
    _119:
        sp();
        goto _116;
    _120:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _1;
    _121:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _0;
}}