/* compiled with BefunCompile v1.0.4 (c) 2015 */
public static class Program 
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrd3z+Y1OQgc+BieKaI3YVpiqrDTmWX8SVecJ+991ynMf78x18tl1daNt/r/6xta8ykrcR++lyP/YbIOIwPR4IHXu7/1a3eE/Dbb9X1n"+
                                    "9u+M2vmLf76+8yg1MNVXMzE1d1qqkuOR3Z82Zva0SQdb8P5Ri80rP+vltK8r+mvupXn3bdctyj6kMnl66/RL3Z6PN1wX337iq2zsY08NVzu7y7kdxpOrN8atKuEpnixV"+
                                    "v2ei524PI98dO/VMptvE3ug/HPJjvfzt+idfMgM9C6ZW1GplXOFd+MOErzXujVrvyTtZC2W5cuMzkhfOFctSun733e5/3E/u7f8QfmvePRuzuf5iarUGZ87O5H9wIfDy"+
                                    "zLffi9Wnsh8uLwji146JvWN1ebsSr88b57Q3zkc33d24a+9Gv+kbJl+x8ljbrfr46cJndTsMw7vrq+w8emu7bu7oDU8+xxTW0MnAAAB8+2yueAEAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<400&&y<88)?g[y*400+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<400&&y<88)g[y*400+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _3;
    _0:
        if(sp()!=0)goto _14; else goto _16;
    _1:
        if((tm(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(1)),2))!=0)goto _7;else goto _17;
    _2:
        if((tm(gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+(1)),2))!=0)goto _20;else goto _19;
    _3:
        gw(1,0,400);
        gw(0,0,30000);
        sa((gr(0,0))-(1));
        sa((gr(0,0))-(1));
        gw(2,0,(gr(0,0))-(1));
        goto _4;
    _4:
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        goto _14;
    _5:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _0;
    _6:
        gw(0,1,0);
        gw(4,0,gr(0,0));
        sp();
        sp();
        goto _17;
    _7:
        gw(5,0,(gr(4,0))+(1));
        goto _19;
    _8:
        gw(tm((gr(4,0))+(gr(5,0)),gr(1,0)),(td((gr(4,0))+(gr(5,0)),gr(1,0)))+(1),(tm(gr(tm((gr(4,0))+(gr(5,0)),gr(1,0)),(td((gr(4,0))+(gr(5,0)),gr(1,0)))+(1)),2))+(2));
        goto _19;
    _9:
        gw(8,0,0);
        gw(2,0,gr(0,0));
        goto _15;
    _10:
        System.Console.Out.Write((long)(gr(8,0)));
        return;
    _11:
        gw(8,0,(gr(8,0))+(gr(2,0)));
        goto _18;
    _12:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(sr());
        gw(2,0,sp());
        goto _4;
    _13:
        sa(sr());
        gw(3,0,sp());
        sa(sp()+sp());
        sa((gr(3,0))-(1));
        sa((gr(3,0))-(1));
        goto _0;
    _14:
        sa(sr());
        sa(gr(2,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        if(sp()!=0)goto _5; else goto _13;
    _15:
        gw(2,0,(gr(2,0))-(1));
        if((td(gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1)),2))!=0)goto _18;else goto _11;
    _16:
        sp();
        sa(gr(2,0));
        {long v0=sp();sa((sp()>v0)?1:0);}
        gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1),sp());
        sa(sr());
        if(sp()!=0)goto _12; else goto _6;
    _17:
        sa((gr(4,0))-(1));
        gw(4,0,(gr(4,0))-(1));
        if(sp()!=0)goto _1; else goto _9;
    _18:
        sa(gr(2,0));
        if(sp()!=0)goto _15; else goto _10;
    _19:
        sa((gr(5,0))-(1));
        gw(5,0,(gr(5,0))-(1));
        if(sp()!=0)goto _2; else goto _17;
    _20:
        sa(((gr(4,0))+(gr(5,0)))>(gr(0,0))?1:0);
        if(sp()!=0)goto _19; else goto _8;
}}